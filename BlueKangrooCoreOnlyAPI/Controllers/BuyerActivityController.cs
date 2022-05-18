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

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class BuyerActivityController : ControllerBase
    {
        IBuyerActivityRepository buyerActivityRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppBuyerActivity> cacheManager;
        private readonly IConfiguration configuration;
        public BuyerActivityController(IBuyerActivityRepository _buyerActivityRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppBuyerActivity> _cacheManager)
        {
            buyerActivityRepo = _buyerActivityRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
        }

        [HttpGet]
        [Route("GetAllBuyerActivitys")]
        [Authorize]
        public async Task<IActionResult> GetAllBuyerActivity()
        {

            var cacheKey = "GetAllBuyerActivities_" + Request.Headers["CustomerGuidKey"];
            List<AppBuyerActivity> activities = new List<AppBuyerActivity>();

            var encodedBuyerActivitys = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedBuyerActivitys == null)
                {
                    activities = await buyerActivityRepo.LoadAllBuyerActivities();
                    if (activities == null)
                    {
                        return NotFound();
                    }
                }
                activities = await cacheManager.ProcessCache(activities, cacheKey, encodedBuyerActivitys, configuration, distributedCache);

                return Ok(activities);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddBuyerActivity")]
        [Authorize]
        public async Task<IActionResult> AddBuyerActivity([FromBody]AppBuyerActivity model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedActivity = await buyerActivityRepo.AddBuyerActivity(model);
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
        [Route("GetBuyerActivityInfo/{BuyerActivityId}")]
        public async Task<IActionResult> GetBuyerActivityInfo(Guid? BuyerActivityId)
        {
            if (BuyerActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedActivity = await buyerActivityRepo.GetBuyerActivityInfo(BuyerActivityId);

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
        [Route("DeleteBuyerActivity")]
        public async Task<IActionResult> DeleteBuyerActivity(Guid BuyerActivityId)
        {
            int result = 0;

            if (BuyerActivityId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await buyerActivityRepo.DeleteBuyerActivityInfo(BuyerActivityId);
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
        [Route("UpdateBuyerActivity")]
        public async Task<IActionResult> UpdateBuyerActivity([FromBody]AppBuyerActivity buyerActivity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await buyerActivityRepo.UpdateBuyerActivity(buyerActivity);

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