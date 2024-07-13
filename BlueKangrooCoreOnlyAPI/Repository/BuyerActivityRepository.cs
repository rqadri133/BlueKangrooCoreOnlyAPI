using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class BuyerActivityRepository : IBuyerActivityRepository 
    {

        private blueKangrooContext db;
        public BuyerActivityRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppBuyerActivity> AddBuyerActivity(AppBuyerActivity activity)
        {
            if (db != null)
            {
                activity.AppBuyerActivityId = Guid.NewGuid();
                activity.CreatedDate = DateTime.Now;
                await db.AppBuyerActivities.AddAsync(activity);
                await db.SaveChangesAsync();

                return activity;
            }

            return activity;


        }
        public async Task<List<AppBuyerActivity>> LoadAllBuyerActivities()
        {
            if (db != null)
            {

                var activities = await db.AppBuyerActivities.ToListAsync<AppBuyerActivity>();
                return activities;

            }

            return null;


        }
        public async Task<int> DeleteBuyerActivityInfo(Guid? buyerActivityId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppBuyerActivities.FirstOrDefaultAsync(p => p.AppBuyerActivityId == buyerActivityId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppBuyerActivities.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppBuyerActivity> GetBuyerActivityInfo(Guid? activityInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selActivity = await db.AppBuyerActivities.FirstOrDefaultAsync<AppBuyerActivity>(p => p.AppBuyerActivityId == activityInfo);
                return selActivity;

            }

            return null;
        }

        public async Task<AppBuyerActivity> UpdateBuyerActivity(AppBuyerActivity activity)
        {
            if (db != null)
            {
                //Delete that post
                db.AppBuyerActivities.Update(activity);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return activity;

        }
    }
}
