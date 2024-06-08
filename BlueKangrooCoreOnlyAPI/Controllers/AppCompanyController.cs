
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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    [AutoValidateAntiforgeryToken]
    
    public class AppCompanyController : ControllerBase
    {
        /// <summary>
        /// this will provide crud operations for AppBuyer 
        /// </summary>
        ICompanyRepository companyRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppCompany> cacheManager;
        private ILogger logger;
        private readonly IConfiguration configuration;
        public AppCompanyController(ICompanyRepository _companyRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppCompany> _cacheManager, ILogger<AppCompanyController> _logger)
        {
            companyRepo = _companyRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllCompanies")]
        [Authorize]
        public async Task<IActionResult> GetAllCompanies()
        {

            var cacheKey = "GetAllCompanies_" + Request.Headers["CustomerGuidKey"];
            List<AppCompany> companies = new List<AppCompany>();

            var encodedCompanies = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedCompanies == null)
                {
                    companies = await companyRepo.LoadAllCompanies();
                    if (companies == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Company Starts Caching");
                companies = await cacheManager.ProcessCache(companies, cacheKey, encodedCompanies, configuration, distributedCache);

                return Ok(companies);
            }
            catch (Exception excp)
            {
                logger.LogError("Error while loading all companies " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddCompany")]
        [Authorize]
        public async Task<IActionResult> AddCompany([FromBody]AppCompany model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Company in Repository");
                    var addedCompany = await companyRepo.AddCompany(model);
                    if (addedCompany != null)
                    {
                        return Ok(addedCompany);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error Adding Company in Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetCompanyInfo/{CompanyId}")]
        public async Task<IActionResult> GetCompanyInfo(Guid? companyId)
        {
            if (companyId == null)
            {
                logger.LogInformation("Company is Null");
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Load Company information");
                var selectedCompany = await companyRepo.GetCompanyInfo(companyId);

                if (selectedCompany == null)
                {
                    return NotFound();
                }

                return Ok(selectedCompany);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in Activity " + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(Guid companyId)
        {
            int result = 0;

            if (companyId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await companyRepo.DeleteCompanyInfo(companyId);
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
        [Route("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany([FromBody]AppCompany company)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await companyRepo.UpdateCompany(company);

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