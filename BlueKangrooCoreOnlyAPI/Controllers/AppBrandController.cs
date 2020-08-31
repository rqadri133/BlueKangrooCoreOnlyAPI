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
using Microsoft.AspNetCore.Http;
using Google.Api;
using System.IO;
using NStandard;
using IdentityModel.Client;

namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class BrandController : ControllerBase
    {
        IBrandRepository BrandRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppBrand> cacheManager;
        private ILogger logger;
        private readonly IConfiguration configuration;

        public BrandController(IBrandRepository _BrandRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppBrand> _cacheManager, ILogger<BrandController> _logger)
        {
            BrandRepo = _BrandRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllBrands")]
        [Authorize]
        public async Task<IActionResult> GetAllBrand()
        {

            var cacheKey = "GetAllBrands_" + Request.Headers["CustomerGuidKey"];
            List<AppBrand> Brands = new List<AppBrand>();

            var encodedBrands = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedBrands == null)
                {
                    Brands = await BrandRepo.LoadAllBrands();
                    if (Brands == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Brand Starts Caching");
                Brands = await cacheManager.ProcessCache(Brands, cacheKey, encodedBrands, configuration, distributedCache);

                return Ok(Brands);
            }
            catch (Exception excp)
            {
                logger.LogError("Error while loading all brands " + excp.Message);

                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddBrand")]
        [Authorize]
        public async Task<IActionResult> AddBrand([FromBody]AppBrand model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    logger.LogInformation("Adding Brand in Repository");
                    var addedBrand = await BrandRepo.AddBrand(model);
                    if (addedBrand != null)
                    {
                        return Ok(addedBrand);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception excp)
                {
                    logger.LogError("Error Adding Brand in Repository " + excp.Message);

                    return BadRequest(excp);
                }

            }

            return BadRequest();

        }



        [HttpGet]
        [Route("GetBrandInfo/{BrandId}")]
        public async Task<IActionResult> GetBrandInfo(Guid? BrandId)
        {
            if (BrandId == null)
            {
                logger.LogInformation("Brand is Null");
                return BadRequest();
            }

            try
            {
                logger.LogInformation("Load Brand information");
                var selectedBrand = await BrandRepo.GetBrandInfo(BrandId);

                if (selectedBrand == null)
                {
                    return NotFound();
                }

                return Ok(selectedBrand);
            }
            catch (Exception excp)
            {
                logger.LogError("Error in Brand " + excp.Message);
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteBrand")]
        public async Task<IActionResult> DeleteBrand(Guid BrandId)
        {
            int result = 0;

            if (BrandId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await BrandRepo.DeleteBrandInfo(BrandId);
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
        [Route("UpdateBrand")]
        public async Task<IActionResult> UpdateBrand([FromBody]AppBrand Brand)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await BrandRepo.UpdateBrand(Brand);

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
        [HttpPost]
        [Route("AddBrandLogoInfo")]
        public async Task<IActionResult> AddBrandLogo()
        {
         
            IFormFileCollection _fileCollection =  HttpContext.Request.Form.Files;
            Microsoft.Extensions.Primitives.StringValues vals;
            string brandId = Guid.NewGuid().ToString();
            if(HttpContext.Request.Form.TryGetValue("brandId", out vals))
            {
                brandId = vals[0];


            }
          
            
            string _blobName = String.Empty;
            string _filePath = Path.GetTempPath();
            string _extension = String.Empty; 
            FileStream stream;  

            if(_fileCollection.Count > 0 )
            {
                if(_fileCollection[0].Length > 0 )
                {
                    _blobName = _fileCollection[0].FileName;
                
                    _filePath = _filePath + "//" + _blobName;
                     stream = new FileStream(_filePath, FileMode.Create);
                     await  _fileCollection[0].CopyToAsync(stream);
                    await BrandRepo.UploadBrandLogoo(Guid.Parse(brandId), _blobName, stream, configuration, logger);


                    // The File is ready to be moved 

                }

            }



            return BadRequest();
        }




    }
}