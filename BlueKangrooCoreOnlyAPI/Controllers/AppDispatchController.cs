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
using Microsoft.Data.SqlClient;

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


       [HttpGet]
       [Route("dispatchinformation/{senderId}")]
       public async Task<IActionResult> LoadDispatchInformationBySender(Guid senderId)
       {
           // Validate Sender active 
           // Load Dispatch AssignedList
           // Dispatch Rule loadd as well finish this feature tonight 
           AppDispatch dispatchAssigned = new AppDispatch();
          try
          {
               dispatchAssigned   =  await dispatchRepository.LoadAllDispatcherDetailsBySenderID(senderId);
               if(dispatchAssigned == null)
               {
                 return BadRequest("No Data Found");
               }


          }
          catch(SqlException excp)
          {
            return BadRequest(excp);

          }
          catch(Exception excp)
          {

          }
          finally
          {

          }

          return Ok(dispatchAssigned);
 


                 


       }


       [HttpPost]
       [Route("dispatchItems/{senderId}")]
       public async Task<IActionResult> AddDispatchInformationBySender(Guid senderId)
       {
           // Validate Sender active 
           // Load Dispatch AssignedList
           // Dispatch Rule loadd as well finish this feature tonight 
            AppDispatch dispatchAssigned = new AppDispatch();
          try
          {
               dispatchAssigned   =  await dispatchRepository.LoadAllDispatcherDetailsBySenderID(senderId);
               if(dispatchAssigned == null)
               {
                 return BadRequest("No Data Found");
               }


          }
          catch(SqlException excp)
          {
            return BadRequest(excp);

          }
          catch(Exception excp)
          {

          }
          finally
          {

          }

          return Ok(dispatchAssigned);
 


                 


       }

       



      


    }
}