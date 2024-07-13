using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private blueKangrooContext db;
        public CategoryRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        public async Task<AppCategory> AddCategory(AppCategory category)
        {
            if (db != null)
            {
                category.AppCategoryId = Guid.NewGuid();
                category.CreatedDate = DateTime.Now;
                await db.AppCategories.AddAsync(category);
                await db.SaveChangesAsync();

                return category;
            }

            return category;


        }
        public async Task<List<AppCategory>> LoadAllCategories()
        {
            if (db != null)
            {

                var categories = await db.AppCategories.ToListAsync<AppCategory>();
                return categories;

            }

            return null;


        }
        public async Task<int> DeleteCategoryInfo(Guid? categoryId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppCategories.FirstOrDefaultAsync(p => p.AppCategoryId == categoryId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppCategories.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppCategory> GetCategoryInfo(Guid? categoryInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selCategory = await db.AppCategories.FirstOrDefaultAsync<AppCategory>(p => p.AppCategoryId == categoryInfo);
                return selCategory;

            }

            return null;
        }

        public async Task<AppCategory> UpdateCategory(AppCategory category)
        {
            if (db != null)
            {
                //Delete that post
                db.AppCategories.Update(category);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return category;

        }
    
   }
}
