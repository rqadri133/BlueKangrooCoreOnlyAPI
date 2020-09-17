using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class ActivityRepository : IActivityRepository
    {

        private blueKangrooContext db;
        public ActivityRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppActivity> AddActivity(AppActivity activity)
        {
            if (db != null)
            {
                activity.AppActivityId = Guid.NewGuid();
                activity.CreatedDate = DateTime.Now;
                await db.AppActivity.AddAsync(activity);
                await db.SaveChangesAsync();

                return activity;
            }

            return activity;


        }
        public async Task<List<AppActivity>> LoadAllActivities()
        {
            if (db != null)
            {

                var activities = await db.AppActivity.ToListAsync<AppActivity>();
                return activities;

            }

            return null;


        }
        public async Task<int> DeleteActivityInfo(Guid? AcitivityId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppActivity.FirstOrDefaultAsync(p => p.AppActivityId == AcitivityId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppActivity.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppActivity> GetActivityInfo(Guid? activityInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selActivity = await db.AppActivity.FirstOrDefaultAsync<AppActivity>(p => p.AppActivityId == activityInfo);
                return selActivity;

            }

            return null;
        }

        public async Task<AppActivity> UpdateActivity(AppActivity activity)
        {
            if (db != null)
            {
                //Delete that post
                db.AppActivity.Update(activity);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return activity;

        }
    }
}
