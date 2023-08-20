using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class SellerActivityRepository : ISellerActivityRepository 
    {

        private blueKangrooContext db;
        public SellerActivityRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppSellerActivity> AddSellerActivity(AppSellerActivity activity)
        {
            if (db != null)
            {
                activity.AppSellerActivityId = Guid.NewGuid();
                activity.CreatedDate = DateTime.Now;
                await db.AppSellerActivities.AddAsync(activity);
                await db.SaveChangesAsync();

                return activity;
            }

            return activity;


        }
        public async Task<List<AppSellerActivity>> LoadAllSellerActivities()
        {
            if (db != null)
            {

                var activities = await db.AppSellerActivities.ToListAsync<AppSellerActivity>();
                return activities;

            }

            return null;


        }
        public async Task<int> DeleteSellerActivityInfo(Guid? SellerActivityId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppSellerActivities.FirstOrDefaultAsync(p => p.AppSellerActivityId == SellerActivityId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppSellerActivities.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppSellerActivity> GetSellerActivityInfo(Guid? activityInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selActivity = await db.AppSellerActivities.FirstOrDefaultAsync<AppSellerActivity>(p => p.AppSellerActivityId == activityInfo);
                return selActivity;

            }

            return null;
        }

        public async Task<AppSellerActivity> UpdateSellerActivity(AppSellerActivity activity)
        {
            if (db != null)
            {
                //Delete that post
                db.AppSellerActivities.Update(activity);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return activity;

        }
    }
}
