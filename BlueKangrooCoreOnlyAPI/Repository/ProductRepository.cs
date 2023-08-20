using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                await db.AppProducts.AddAsync(product);
                await db.SaveChangesAsync();

                return product;
            }

            return product;


        }

        public async Task<List<AppProduct>> LoadAllProducts()
        {
            if (db != null)
            {

                var products = await db.AppProducts.ToListAsync<AppProduct>();
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
                var prdDel = await db.AppProducts.FirstOrDefaultAsync(p => p.AppProductId == productId);

                if (prdDel != null)
                {
                    //Delete that post
                    db.AppProducts.Remove( prdDel);

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
                var selProduct = await db.AppProducts.FirstOrDefaultAsync<AppProduct>(p => p.AppProductId == productId);
                return selProduct;

            }


            return null;

        }


        public async Task<AppProduct> UpdateProduct(AppProduct product)
        {

            if (db != null)
            {
                //Delete that post
                db.AppProducts.Update(product);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return product ;

        }
    }
}
