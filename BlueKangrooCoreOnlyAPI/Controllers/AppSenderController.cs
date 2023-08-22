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
    public class AppSenderController : ControllerBase
    {
        ISenderRepository senderRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppSender> cacheManager;
        private readonly IConfiguration configuration;
        private ILogger logger;

        public AppSenderController(ISenderRepository _senderRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppSender> _cacheManager  , ILogger<AppSenderController> _logger)
        {
            senderRepo = _senderRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }


    }
}