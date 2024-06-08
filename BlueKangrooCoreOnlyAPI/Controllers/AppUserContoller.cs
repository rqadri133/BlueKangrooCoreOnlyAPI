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

namespace BlueKangrooCoreOnlyAPI.Controllers
{

   /// <summary>
   /// this will provide crud operations for AppBuyer 
   /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]  
    [AutoValidateAntiforgeryToken]    
    public class AppUserController : ControllerBase
    {
        IBlueKangrooRepository blueRepository ;
        config.IConfiguration configuration;
        ILogger logger;

        public AppUserController(IBlueKangrooRepository _blueRepository , config.IConfiguration _configurtaion , ILogger<AppUserController> _logger)
        {
            blueRepository = _blueRepository;
            configuration = _configurtaion;
            logger = _logger;
        }

        

        [HttpPost]
        [Route("LoginUser")]
        [Authorize]
        public async Task<IActionResult> LoginUser([FromBody]AppUser model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    logger.LogInformation("Model State is Valid access data from repository");
                    var _token = await blueRepository.LoginUser(model);
                    logger.LogInformation("Returning Token Data " + _token.customerTokenId);
                    return Ok(_token);
                }
                else
                {
                    logger.LogError("Model State is Invalid returning bad request");

                    return BadRequest();
                }
            }
            catch(Exception excp)
            {
                return BadRequest(excp.Message);
            }
        }
        

          [HttpGet]
          [Route("GetAllUsers")]
         [Authorize]
         public async Task<IActionResult> GetAllUser()
        {

            var users = await blueRepository.GetAllUsers();
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
                        return Ok(user);
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


