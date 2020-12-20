using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using BlueKangrooCoreOnlyAPI.Headers;
using config = Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Caching.Distributed;

namespace BlueKangrooCoreOnlyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class AppUserDetailsController : ControllerBase
    {
        IBlueKangrooRepository blueRepository;
        IDistributedCache distributedCache;
        config.IConfiguration configuration;
        ICacheManager<AppUser> cacheManager;
        ILogger logger;

        public AppUserDetailsController(IBlueKangrooRepository _blueRepository, config.IConfiguration _configurtaion, IDistributedCache _distributedCache, ILogger<AppUserDetailsController> _logger, ICacheManager<AppUser> _cacheManager)
        {
            blueRepository = _blueRepository;
            configuration = _configurtaion;
            logger = _logger;
            cacheManager = _cacheManager;
            distributedCache = _distributedCache;
        }


        [HttpGet]
        [Route("GetAllUsers")]
        [Authorize]
        public async Task<IActionResult> GetAllUser()
        {

            var cacheKey = "GetAllUsers_" + Request.Headers["CustomerGuidKey"];
            List<AppUser> users = new List<AppUser>();
             logger.LogInformation("API Called with a cache key" + cacheKey);

            var encodedUsers = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedUsers == null)
                {
                    logger.LogInformation("Before Calling Repository");

                    users = await blueRepository.GetAllUsers();
                    if (users == null)
                    {
                        return NotFound();
                    }
                }
                users = await cacheManager.ProcessCache(users, cacheKey, encodedUsers, configuration, distributedCache);
                logger.LogInformation("Get Cached Data from Users Count Loaded" + users.Count);
            }
            catch (Exception excp)
            {
                logger.LogError("In the catch Block of Get All Users" + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }

            return Ok(users);


        }



        [HttpPost]
        [Route("AddUser")]
        [Authorize]
        public async Task<IActionResult> AddUser([FromBody]AppUser model)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    var user = await blueRepository.AddUser(model);
                    if (user != null)
                    {
                        return Ok(new { tokenId = user.AppUserName } );
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


    }
}