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
    [Route("api/[controller]")]
    [ApiController]
    public class AppGroundActivityController : ControllerBase
    {
            IGroundLogistics groundLogistics;
            public AppGroundActivityController(IGroundLogistics _groundLogistics)
            {
                groundLogistics = _groundLogistics;
            }

            [HttpGet]
            [Route("GetAllGroundActivities")]
            [Authorize]
            public async Task<IActionResult> GetAllGroundActivities()
            {
                  List<AppGroundActivity> lstGroundActivities = null;
                    try
                    {
                        lstGroundActivities= await groundLogistics.GetGroundActivities();

                    }
                    catch(Exception excp)
                    {
                        return BadRequest(excp.StackTrace);

                    }

              return Ok(lstGroundActivities);


            }



            [HttpPost]
            [Route("AddGroundActivity")]
            [Authorize]
            public async Task<IActionResult> AddGroundActivity([FromBody]AppGroundActivity model)
            {

                if (ModelState.IsValid)
                {
                    try
                    {
                        var groundActivityNew = await groundLogistics.AddGroundActity(model);
                        if (groundActivityNew != null)
                        {
                            return Ok(groundActivityNew);
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



            [HttpGet]
            [Route("GetGroundActivity/{groundActivityId}")]
            public async Task<IActionResult> GetGroundActivity(Guid groundActivityId)
            {
                if (groundActivityId == null)
                {
                    return BadRequest();
                }

                try
                {
                    var selectedLogistics = await groundLogistics.GetGroundActivity(groundActivityId);

                    if (selectedLogistics == null)
                    {
                        return NotFound();
                    }

                    return Ok(selectedLogistics);
                }
                catch (Exception excp)
                {
                    return BadRequest(excp);
                }
            }

            [HttpDelete]
            [Route("DeleteGroundActivity")]
            public async Task<IActionResult> DeleteGroundActivity(Guid groundActivityId)
            {
                int result = 0;

                if (groundActivityId == null)
                {
                    return BadRequest();
                }

                try
                {
                    result = await groundLogistics.DeleteAppGroundActivity(groundActivityId);
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
            [Route("UpdateGroundActivity")]
            public async Task<IActionResult> UpdateGroundActivity([FromBody]AppGroundActivity grActivity)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        await groundLogistics.UpdateGroundActivity(grActivity);

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
