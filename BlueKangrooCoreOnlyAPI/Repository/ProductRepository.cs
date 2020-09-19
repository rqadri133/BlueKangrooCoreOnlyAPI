﻿using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Utilities;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        // Task<AppProduct> AddProduct(AppProduct product);
        //   Task<List<AppProduct>> LoadAllProducts();
        //   Task<int> DeleteProduct(Guid? productId);
        //  Task<AppProduct> GetProduct(Guid? productId);
        //   Task<AppProduct> UpdateProduct(AppProduct product);


        private blueKangrooContext db;
        public ProductRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        public async Task<AppProduct> AddProduct(AppProduct product)
        {
            if (db != null)
            {
                product.AppProductId = Guid.NewGuid();
                product.CreatedDate = DateTime.Now;
                await db.AppProduct.AddAsync(product);
                await db.SaveChangesAsync();

                return product;
            }

            return product;


        }

        public async Task<List<AppProduct>> LoadAllProducts()
        {
            if (db != null)
            {

                var products = await db.AppProduct.ToListAsync<AppProduct>();
                return products;

            }

            return null;



        }
        
        public async Task<int> DeleteProduct(Guid? productId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var prdDel = await db.AppProduct.FirstOrDefaultAsync(p => p.AppProductId == productId);

                if (prdDel != null)
                {
                    //Delete that post
                    db.AppProduct.Remove( prdDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;



        }

        public async Task<AppProduct> GetProduct(Guid? productId)
        {

            if (db != null)
            {
                // One Groud Logistics per zip code
                var selProduct = await db.AppProduct.FirstOrDefaultAsync<AppProduct>(p => p.AppProductId == productId);
                return selProduct;

            }


            return null;

        }


        public async Task<AppProduct> UpdateProduct(AppProduct product)
        {

            if (db != null)
            {
                //Delete that post
                db.AppProduct.Update(product);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return product ;

        }

        // Upload is not Async
        public  Task  UploadProductLogo(Guid productId, string blobName, FileStream fileInfo, IConfiguration config, ILogger logger)
        {
           return  ProxyStorage.UploadToBlob(productId, blobName, fileInfo, config, logger);


        }



    }
}
