using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IProductRepository
    {
        Task<AppProduct> AddProduct(AppProduct product);
        Task<List<AppProduct>> LoadAllProducts();
        Task<int> DeleteProduct(Guid? productId);
        Task<AppProduct> GetProduct(Guid? productId);
        Task<AppProduct> UpdateProduct(AppProduct product);
        Task UploadProductLogo(Guid productid, string blobName, FileStream fileInfo, IConfiguration config, ILogger logger);

    }
}


