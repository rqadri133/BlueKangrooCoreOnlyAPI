using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class DemandRepository : IDemandRepository
    {

        private blueKangrooContext db;
        public DemandRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppDemand> AddProductDemand(AppDemand demand)
        {
            if (db != null)
            {
                demand.AppDemandId = Guid.NewGuid();
                demand.CreatedDate = DateTime.Now;
                await db.AppDemand.AddAsync(demand);
                await db.SaveChangesAsync();

                return demand;
            }

            return demand;


        }
        public async Task<List<AppDemand>> LoadAllDemands()
        {
            if (db != null)
            {

                var demands = await db.AppDemand.ToListAsync<AppDemand>();
                return demands;

            }

            return null;


        }
        public async Task<int> DeleteDemandInfo(Guid? demandId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppDemand.FirstOrDefaultAsync(p => p.AppDemandId == demandId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppDemand.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppDemand> GetDemandInfo(Guid? demandInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selDemand = await db.AppDemand.FirstOrDefaultAsync<AppDemand>(p => p.AppDemandId == demandInfo);
                return selDemand;

            }

            return null;
        }

        public async Task<AppDemand> UpdateDemand(AppDemand demand)
        {
            if (db != null)
            {
                //Delete that post
                db.AppDemand.Update(demand);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return demand;

        }
    }
}
