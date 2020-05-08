﻿using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class AppProcessRepository : IAppProcessRepository 
    {

        private blueKangrooContext db;
        public AppProcessRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppProcess> AddProcess(AppProcess process)
        {
            if (db != null)
            {
                process.AppProcessId = Guid.NewGuid();
                process.CreatedDate = DateTime.Now;
                await db.AppProcess.AddAsync(process);
                await db.SaveChangesAsync();

                return process;
            }

            return process;


        }
        public async Task<List<AppProcess>> LoadAllProcesses()
        {
            if (db != null)
            {

                var processes = await db.AppProcess.ToListAsync<AppProcess>();
                return processes;

            }

            return null;


        }
        public async Task<int> DeleteProcessInfo(Guid? ProcesssId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var acDel = await db.AppProcess.FirstOrDefaultAsync(p => p.AppProcessId ==  ProcesssId);

                if (acDel != null)
                {
                    //Delete that post
                    db.AppProcess.Remove(acDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;


        }

        public async Task<AppProcess> GetProcessInfo(Guid? processInfo)
        {
            if (db != null)
            {
                // One Groud Logistics per zip code
                var selProcess = await db.AppProcess.FirstOrDefaultAsync<AppProcess>(p => p.AppProcessId ==  processInfo);
                return selProcess;

            }

            return null;
        }

        public async Task<AppProcess> UpdateProcess(AppProcess process)
        {
            if (db != null)
            {
                //Delete that post
                db.AppProcess.Update(process);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return process;

        }
    }
}
