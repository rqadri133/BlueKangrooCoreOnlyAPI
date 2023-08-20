using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class UserAuthorization : IUserAuthorization
    {

        private blueKangrooContext db;
        private ILogger logger;
        public UserAuthorization(blueKangrooContext _db , ILogger<UserAuthorization> _logger )
        {
            db = _db;
            logger = _logger;
        }
       public async Task<bool> IsUserAuthorized(Guid customerGuid)
       {
            bool _IsUserExist = false;

            try
            {
                if (db != null)
                {
                    logger.LogInformation("Before Making Call to DB Context Blue kangaroo");
                    var user = await db.AppTokens.FirstOrDefaultAsync<AppToken>(p => p.AppTokenId == customerGuid && p.TokenExpiredDate > DateTime.Now );
                   
                    if(user != null)
                    {
                        _IsUserExist = true;

                    }

                }
            }
            catch (Exception excp)
            {
                logger.LogError("Error in connecting DB Context" + excp.Message);
                // Controller should catch exception and return as BadRequest
               
            }

            return _IsUserExist;


        }
    }
}
