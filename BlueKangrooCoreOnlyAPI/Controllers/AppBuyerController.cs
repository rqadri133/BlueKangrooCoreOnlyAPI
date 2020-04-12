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

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>
   
    [Route("api/[controller]")]
    [ApiController]
   [Authorize (Policy = "CustomGuidAuthorization")]
    public class AppBuyerController : ControllerBase
    {
        IBlueKangrooRepository blueRepository ;
        IDistributedCache distributedCache;
      
        private readonly config.IConfiguration configuration;
        public AppBuyerController(IBlueKangrooRepository _blueRepository  , config.IConfiguration _configurtaion , IDistributedCache _distributedCache)
        {
           blueRepository = _blueRepository;
           
            configuration = _configurtaion;
            distributedCache = _distributedCache;
        }

        [HttpGet]
        [Route("GetAllBuyers")]
        [Authorize]
        
        public async Task<IActionResult> GetAllBuyers()
        {
            var cacheKey = "GetAllBuyers_" + Response.Headers["CustomerGuidKey"];
            List<AppBuyer> buyers;
            string serilaizedBuyers = String.Empty;
            var encodedBuyers = await distributedCache.GetAsync(cacheKey);


            try
            {
                if(encodedBuyers != null)
                {
                    serilaizedBuyers = Encoding.UTF8.GetString(encodedBuyers);
                    buyers = JsonConvert.DeserializeObject<List<AppBuyer>>(serilaizedBuyers);
                }
                else
                {
                    buyers = await blueRepository.GetBuyers();
                    if (buyers == null)
                    {
                        return NotFound();
                    }
                    serilaizedBuyers = JsonConvert.SerializeObject(encodedBuyers);
                    encodedBuyers = Encoding.UTF8.GetBytes(serilaizedBuyers);
                    var options = new DistributedCacheEntryOptions()
                                     .SetAbsoluteExpiration(DateTime.Now.AddHours(Convert.ToInt32(configuration["CacheAbsoluteExpirations"])))
                                     .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToInt32(configuration["SlidingExpirationsTimeOutInMinutes"])));

                      await distributedCache.SetAsync(cacheKey, encodedBuyers, options);
                }


                return Ok(buyers);
            }
            catch (Exception excp)
            {
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
                var selectedBuyer = await blueRepository.GetBuyer(buyerId);

                if (selectedBuyer == null)
                {
                    return NotFound();
                }

                return Ok(selectedBuyer);
            }
            catch (Exception excp)
            {
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
                result = await blueRepository.DeleteBuyer(buyer);
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
        [Route("UpdateBuyer")]
        public async Task<IActionResult> UpdateBuyer([FromBody]AppBuyer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await blueRepository.UpdateBuyer(model);

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


