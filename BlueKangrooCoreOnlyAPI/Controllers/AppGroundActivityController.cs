using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Configuration;

namespace BlueKangrooCoreOnlyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppGroundActivityController : ControllerBase
    {
        IGroundLogistics groundLogistics;
        IDistributedCache distributedCache;
        ICacheManager<AppGroundActivity> cacheManager;
        private ILogger logger;
        private readonly IConfiguration configuration;

        public AppGroundActivityController(IGroundLogistics _groundLogistics, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppGroundActivity> _cacheManager, ILogger<AppGroundActivityController> _logger)
        {
            groundLogistics = _groundLogistics;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
            configuration = _configurtaion;
        }

        [HttpGet]
        [Route("GetAllGroundActivities")]
        [Authorize]
        public async Task<IActionResult> GetAllGroundActivities()
        {
            var cacheKey = "GetAllGroundActivitys_" + Request.Headers["CustomerGuidKey"];
            List<AppGroundActivity> groundActivities = new List<AppGroundActivity>();

            var encodedGroundActivitys = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedGroundActivitys == null)
                {
                    groundActivities = await groundLogistics.LoadAllGroundActivities();
                    if (groundActivities == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Ground Activity Starts Caching");
                groundActivities = await cacheManager.ProcessCache(groundActivities, cacheKey, encodedGroundActivitys, configuration, distributedCache);

                return Ok(groundActivities);
            }
            catch (Exception excp)
            {
                logger.LogError("Error while loading all ground activities " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddGroundActivity")]
        [Authorize]
        public async Task<IActionResult> AddGroundActivity([FromBody]AppGroundActivity model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Ground Activity Starts Adding one ground activity");
                    var groundActivityNew = await groundLogistics.AddGroundActity(model);
                    if (groundActivityNew != null)
                    {
                        return Ok(groundActivityNew);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error in adding ground Activity issued here " + excp.Message);
                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetGroundActivity/{groundActivityId}")]
        public async Task<IActionResult> GetGroundActivity(Guid groundActivityId)
        {
            if (groundActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Loading single ground activity");
                var selectedLogistics = await groundLogistics.GetGroundActivity(groundActivityId);

                if (selectedLogistics == null)
                {
                    return NotFound();
                }

                return Ok(selectedLogistics);
            }
            catch (Exception excp)
            {
                logger.LogError("Unable to load single croud activity" + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteGroundActivity")]
        public async Task<IActionResult> DeleteGroundActivity(Guid groundActivityId)
        {
            int result = 0;

            if (groundActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Deleting ground activity");

                result = await groundLogistics.DeleteAppGroundActivity(groundActivityId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception excp)
            {
                logger.LogError("Deleting ground activity " + excp.Message);

                return BadRequest(excp);
            }
        }


        [HttpPut]
        [Route("UpdateGroundActivity")]
        public async Task<IActionResult> UpdateGroundActivity([FromBody]AppGroundActivity grActivity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Updating ground activity for single activity");
                    await groundLogistics.UpdateGroundActivity(grActivity);

                    return Ok();
                }
                catch (Exception excp)
                {
                    logger.LogError(" Unable to update activity " + excp.Message);

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
