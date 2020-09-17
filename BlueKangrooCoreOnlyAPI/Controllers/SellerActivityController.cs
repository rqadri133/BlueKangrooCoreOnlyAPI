using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using BlueKangrooCoreOnlyAPI.Filters;
using Microsoft.Extensions.Caching.Memory;
using config = Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Logging;

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for SellerActivity 
    /// </summary>
   
    [Route("api/[controller]")]
    [ApiController]
   [Authorize (Policy = "CustomGuidAuthorization")]
    public class SellerActivityController : ControllerBase
    {
        ISellerActivityRepository sellerRepository ;
        IDistributedCache distributedCache;
        ICacheManager<AppSellerActivity> cacheManager;
        ILogger logger;

        private readonly config.IConfiguration configuration;
        public SellerActivityController(ISellerActivityRepository _sellerRepository  , config.IConfiguration _configurtaion , IDistributedCache _distributedCache , ICacheManager<AppSellerActivity> _cacheManager , ILogger<SellerActivityController> _logger )
        {
           sellerRepository = _sellerRepository;
           
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllSellersActivities")]
        [Authorize]
        
        public async Task<IActionResult> GetAllSellersActivities()
        {
            var cacheKey = "GetAllSellersActivity_" + Request.Headers["CustomerGuidKey"];
            List<AppSellerActivity> sellersActivities = new List<AppSellerActivity>();
            logger.LogInformation("Fetching Seller Information from Cache");
            var encodedSellers = await distributedCache.GetAsync(cacheKey);
            

            try
            {
                if(encodedSellers == null)
                {
                    logger.LogInformation("Loading Seller Information from Repository");
                    sellersActivities = await sellerRepository.LoadAllSellerActivities();
                    if (sellersActivities == null)
                    {
                        return NotFound();
                    }
                }
                sellersActivities  = await cacheManager.ProcessCache(sellersActivities, cacheKey, encodedSellers, configuration, distributedCache);

                return Ok(sellersActivities);
            }
            catch (Exception excp)
            {
                // client call must know stack exception

                logger.LogError("Error in seller activities " + excp.Message);
                return BadRequest(excp);
            }

        }


        [HttpGet]
        [Route("GetSellerActivity/{sellerActivityId}")]
        public async Task<IActionResult> GetSellerActivity(Guid? sellerActivityId)
        {
            if (sellerActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedSellerActivity = await sellerRepository.GetSellerActivityInfo(sellerActivityId);

                if (selectedSellerActivity == null)
                {
                    return NotFound();
                }

                return Ok(selectedSellerActivity);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpPost]
        [Route("AddSellerActivity")]
        public async Task<IActionResult> AddSellerActivity([FromBody] AppSellerActivity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AppSellerActivityId = Guid.NewGuid();
                    var sellerActivity = await sellerRepository.AddSellerActivity(model);
                    if (sellerActivity != null)
                    {
                        return Ok(sellerActivity);
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
        [Route("DeleteSellerActivity")]
        public async Task<IActionResult> DeleteSellerActivity(Guid? sellerActivityId)
        {
            int result = 0;

            if (sellerActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await sellerRepository.DeleteSellerActivityInfo(sellerActivityId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception excp)
            {

                return BadRequest(excp);
            }
        }


        [HttpPut]
        [Route("UpdateSellerActivity")]
        public async Task<IActionResult> UpdateSellerActivity([FromBody] AppSellerActivity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await sellerRepository.UpdateSellerActivity(model);

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


