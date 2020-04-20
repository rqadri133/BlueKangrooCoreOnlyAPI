﻿using System;
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

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class ActivityController : ControllerBase
    {
        IActivityRepository activityRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppActivity> cacheManager;
        private readonly IConfiguration configuration;
        public ActivityController(IActivityRepository _ActivityRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppActivity> _cacheManager)
        {
            activityRepo = _ActivityRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
        }

        [HttpGet]
        [Route("GetAllActivitys")]
        [Authorize]
        public async Task<IActionResult> GetAllActivity()
        {

            var cacheKey = "GetAllActivitys_" + Request.Headers["CustomerGuidKey"];
            List<AppActivity> Activitys = new List<AppActivity>();

            var encodedActivitys = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedActivitys == null)
                {
                    Activitys = await activityRepo.LoadAllActivities();
                    if (Activitys == null)
                    {
                        return NotFound();
                    }
                }
                Activitys = await cacheManager.ProcessCache(Activitys, cacheKey, encodedActivitys, configuration, distributedCache);

                return Ok(Activitys);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddActivity")]
        [Authorize]
        public async Task<IActionResult> AddActivity([FromBody]AppActivity model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedActivity = await activityRepo.AddActivity(model);
                    if (addedActivity != null)
                    {
                        return Ok(addedActivity);
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



        [HttpGet]
        [Route("GetActivityInfo/{ActivityId}")]
        public async Task<IActionResult> GetActivityInfo(Guid? ActivityId)
        {
            if (ActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedActivity = await activityRepo.GetActivityInfo(ActivityId);

                if (selectedActivity == null)
                {
                    return NotFound();
                }

                return Ok(selectedActivity);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteActivity")]
        public async Task<IActionResult> DeleteActivity(Guid ActivityId)
        {
            int result = 0;

            if (ActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await activityRepo.DeleteActivityInfo(ActivityId);
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
        [Route("UpdateActivity")]
        public async Task<IActionResult> UpdateActivity([FromBody]AppActivity Activity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await activityRepo.UpdateActivity(Activity);

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