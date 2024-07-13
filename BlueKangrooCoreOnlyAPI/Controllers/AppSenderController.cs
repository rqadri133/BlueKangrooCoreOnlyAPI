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
using Google.Rpc;
using System.Net;
using System.Net.Http;



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

       [HttpGet]
        [Route("GetSenderInformation")]
       [Authorize]
        public async Task<IActionResult> GetSenderInformation(string phoneNumber)
        {

            var cacheKey = "GetSenderInformation_" + phoneNumber;
            AppSender senderInfo = new AppSender();

            try
            {
                
                senderInfo = await  senderRepo.GetSenderInformation(phoneNumber);
                if (senderInfo == null)
                {
                        return NotFound();
                }
                
          
                return Ok(senderInfo);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }


        }


        [HttpPost]
        [Route("AddSenderInfo")]
        [Authorize]
        public async Task<IActionResult> AddSender([FromBody]AppSender model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedSender = await senderRepo.AddSenderInformation(model);
                    if (addedSender != null)
                    {
                        return Ok(addedSender);
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



        [HttpPut]
        [Route("UpdateSenderInfo/{SenderId}")]
        public async Task<IActionResult> UpdateSenderInfo(AppSender sender)
        {
            if (sender == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedSender = await senderRepo.UpdateSenderInformation(sender);

                if (selectedSender == null)
                {
                    return NotFound();
                }

                return Ok(selectedSender);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteSupply")]
        public async Task<HttpResponseMessage> DeleteSupply(AppSender sender)
        {
            AppSender senderInfo = new AppSender();

            if (sender == null)
            {
                      var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                      return response;
            }

            try
            {
                senderInfo = await senderRepo.DeleteSenderInformation(sender);
                if (senderInfo == null)
                {
                     var responseFound = new HttpResponseMessage(HttpStatusCode.NotFound);
                      return responseFound;
                }

                 // verify deletion 
                senderInfo = await  senderRepo.GetSenderInformationById(sender.AppSenderId);
                if (senderInfo != null)
                {
                      var responseDir = new HttpResponseMessage(HttpStatusCode.Gone);
                      return responseDir;

                }
                
                var response = new HttpResponseMessage(HttpStatusCode.Gone);
                return response;
 
            }
            catch (Exception excp)
            {

                    var responseDir = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                    return responseDir;
            }
        }


        [HttpPut]
        [Route("UpdateSupply")]
        public async Task<IActionResult> UpdateSupply([FromBody]AppSender sender)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await senderRepo.UpdateSenderInformation(sender);

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