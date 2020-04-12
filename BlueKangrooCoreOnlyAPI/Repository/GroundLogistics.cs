using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class GroundLogistics : IGroundLogistics
    {

        private blueKangrooContext db;
        public GroundLogistics(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppGroundLogistics> AddGroundLogistics(AppGroundLogistics groundLogistics)
        {
            if (db != null)
            {
                groundLogistics.AppGroundLogisticId = Guid.NewGuid();
                groundLogistics.CreatedDate = DateTime.Now;
                
                await db.AppGroundLogistics.AddAsync(groundLogistics);
                await db.SaveChangesAsync();

                return groundLogistics;
            }

            return groundLogistics;

        }
        public async Task<int> DeleteGroundLogistics(Guid? groundLogisticsId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var grlDel = await db.AppGroundLogistics.FirstOrDefaultAsync(p => p.AppGroundLogisticId == groundLogisticsId);

                if (grlDel != null)
                {
                    //Delete that post
                    db.AppGroundLogistics.Remove(grlDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;



        }
        public async Task<AppGroundLogistics> UpdateGroundLogistics(AppGroundLogistics groundLogistics)
        {
            if (db != null)
            {
                //Delete that post
                db.AppGroundLogistics.Update(groundLogistics);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return groundLogistics;
        }

        public async Task<List<AppGroundLogistics>> GetAllGroundLogistics()
        {
            if (db != null)
            {

                var groundLogistics = await db.AppGroundLogistics.ToListAsync<AppGroundLogistics>();
                return groundLogistics;

            }

            return null;


        }
        public async Task<List<AppGroundActivity>> GetGroundActivities()
        {
            if(db != null)
            {
                var groundActivities = await db.AppGroundActivity.ToListAsync<AppGroundActivity>();
                return groundActivities;


            }

            return null;


        }
        public async Task<AppGroundLogistics> GetGroundLogisticsByZipCode(string zipCode)
        {
            try
            {
                if (db != null)
                {
                    // One Groud Logistics per zip code
                    var groundLogistics = await db.AppGroundLogistics.FirstOrDefaultAsync<AppGroundLogistics>(p => p.AppGroundSourceZipCode == zipCode);
                    return groundLogistics;

                }
            }
            catch (Exception excp)
            {
                // Controller should catch exception and return as BadRequest
                throw excp;
            }

            return null;

        }

        public async Task<AppGroundActivity> AddGroundActity(AppGroundActivity groundActivity)
        {
            if (db != null)
            {
                groundActivity.AppGroundActivityId = Guid.NewGuid();
                groundActivity.CreatedDate = DateTime.Now;
                await db.AppGroundActivity.AddAsync(groundActivity);
                await db.SaveChangesAsync();

                return groundActivity;
            }

            return groundActivity;


        }

        public async Task<List<AppGroundActivity>> LoadAllGroundActivities()
        {
            if (db != null)
            {

                var groundActivities = await db.AppGroundActivity.ToListAsync<AppGroundActivity>();
                return groundActivities;

            }

            return null;



        }
        public async Task<int> DeleteAppGroundActivity(Guid? groundActivity)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var grlDel = await db.AppGroundActivity.FirstOrDefaultAsync(p => p.AppGroundActivityId == groundActivity);

                if (grlDel != null)
                {
                    //Delete that post
                    db.AppGroundActivity.Remove(grlDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;



        }

        public async Task<int> DeleteAppGroundLogistics(Guid? groundLogisticsId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var grlDel = await db.AppGroundLogistics.FirstOrDefaultAsync(p => p.AppGroundLogisticId == groundLogisticsId);

                if (grlDel != null)
                {
                    //Delete that post
                    db.AppGroundLogistics.Remove(grlDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;



        }

        public async Task<AppGroundActivity> GetGroundActivity(Guid? groundActivityId)
        {
           
                if (db != null)
                {
                    // One Groud Logistics per zip code
                    var groundLogistics = await db.AppGroundActivity.FirstOrDefaultAsync<AppGroundActivity>(p => p.AppGroundActivityId == groundActivityId);
                    return groundLogistics;

                }
            
            
            return null;

        }


        public async Task<AppGroundActivity> UpdateGroundActivity(AppGroundActivity activity)
        {

            if (db != null)
            {
                //Delete that post
                db.AppGroundActivity.Update(activity);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return activity;

        }
    }
}
