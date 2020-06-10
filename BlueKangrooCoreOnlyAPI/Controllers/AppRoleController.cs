﻿using System;
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

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class RoleController : ControllerBase
    {
        IRoleRepository roleRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppUserRole> cacheManager;
        ICacheManager<AppUserRoleDetail> cacheManagerDetails;

        private ILogger logger;
        private readonly IConfiguration configuration;

        public RoleController(IRoleRepository _roleRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppUserRole> _cacheManager, ICacheManager<AppUserRoleDetail> _cacheManagerDetails , ILogger<RoleController> _logger)
        {
            roleRepo = _roleRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            cacheManagerDetails = _cacheManagerDetails;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllRoles")]
        [Authorize]
        public async Task<IActionResult> GetAllRoles()
        {

            var cacheKey = "GetAllRoles_" + Request.Headers["CustomerGuidKey"];
            List<AppUserRole> roles = new List<AppUserRole>();

            var encodedRoles = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedRoles == null)
                {
                    roles = await roleRepo.LoadAppUserRole();
                    if (roles == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Roles Starts Caching");
                roles = await cacheManager.ProcessCache(roles, cacheKey, encodedRoles, configuration, distributedCache);

                return Ok(roles);
            }
            catch (Exception excp)
            {
                logger.LogError("Error while loading all roles " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }


        [HttpPost]
        [Route("AddRole")]
        [Authorize]
        public async Task<IActionResult> AddRole([FromBody]AppUserRole model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Role in Repository");
                    
                    var addedRole = await roleRepo.AddUserRole(model);
                    if (addedRole != null)
                    {
                        return Ok(addedRole);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error Adding Role in Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }

        [HttpPost]
        [Route("AddRoleDetails")]
        [Authorize]
        public async Task<IActionResult> AddRoleDetails([FromBody]AppUserRoleDetail model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Role Details in Repository");

                    var addedRoleDetails = await roleRepo.AddUserRoleDetails(model);
                    if (addedRoleDetails != null)
                    {
                        return Ok(addedRoleDetails);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error Adding Role Details in Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetRoleInfo/{roleId}")]
        public async Task<IActionResult> LoadRoleTemplateInfoDetails(Guid? roleId)
        {

            if (roleId == null)
            {
                logger.LogInformation("role Id is Null");
                return BadRequest();
            }

            var cacheKey = "GetAllRolesDetails_" + Request.Headers["CustomerGuidKey"];
            List<AppUserRoleDetail> roles = new List<AppUserRoleDetail>();

            try
            {
                logger.LogInformation("Load Role information From Cache");

                var encodedRoleDetails = await distributedCache.GetAsync(cacheKey);

              
                if (encodedRoleDetails == null)
                {
                    logger.LogInformation("Load Role information From Repository");

                    roles = await roleRepo.LoadUserRoleDetail(roleId);
                   
                    if (roles == null || roles.Count == 0)
                    {
                        return NotFound();
                    }
                    else
                    {
                        logger.LogInformation("Roles Starts Caching");
                         roles = await cacheManagerDetails.ProcessCache(roles, cacheKey, encodedRoleDetails, configuration, distributedCache);

                    }

                   
                }
                return Ok(roles);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in Loading Role Details " + excp.Message);
                return BadRequest(excp);
            }
        }





    }
}