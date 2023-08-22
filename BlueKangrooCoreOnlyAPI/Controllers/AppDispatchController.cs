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
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class AppDisptachController : ControllerBase
    {
        /// <summary>
        /// this will provide crud operations for AppBuyer 
        /// </summary>
        IDispatchRepository dispatchRepository;
        IDistributedCache distributedCache;
        ICacheManager<AppDispatch> cacheManager;
        private ILogger logger;
        private readonly IConfiguration configuration;
        public AppDisptachController(IDispatchRepository _dispatchRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppDispatch> _cacheManager, ILogger<AppDisptachController> _logger)
        {
              dispatchRepository = _dispatchRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

      


    }
}