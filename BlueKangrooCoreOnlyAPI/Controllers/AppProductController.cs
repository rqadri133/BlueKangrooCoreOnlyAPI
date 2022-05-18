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
    public class AppProductController : ControllerBase
    {
        IProductRepository productRepo;
        IDistributedCache distributedCache;
        ICacheManager<AppProduct> cacheManager;
        private readonly IConfiguration configuration;
        ILogger logger;

        public AppProductController(IProductRepository _productRepository, IConfiguration _configurtaion, IDistributedCache _distributedCache, ICacheManager<AppProduct> _cacheManager  , ILogger<AppProductController>  _logger )
        {
            productRepo = _productRepository;
            configuration = _configurtaion;
            distributedCache = _distributedCache;
            cacheManager = _cacheManager;
            logger = _logger;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {

            var cacheKey = "GetAllProducts_" + Request.Headers["CustomerGuidKey"];
            List<AppProduct> products = new List<AppProduct>();
            logger.LogInformation("Fething from Cache if products exist in cache");
            var encodedProducts = await distributedCache.GetAsync(cacheKey);


            try
            {
                if (encodedProducts == null)
                {
                    logger.LogInformation("Fetching from Repository no data found in cache as if no products exist in cache");

                    products = await productRepo.LoadAllProducts();
                    if (products == null)
                    {
                        return NotFound();
                    }
                }
                logger.LogInformation("Adding data in redis cache as if  products found in repository");
                products = await cacheManager.ProcessCache(products, cacheKey, encodedProducts, configuration, distributedCache);

                return Ok(products);
            }
            catch (Exception excp)
            {
                logger.LogError("Errors loading products " + excp.Message );
                // client call must know stack exception
                return BadRequest(excp);
            }


        }



        [HttpPost]
        [Route("AddProduct")]
        [Authorize]
        public async Task<IActionResult> AddProduct([FromBody]AppProduct model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var addedproduct = await productRepo.AddProduct(model);
                    if (addedproduct != null)
                    {
                        return Ok(addedproduct);
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
        [Route("GetProduct/{productId}")]
        public async Task<IActionResult> GetProduct(Guid? productId)
        {
            if (productId == null)
            {
                return BadRequest();
            }

            try
            {
                var selectedProduct = await productRepo.GetProduct(productId);

                if (selectedProduct == null)
                {
                    return NotFound();
                }

                return Ok(selectedProduct);
            }
            catch (Exception excp)
            {
                return BadRequest(excp);
            }
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            int result = 0;

            if (productId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await productRepo.DeleteProduct(productId);
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
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody]AppProduct product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await productRepo.UpdateProduct(product);

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



