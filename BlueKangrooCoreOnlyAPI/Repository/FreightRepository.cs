using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    
        public class FreightRepository : IFreightRepository
        {
            
            private blueKangrooContext db;
            public FreightRepository(blueKangrooContext _db)
            {
                db = _db;
            }

            public async Task<AppFreight> AddFreight(AppFreight freight)
            {
                if (db != null)
                {
                    freight.AppFreightId = Guid.NewGuid();
                    freight.CreatedDate = DateTime.Now;
                    await db.AppFreight.AddAsync(freight);
                    await db.SaveChangesAsync();

                    return freight;
                }

                return freight;


            }

            public async Task<List<AppFreight>> LoadAllFreights()
            {
                if (db != null)
                {

                    var freights = await db.AppFreight.ToListAsync<AppFreight>();
                    return freights;

                }

                return null;



            }

            public async Task<int> DeleteFreightInfo(Guid? freightId)
            {
                int result = 0;

                if (db != null)
                {
                    //Find the post for specific post id
                    var frDel = await db.AppFreight.FirstOrDefaultAsync(p => p.AppFreightId == freightId);

                    if (frDel != null)
                    {
                        //Delete that post
                        db.AppFreight.Remove(frDel);

                        //Commit the transaction
                        result = await db.SaveChangesAsync();
                    }
                    return result;
                }

                return result;



            }

            public async Task<AppFreight> GetFreightInfo(Guid? freightId)
            {

                if (db != null)
                {
                    // One Groud Logistics per zip code
                    var selFreight = await db.AppFreight.FirstOrDefaultAsync<AppFreight>(p => p.AppFreightId == freightId);
                    return selFreight;

                }

                return null;
            }


            public async Task<AppFreight> UpdateFreight(AppFreight freight)
            {

                if (db != null)
                {
                    //Delete that post
                    db.AppFreight.Update(freight);

                    //Commit the transaction
                    await db.SaveChangesAsync();
                }

                return freight;

            }

       
    }

    }

