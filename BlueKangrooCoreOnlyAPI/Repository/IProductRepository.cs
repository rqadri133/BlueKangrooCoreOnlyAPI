using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    interface IProductRepository
    {
        Task<AppProduct> AddProduct(AppProduct product);
        Task<List<AppProduct>> LoadAllProducts();
        Task<int> DeleteProduct(Guid? productId);
        Task<AppProduct> GetProduct(Guid? productId);
        Task<AppProduct> UpdateProduct(AppProduct product);
    }
}


