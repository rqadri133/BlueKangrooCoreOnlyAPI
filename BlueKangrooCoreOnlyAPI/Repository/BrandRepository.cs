using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Utilities;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class BrandRepository : IBrandRepository
    {

        private blueKangrooContext db;
        public BrandRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppBrand> AddBrand(AppBrand brand)
        {
            if (db != null)
            {
                brand.AppBrandId = Guid.NewGuid();
                brand.CreatedDate = DateTime.Now;
                await db.AppBrand.AddAsync(brand);
                await db.SaveChangesAsync();

                return brand;
            }

            return brand;


        }
        public async Task<List<AppBrand>> LoadAllBrands()
        {
            if (db != null)
            {

                var brands = await db.AppBrand.ToListAsync<AppBrand>();
                return brands;

            }

            return null;


        }
        public async Task<int> DeleteBrandInfo(Guid? brandId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppBrand.FirstOrDefaultAsync(p => p.AppBrandId == brandId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppBrand.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppBrand> GetBrandInfo(Guid? brandInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selectBrand = await db.AppBrand.FirstOrDefaultAsync<AppBrand>(p => p.AppBrandId == brandInfo);
                return selectBrand;

            }

            return null;
        }

        public async Task<AppBrand> UpdateBrand(AppBrand brand)
        {
            if (db != null)
            {
                //Delete that post
                db.AppBrand.Update(brand);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return brand;

        }

       

        public Task UploadBrandLogoo(Guid brandId, string blobName, FileStream fileInfo, IConfiguration config, ILogger logger)
        {
            IBlueKangrooStorage _storage = null;
            string storagemethod = config["StorageTechnique"];
            string _containerName = config["BlueKangrooContainerName"];
            switch (storagemethod)
            {
                
                case "AzureBlob":
                    _storage = new BlueKangrooBlobStorage();
                    break;
                default:
                    _storage = new BlueKangrooBlobStorage();
                    break;
            }

            return _storage.UploadFile(fileInfo,    brandId + "//" + blobName , config, logger);
        }
    }
}
