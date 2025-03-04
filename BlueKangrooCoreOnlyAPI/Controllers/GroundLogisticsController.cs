﻿using System;
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
    public class GroundLogisticsController : ControllerBase
    {
        IGroundLogistics  groundLogistics;
        public GroundLogisticsController(IGroundLogistics _groundLogistics)
        {
            groundLogistics = _groundLogistics;
        }
        
        [HttpGet]
        [Route("GetAllLogistics")]
        [Authorize]
        public async Task<IActionResult> GetAllGroundLogistics()
        {

            var groundLogisticsAll = await groundLogistics.GetAllGroundLogistics();
            return Ok(groundLogisticsAll);


        }



        [HttpPost]
        [Route("AddGroundLogistics")]
        [Authorize]
        public async Task<IActionResult> AddGroundLogistics([FromBody]AppGroundLogistic model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var groundLogisticsNew = await groundLogistics.AddGroundLogistics(model);
                    if (groundLogisticsNew != null)
                    {
                        return Ok(groundLogisticsNew);
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
        [Route("DeleteGroundLogistics")]
        public async Task<IActionResult> DeleteGroundLogistics(Guid groundLogisticsId)
        {
            int result = 0;

            if (groundLogisticsId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await groundLogistics.DeleteGroundLogistics(groundLogisticsId);
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
        [Route("UpdateGroundLogistics")]
        public async Task<IActionResult> UpdateGroundLogistics([FromBody]AppGroundLogistic grLogistics)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await groundLogistics.UpdateGroundLogistics(grLogistics);

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


