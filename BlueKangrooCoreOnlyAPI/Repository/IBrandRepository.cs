using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    

    public interface IBrandRepository
    {
        Task<AppBrand> AddBrand(AppBrand brand);
        Task<List<AppBrand>> LoadAllBrands();
        Task<int> DeleteBrandInfo(Guid? BrandId);
        Task<AppBrand> GetBrandInfo(Guid? brandInfo);
        Task<AppBrand> UpdateBrand(AppBrand brand);
        Task UploadBrandLogoo(Guid brandId, string blobName , FileStream fileInfo, IConfiguration config, ILogger logger);
    }
}
