using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class UserAuthorization : IUserAuthorization
    {

        private blueKangrooContext db;
        public UserAuthorization(blueKangrooContext _db)
        {
            db = _db;
        }
       public async Task<bool> IsUserAuthorized(Guid customerGuid)
       {
            bool _IsUserExist = false;

            try
            {
                if (db != null)
                {

                    var user = await db.AppUser.FirstOrDefaultAsync<AppUser>(p => p.AppUserId == customerGuid );
                    if(user != null)
                    {
                        _IsUserExist = true;

                    }

                }
            }
            catch (Exception excp)
            {
                // Controller should catch exception and return as BadRequest
                throw excp;
            }

            return _IsUserExist;


        }
    }
}
