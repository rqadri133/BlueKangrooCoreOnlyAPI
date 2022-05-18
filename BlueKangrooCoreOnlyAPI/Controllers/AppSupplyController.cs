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
    public class AppSupplyController : ControllerBase
    {
        ISupplyRepository supplyRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppSupply> cacheManager;
        private readonly IConfiguration configuration;
        public AppSupplyController(ISupplyRepository _supplyRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppSupply> _cacheManager)
        {
            supplyRepo = _supplyRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
        }

        [HttpGet]
        [Route("GetAllSupplies")]
        [Authorize]
        public async Task<IActionResult> GetAllSupplies()
        {

            var cacheKey = "GetAllSupplies_" + Request.Headers["CustomerGuidKey"];
            List<AppSupply> supplies = new List<AppSupply>();
            var encodedSupply = await distributedCache.GetAsync(cacheKey);

            try
            {
                if (encodedSupply == null)
                {
                    supplies = await  supplyRepo.LoadAllSupplies();
                    if (supplies == null)
                    {
                        return NotFound();
                    }
                }
                supplies = await cacheManager.ProcessCache(supplies, cacheKey, encodedSupply, configuration, distributedCache);

                return Ok(supplies);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }


        }


        [HttpPost]
        [Route("AddSupply")]
        [Authorize]
        public async Task<IActionResult> AddSupply([FromBody]AppSupply model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedSupply = await supplyRepo.AddSupplyInfo(model);
                    if (addedSupply != null)
                    {
                        return Ok(addedSupply);
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
        [Route("GetSupplyInfo/{SupplyId}")]
        public async Task<IActionResult> GetSupplyInfo(Guid? supplyId)
        {
            if (supplyId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedSupply = await supplyRepo.GetSupplyInfo(supplyId);

                if (selectedSupply == null)
                {
                    return NotFound();
                }

                return Ok(selectedSupply);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteSupply")]
        public async Task<IActionResult> DeleteSupply(Guid supplyId)
        {
            int result = 0;

            if (supplyId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await  supplyRepo.DeleteSupplyInfo(supplyId);
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
        [Route("UpdateSupply")]
        public async Task<IActionResult> UpdateSupply([FromBody]AppSupply supply)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await supplyRepo.UpdateSupply(supply);

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