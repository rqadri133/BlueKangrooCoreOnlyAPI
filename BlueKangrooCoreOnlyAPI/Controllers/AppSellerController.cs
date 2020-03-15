 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlueKangrooCoreOnlyAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class AppSellerController : Controller
    {
        IBlueKangrooRepository blueRepository;
        AppSellerController(IBlueKangrooRepository _blueRepository)
        {
            blueRepository = _blueRepository;
        }


        [HttpGet]
        [Route("GetSellers")]
        [Authorize]
        public async Task<IActionResult> GetSellers()
        {
            try
            {
                var sellers = await blueRepository.GetSellers();
                if (sellers == null)
                {
                    return NotFound();
                }

                return Ok(sellers);
            }
            catch (Exception excp)
            {
                // client call must know stack exception
                return BadRequest(excp);
            }

        }


        [HttpGet]
        [Route("GetSeller")]
        [Authorize]
        public async Task<IActionResult> GetSeller(Guid? sellerId)
        {
            if (sellerId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedSeller = await blueRepository.GetSeller(sellerId);

                if (selectedSeller == null)
                {
                    return NotFound();
                }

                return Ok(selectedSeller);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpPost]
        [Route("AddSeller")]
        [Authorize]
        public async Task<IActionResult> AddSeller([FromBody]AppSeller model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AppSellerId = Guid.NewGuid();
                    var appSeller = await blueRepository.AddSeller(model);
                    if (appSeller != null)
                    {
                        return Ok(appSeller);
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
        [Route("DeleteSeller")]
        public async Task<IActionResult> DeleteSeller([FromBody]AppSeller seller)
        {
            int result = 0;

            if (seller == null)
            {
                return BadRequest();
            }

            try
            {
                result = await blueRepository.DeleteSeller(seller);
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
        [Route("UpdateSeller")]
        public async Task<IActionResult> UpdateSeller([FromBody]AppSeller model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await blueRepository.UpdateSeller(model);

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
