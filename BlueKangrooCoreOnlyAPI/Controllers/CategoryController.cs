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
        private readonly IConfiguration configuration;
        public CategoryController(ICategoryRepository _CategoryRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppCategory> _cacheManager)
        {
            categoryRepo = _CategoryRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
        }

        [HttpGet]
        [Route("GetAllCategorys")]
        [Authorize]
        public async Task<IActionResult> GetAllCategory()
        {

            var cacheKey = "GetAllCategorys_" + Request.Headers["CustomerGuidKey"];
            List<AppCategory> Categorys = new List<AppCategory>();

            var encodedCategorys = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedCategorys == null)
                {
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