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
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using BlueKangrooCoreOnlyAPI.Caching;

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    [AutoValidateAntiforgeryToken]
    public class AppBuyerController : ControllerBase
    {
        IBlueKangrooRepository blueRepository;
        IDistributedCache distributedCache;
        ICacheManager<AppBuyer> cacheManager;
        private readonly ILogger _logger;
        private readonly config.IConfiguration configuration;
        public AppBuyerController(IBlueKangrooRepository _blueRepository, config.IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppBuyer> _cacheManager, ILogger<AppBuyerController> logger)
        {
            blueRepository = _blueRepository;

            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            _logger = logger;
            _logger.LogInformation("API Called ");
        }

        [HttpGet]
        [Route("GetAllBuyers")]
        [Authorize]

        public async Task<IActionResult> GetAllBuyers()
        {
            var cacheKey = "GetAllBuyers_" + Request.Headers["CustomerGuidKey"];
            List<AppBuyer> buyers = new List<AppBuyer>();
            _logger.LogInformation("API Called with a cache key" + cacheKey);

            var encodedBuyers = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedBuyers == null)
                {
                    _logger.LogInformation("Before Calling Repository");

                    buyers = await blueRepository.GetBuyers();
                    if (buyers == null)
                    {
                        return NotFound();
                    }
                }
                buyers = await cacheManager.ProcessCache(buyers, cacheKey, encodedBuyers, configuration, distributedCache);
                _logger.LogInformation("Get Cached Data from Buyers Count Loaded" + buyers.Count);
                return Ok(buyers);
            }
            catch (Exception excp)
            {
                _logger.LogError("In the catch Block of Get All Buyer" + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }

        }


        [HttpGet]
        [Route("GetBuyer/{buyerId}")]
        public async Task<IActionResult> GetBuyer(Guid? buyerId)
        {
            if (buyerId == null)
            {
                return BadRequest();
            }

            try
            {
                _logger.LogInformation("Before Calling Repository to retreive specific buyer " + buyerId);
                var selectedBuyer = await blueRepository.GetBuyer(buyerId);

                if (selectedBuyer == null)
                {
                    return NotFound();
                }

                return Ok(selectedBuyer);
            }
            catch (Exception excp)
            {
                _logger.LogError("Error getting buyer information for " + buyerId + "due to exception" + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpPost]
        [Route("AddBuyer")]
        public async Task<IActionResult> AddBuyer([FromBody]AppBuyer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AppBuyerId = Guid.NewGuid();
                    _logger.LogInformation("Add buyer information ");
                    var appBuyer = await blueRepository.AddBuyer(model);
                    if (appBuyer != null)
                    {
                        return Ok(appBuyer);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    _logger.LogError("Error adding buyer information " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteBuyer")]
        public async Task<IActionResult> DeleteBuyer([FromBody]AppBuyer buyer)
        {
            int result = 0;

            if (buyer == null)
            {
                return BadRequest();
            }

            try
            {
                _logger.LogInformation("Delete buyer information ");
                result = await blueRepository.DeleteBuyer(buyer);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception excp)
            {
                _logger.LogError("Error deleting buyer information " + excp.Message);
                return BadRequest(excp);
            }
        }


        [HttpPut]
        [Route("UpdateBuyer")]
        public async Task<IActionResult> UpdateBuyer([FromBody]AppBuyer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _logger.LogInformation("Update buyer information ");
                    await blueRepository.UpdateBuyer(model);

                    return Ok();
                }
                catch (Exception excp)
                {
                    _logger.LogError("Error in updating buyer informaton " + excp.Message);
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


