using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public  interface ICategoryRepository
    {
        Task<AppCategory> AddCategory(AppCategory category);
        Task<List<AppCategory>> LoadAllCategories();
        Task<int> DeleteCategoryInfo(Guid? categoryId);
        Task<AppCategory> GetCategoryInfo(Guid? categoryInfo);
        Task<AppCategory> UpdateCategory(AppCategory category);
    }
}
