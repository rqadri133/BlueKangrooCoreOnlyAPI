using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
namespace BlueKangrooCoreOnlyAPI.Controllers
{

    /// <summary>
    /// this will provide crud operations for AppBuyer 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CustomGuidAuthorization")]
    public class CategoryController : ControllerBase
    {
        ICategoryRepository categoryRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppCategory> cacheManager;
        ILogger logger;
        private readonly IConfiguration configuration;
        public CategoryController(ICategoryRepository _CategoryRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppCategory> _cacheManager , ILogger _logger)
        {
            categoryRepo = _CategoryRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllCategorys")]
        [Authorize]
        public async Task<IActionResult> GetAllCategory()
        {

            var cacheKey = "GetAllCategorys_" + Request.Headers["CustomerGuidKey"];
            List<AppCategory> Categorys = new List<AppCategory>();
            logger.LogInformation("Fetching all categories in cache");
            var encodedCategorys = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedCategorys == null)
                {
                    logger.LogInformation("Fetching all categories from repository");

                    Categorys = await categoryRepo.LoadAllCategories();
                    if (Categorys == null)
                    {
                        return NotFound();
                    }
                }
                Categorys = await cacheManager.ProcessCache(Categorys, cacheKey, encodedCategorys, configuration, distributedCache);

                return Ok(Categorys);
            }
            catch (Exception excp)
            {
                logger.LogError("Exception in categories " + excp.Message);
                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddCategory")]
        [Authorize]
        public async Task<IActionResult> AddCategory([FromBody]AppCategory model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedCategory = await categoryRepo.AddCategory(model);
                    if (addedCategory != null)
                    {
                        return Ok(addedCategory);
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
        [Route("GetCategoryInfo/{CategoryId}")]
        public async Task<IActionResult> GetCategoryInfo(Guid? CategoryId)
        {
            if (CategoryId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedCategory = await categoryRepo.GetCategoryInfo(CategoryId);

                if (selectedCategory == null)
                {
                    return NotFound();
                }

                return Ok(selectedCategory);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(Guid CategoryId)
        {
            int result = 0;

            if (CategoryId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await categoryRepo.DeleteCategoryInfo(CategoryId);
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
        [Route("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody]AppCategory Category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await categoryRepo.UpdateCategory(Category);

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