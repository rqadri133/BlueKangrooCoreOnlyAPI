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

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class TempUIController : ControllerBase
    {
        ITemplateUIRepository TempUIRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppUitemplate> cacheManager;
        private ILogger logger;
        private readonly IConfiguration configuration;

        public TempUIController(ITemplateUIRepository _tempUIRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppUitemplate> _cacheManager, ILogger<TempUIController> _logger)
        {
            TempUIRepo = _tempUIRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllTempUIs")]
        [Authorize]
        public async Task<IActionResult> GetAllTempUI()
        {

            var cacheKey = "GetAllTempUIs_" + Request.Headers["CustomerGuidKey"];
            List<AppUitemplate> TempUIs = new List<AppUitemplate>();

            var encodedTempUIs = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedTempUIs == null)
                {
                    TempUIs = await TempUIRepo.LoadAllUITemplates();
                    if (TempUIs == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("TempUI Starts Caching");
                TempUIs = await cacheManager.ProcessCache(TempUIs, cacheKey, encodedTempUIs, configuration, distributedCache);

                return Ok(TempUIs);
            }
            catch (Exception excp)
            {
                logger.LogError("Error while loading all template ui description " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddTemplateUI")]
        [Authorize]
        public async Task<IActionResult> AddTemplateUI([FromBody]AppUitemplate model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Template in Repository");
                    var addedTempUI = await TempUIRepo.AddTemplateUIInfo(model);
                    if (addedTempUI != null)
                    {
                        return Ok(addedTempUI);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error Adding Template in Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetTempUIInfo/{TempUIId}")]
        public async Task<IActionResult> GetTempUIInfo(Guid? TempUIId)
        {
            if (TempUIId == null)
            {
                logger.LogInformation("TempUI is Null");
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Load TempUI information");
                var selectedTempUI = await TempUIRepo.GetTemplateInfo(TempUIId);

                if (selectedTempUI == null)
                {
                    return NotFound();
                }

                return Ok(selectedTempUI);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in TempUI " + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteTempUI")]
        public async Task<IActionResult> DeleteTempUI(Guid TempUIId)
        {
            int result = 0;

            if (TempUIId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await TempUIRepo.DeleteTemplateUIInfo(TempUIId);
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
        [Route("UpdateTempUI")]
        public async Task<IActionResult> UpdateTempUI([FromBody]AppUitemplate TempUI)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await TempUIRepo.UpdateTemplateInfo(TempUI);

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