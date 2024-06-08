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

using BlueKangrooCoreOnlyAPI.Utilities;
using System.Drawing.Printing;

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for We are only going to Load Packages 
    /// this will only cache the packages in sever memory as per customer Guid 
    /// will retrive from it and add it to package handlers
    /// PAckage will only be picked from Redis Cache dotnet
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class PackageHandlerController : ControllerBase
    {
        IDistributedCache distributedCache;
        ICacheManager<PackageDetails> cacheManager;
        private readonly IConfiguration configuration;
        private ILogger logger;

        public PackageHandlerController(IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<PackageDetails> _cacheManager  , ILogger<PackageHandlerController> _logger)
        {
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllPackages/{packageList}")]
        [Authorize]
        public async Task<IActionResult> AddorRetreivetAllPAckages(List<PackageDetails> packageList)
        {

            var cacheKey = "GetAllPackagess_" + Request.Headers["CustomerGuidKey"];
            List<PackageDetails> packages = new List<PackageDetails>();
            logger.LogInformation("Accessing PAckages from Elastic Cache");

            var encodedPackages = await distributedCache.GetAsync(cacheKey);

            try
            {
                if (encodedPackages == null)
                {
                    if (packages == null)
                    {
                        return NotFound();
                    }
                }
                else 
                {
                    packages = packageList;
                              
                }
                packages = await cacheManager.ProcessCache(packages, cacheKey, encodedPackages, configuration, distributedCache);

                return Ok(packages);
            }
            catch (Exception excp)
            {
                logger.LogError("Error Loading PAckages from Repository " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }


    }
}