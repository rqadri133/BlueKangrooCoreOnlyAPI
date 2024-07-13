 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Google.Rpc;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlueKangrooCoreOnlyAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "CustomGuidAuthorization")]

    public class AppSellerController : Controller
    {
        IBlueKangrooRepository blueRepository;
        IDistributedCache distributedCache;
        ICacheManager<AppSeller> cacheManager;
        ILogger logger;
        private readonly IConfiguration configuration;
        public AppSellerController(IBlueKangrooRepository _blueRepository , IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppSeller> _cacheManager , ILogger<AppSellerController> _logger)
        {
            blueRepository = _blueRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }


        [HttpGet]
        [Route("GetSellers")]
        [Authorize]
        public async Task<IActionResult> GetSellers()
        {
            var cacheKey = "GetAllSellers_" + Request.Headers["CustomerGuidKey"];
            List<AppSeller> sellers = new List<AppSeller>();
            logger.LogInformation("Fetching Sellers from Cache Key");
            var encodedSellers = await distributedCache.GetAsync(cacheKey);
            try
            {
                if (encodedSellers == null)
                {
                    logger.LogInformation("Fetching Sellers from Repository");

                    sellers = await blueRepository.GetSellers();
                    if (sellers == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Storing  Sellers in Cache");

                sellers = await cacheManager.ProcessCache(sellers, cacheKey, encodedSellers, configuration, distributedCache);

                return Ok(sellers);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in loading Sellers from Repository/Cache " + excp.Message  );
                // client call must know stack exception
                return BadRequest(excp);
            }


        }


        [HttpGet]
        [Route("GetSeller/{sellerId}")]
        [Authorize]
        public async Task<IActionResult> GetSeller(Guid? sellerId)
        {
            if (sellerId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedSeller = await blueRepository.GetSeller(sellerId);

                if (selectedSeller == null)
                {
                    return NotFound();
                }

                return Ok(selectedSeller);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpPost]
        [Route("AddSeller")]
        [Authorize]
        public async Task<IActionResult> AddSeller([FromBody]AppSeller model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AppSellerId = Guid.NewGuid();
                    var appSeller = await blueRepository.AddSeller(model);
                    if (appSeller != null)
                    {
                        return Ok(appSeller);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {

                    return BadRequest(excp);
                }

            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteSeller")]
        public async Task<HttpResponseMessage> DeleteSeller([FromBody]AppSeller seller)
        {
              int result = 0;
              // The microservice response messages must be handled properly 
             if (seller == null)
             {
                var responses = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                return responses;   
             
             }

            try
            {
                result = await blueRepository.DeleteSeller(seller);
                if (result == 0)
                {
                    var responses = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                    return responses; 
                }
                // Means this data no longer exist its gone 
                var deletedResponse = new HttpResponseMessage(System.Net.HttpStatusCode.Gone);  
                return deletedResponse;
            }
            catch (Exception excp)
            {

               // Means this data no longer exist its gone 
                var expenseResponse = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);  
                return expenseResponse;
            }
        }


        [HttpPut]
        [Route("UpdateSeller")]
        public async Task<IActionResult> UpdateSeller([FromBody]AppSeller model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await blueRepository.UpdateSeller(model);

                    return Ok();
                }
                catch (Exception excp)
                {
                    if (excp.GetType().FullName ==
                             "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest(excp);
                }
            }

            return BadRequest();
        }



    }
}
