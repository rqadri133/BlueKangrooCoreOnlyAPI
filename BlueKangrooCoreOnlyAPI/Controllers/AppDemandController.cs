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



namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class AppDemandController : ControllerBase
    {
        IDemandRepository demandRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppDemand> cacheManager;
        private readonly IConfiguration configuration;
        private ILogger logger;

        public AppDemandController(IDemandRepository _demandRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppDemand> _cacheManager  , ILogger<AppDemandController> _logger)
        {
            demandRepo = _demandRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllDemands")]
        [Authorize]
        public async Task<IActionResult> GetAllDemands()
        {

            var cacheKey = "GetAllDemands_" + Request.Headers["CustomerGuidKey"];
            List<AppDemand> demands = new List<AppDemand>();
            logger.LogInformation("Accessing Demands from Elastic Cache");

            var encodedDemands = await distributedCache.GetAsync(cacheKey);

            try
            {
                if (encodedDemands == null)
                {
                    logger.LogInformation("Loading Demands from Repository");                    
                    demands = await  demandRepo.LoadAllDemands();
                    if (demands == null)
                    {
                        return NotFound();
                    }
                }
                demands = await cacheManager.ProcessCache(demands, cacheKey, encodedDemands, configuration, distributedCache);

                return Ok(demands);
            }
            catch (Exception excp)
            {
                logger.LogError("Error Loading Demands from Repository " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }


        [HttpPost]
        [Route("AddDemand")]
        [Authorize]
        public async Task<IActionResult> AddDemand([FromBody]AppDemand model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Demand in the Repository");
                    var addedDemand = await demandRepo.AddProductDemand(model);
                    if (addedDemand != null)
                    {
                        return Ok(addedDemand);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error in adding Demand in the Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetDemandInfo/{DemandId}")]
        public async Task<IActionResult> GetDemandInfo(Guid? demandId)
        {
            if (demandId == null)
            {
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Getting Single Demand from Repository");
                var selectedDemand = await demandRepo.GetDemandInfo(demandId);

                if (selectedDemand == null)
                {
                    return NotFound();
                }

                return Ok(selectedDemand);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in fetching demand from repository " + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteDemand")]
        public async Task<IActionResult> DeleteDemand(Guid demandId)
        {
            int result = 0;

            if (demandId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await  demandRepo.DeleteDemandInfo(demandId);
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
        [Route("UpdateDemand")]
        public async Task<IActionResult> UpdateDemand([FromBody]AppDemand demand)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await demandRepo.UpdateDemand(demand);

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