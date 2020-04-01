using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using BlueKangrooCoreOnlyAPI.Filters;

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>
   
    [Route("api/[controller]")]
    [ApiController]
   [Authorize (Policy = "CustomGuidAuthorization")]
    public class AppBuyerController : ControllerBase
    {
        IBlueKangrooRepository blueRepository ;
        
        public AppBuyerController(IBlueKangrooRepository _blueRepository)
        {
           blueRepository = _blueRepository;
        }

        [HttpGet]
        [Route("GetAllBuyers")]
        [Authorize]
        
        public async Task<IActionResult> GetAllBuyers()
        {
            try
            {
                var buyers = await blueRepository.GetBuyers();
                if (buyers == null)
                {
                     return NotFound();
       
                }

                return Ok(buyers);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }

        }


        [HttpGet]
        [Route("GetBuyer/{buyerId}")]
        public async Task<IActionResult> GetBuyer(Guid? buyerId)
        {
            if (buyerId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedBuyer = await blueRepository.GetBuyer(buyerId);

                if (selectedBuyer == null)
                {
                    return NotFound();
                }

                return Ok(selectedBuyer);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpPost]
        [Route("AddBuyer")]
        public async Task<IActionResult> AddBuyer([FromBody]AppBuyer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AppBuyerId = Guid.NewGuid();
                    var appBuyer = await blueRepository.AddBuyer(model);
                    if (appBuyer != null)
                    {
                        return Ok(appBuyer);
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

        [HttpDelete]
        [Route("DeleteBuyer")]
        public async Task<IActionResult> DeleteBuyer([FromBody]AppBuyer buyer)
        {
            int result = 0;

            if (buyer == null)
            {
                return BadRequest();
            }

            try
            {
                result = await blueRepository.DeleteBuyer(buyer);
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
        [Route("UpdateBuyer")]
        public async Task<IActionResult> UpdateBuyer([FromBody]AppBuyer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await blueRepository.UpdateBuyer(model);

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


