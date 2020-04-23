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

namespace BlueKangrooCoreOnlyAPI.Controllers
{

   /// <summary>
   /// this will provide crud operations for AppBuyer 
   /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        IBlueKangrooRepository blueRepository ;
        config.IConfiguration configuration;
        public AppUserController(IBlueKangrooRepository _blueRepository , config.IConfiguration _configurtaion)
        {
            blueRepository = _blueRepository;
            configuration = _configurtaion;
        }

        [HttpPost]
        [Route("LoadBearerToken")]
        public IActionResult LoadBearerToken([FromBody]ClientCredentials model)
        {
            var _token =  BearerToken.GetToken( configuration["BearerUrl"]  , model);
            return Ok(_token);


        }


        [HttpPost]
        [Route("LoginUser")]
        [Authorize]
        public async Task<IActionResult> LoginUser([FromBody]AppUser model)
        {

            var _token = await blueRepository.LoginUser(model);
            return Ok(_token);


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


