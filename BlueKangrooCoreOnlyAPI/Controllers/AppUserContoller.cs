using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
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
        public AppUserController(IBlueKangrooRepository _blueRepository)
        {
            blueRepository = _blueRepository;
        }
        [HttpPost]
        [Route("LoginUser")]
        [Authorize]
        public async Task<IActionResult> LoginUser([FromBody]AppUser model)
        {

            var _token = await blueRepository.LoginUser(model);
            return Ok(_token);


        }
        

          [HttpPost]
          [Route("GetAllUsers")]
         [Authorize]
         public async Task<IActionResult> GetAllUser([FromBody]AppUser model)
        {

            var users = await blueRepository.GetAllUsers();
            return Ok(users);


        }





    }
}


