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
    public class FreightController : ControllerBase
    {
        IFreightRepository freightRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppFreight> cacheManager;
        private readonly IConfiguration configuration;
        public FreightController(IFreightRepository _freightRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppFreight> _cacheManager)
        {
            freightRepo = _freightRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
        }

        [HttpGet]
        [Route("GetAllFreights")]
        [Authorize]
        public async Task<IActionResult> GetAllFreight()
        {

            var cacheKey = "GetAllFreights_" + Request.Headers["CustomerGuidKey"];
            List<AppFreight> freights = new List<AppFreight>();

            var encodedFreights = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedFreights == null)
                {
                    freights = await freightRepo.LoadAllFreights();
                    if (freights == null)
                    {
                        return NotFound();
                    }
                }
                freights = await cacheManager.ProcessCache(freights, cacheKey, encodedFreights, configuration, distributedCache);

                return Ok(freights);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddFreight")]
        [Authorize]
        public async Task<IActionResult> AddFreight([FromBody]AppFreight model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedFreight = await freightRepo.AddFreight(model);
                    if (addedFreight != null)
                    {
                        return Ok(addedFreight);
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
        [Route("GetFreightInfo/{freightId}")]
        public async Task<IActionResult> GetFreightInfo(Guid? freightId)
        {
            if (freightId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedFreight = await freightRepo.GetFreightInfo(freightId);

                if (selectedFreight == null)
                {
                    return NotFound();
                }

                return Ok(selectedFreight);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteFreight")]
        public async Task<IActionResult> DeleteFreight(Guid freightId)
        {
            int result = 0;

            if (freightId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await freightRepo.DeleteFreightInfo(freightId);
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
        [Route("UpdateFreight")]
        public async Task<IActionResult> UpdateFreight([FromBody]AppFreight freight)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await freightRepo.UpdateFreight(freight);

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