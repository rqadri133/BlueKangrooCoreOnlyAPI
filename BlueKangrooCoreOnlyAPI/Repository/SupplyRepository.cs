
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class SupplyRepository : ISupplyRepository
    {

        private blueKangrooContext db;
        public SupplyRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppSupply> AddSupplyInfo(AppSupply supply)
        {
            if (db != null)
            {
                supply.AppSupplyId = Guid.NewGuid();
                supply.CreatedDate = DateTime.Now;
                await db.AppSupply.AddAsync(supply);
                await db.SaveChangesAsync();

                return supply;
            }

            return supply;


        }
        public async Task<List<AppSupply>> LoadAllSupplies()
        {
            if (db != null)
            {

                var supplies = await db.AppSupply.ToListAsync<AppSupply>();
                return supplies;

            }

            return null;


        }
        public async Task<int> DeleteSupplyInfo(Guid? supplyId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppSupply.FirstOrDefaultAsync(p => p.AppSupplyId == supplyId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppSupply.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppSupply> GetSupplyInfo(Guid? supplyInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selSupply = await db.AppSupply.FirstOrDefaultAsync<AppSupply>(p => p.AppSupplyId == supplyInfo);
                return selSupply;

            }

            return null;
        }

        public async Task<AppSupply> UpdateSupply(AppSupply supply)
        {
            if (db != null)
            {
                //Delete that post
                db.AppSupply.Update(supply);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return supply;

        }
    }
}
