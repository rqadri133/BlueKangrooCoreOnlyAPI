using BlueKangrooCoreOnlyAPI.Enum;
using BlueKangrooCoreOnlyAPI.Headers;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{


    public class BlueKangrooRepository : IBlueKangrooRepository
    {
        private blueKangrooContext db;
        public  BlueKangrooRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppBuyer> AddBuyer(AppBuyer buyer)
        {

            if (db != null)
            {
                await db.AppBuyers.AddAsync(buyer);
                await db.SaveChangesAsync();

                return buyer;
            }

            return buyer;
        }

        public async Task<AppSeller> AddSeller(AppSeller seller)
        {

            if (db != null)
            {
                await db.AppSellers.AddAsync(seller);
                await db.SaveChangesAsync();

                return seller;
            }

            return seller;
        }
        public async Task<int> DeleteBuyer(AppBuyer buyer)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var buyerDel = await db.AppBuyers.FirstOrDefaultAsync(p=>p.AppBuyerId == buyer.AppBuyerId);

                if (buyerDel != null)
                {
                    //Delete that post
                    db.AppBuyers.Remove(buyerDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result; 

        }

       public async Task<List<AppUser>> GetAllUsers()
       {
          
           try 
           {
             if(db != null)
              {

                var  users = await db.AppUsers.ToListAsync<AppUser>();
                return users;

             }

           

           }
           catch(Exception excp)
           {

               throw excp;

           } 
            return null;


       }

       public async Task<int> DeleteSeller(AppSeller seller)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var sellerDel = await db.AppSellers.FirstOrDefaultAsync(p => p.AppSellerId == seller.AppSellerId);

                if (sellerDel != null)
                {
                    //Delete that post
                    db.AppSellers.Remove(sellerDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;

        }
         #region "Login information"
         // not tested on postman
         public async Task<CustomerToken> LoginUser(AppUser user)
         {
            // test for injections 
            // Don't return any user id never 
            CustomerToken customerToken;

             try
             {
                  if (db != null)
                  {
                      

                           //Find the post for specific post id
                           // user name entry found
                       var userinfo = await db.AppUsers.FirstOrDefaultAsync(p => p.AppUserName ==   user.AppUserName);
                    // userinfo;
                     
                    
                       if(userinfo != null)
                       { 
                            // password validated
                            var _hashedPwd = userinfo.AppUserPwd;  
                            // password is hashed and requires to be validate by security layer   
                            bool _findMatch   = Security.SecurityLogin.ValidatePassword(user.AppUserPwd , _hashedPwd);
                            // add token information if not exists
                            // token information found and not expired
                            if(!_findMatch)
                            {
                            // dont proceed 
                               var appError = await db.AppErrors.FindAsync((int)BlueKangarooErrorCode.USER_ID_PASSWORD_NOT_CORRECT);
                               throw new Exception(appError.AppErrorDescription);
                            } 

                            var tokenInformation    = await db.AppTokens.FirstOrDefaultAsync(token => token.AppTokenUserId == userinfo.AppUserId);    
                            if(tokenInformation != null)
                            {
                                 if(tokenInformation.TokenExpiredDate > DateTime.Now)
                                 {
                                     customerToken = new CustomerToken() { customerTokenId = tokenInformation.AppTokenId.ToString() };
                                     return customerToken;
                                 }     
                            }
                            else 
                            {
                                // add the toke information first time login 
                                // the method is accessible earlier only with bearer token 
                                 // this is add on token to return to client 
                                 Guid _tokenId = Guid.NewGuid();
                                 var _newTokenInfo  = await db.AppTokens.AddAsync(new AppToken() {  
                                                              AppTokenId = _tokenId , 
                                                              AppTokenUserId = userinfo.AppUserId , 
                                                              TokenExpiredDate = DateTime.Now.AddDays(30) ,
                                                              CreatedDate = DateTime.Now ,
                                                              // for a while just inser new id 
                                                              // later add Role through dependency injection
                                                              CreatedBy = Guid.NewGuid() ,
                                                              AppClientName = Security.SecurityLogin.CreateHash(_tokenId.ToString()),
                                                              AppNameDesc = userinfo.AppUserId.ToString() + "-" + userinfo.CreatedDate.ToString() ,
                                                              IsActive = true ,
                                                              AppUserPwd =  userinfo.AppUserPwd 
                                                            
                                                              });

                                            await  db.SaveChangesAsync();
                                           
                                           customerToken = new CustomerToken() { customerTokenId = _newTokenInfo.Entity.AppTokenId.ToString() };          
                                           return customerToken;
                            



                            }   
                       }     
                        else
                        {
                                var appError = await db.AppErrors.FindAsync((int)BlueKangarooErrorCode.USER_ID_PASSWORD_NOT_CORRECT);
                                throw new Exception(appError.AppErrorDescription);

                        }
                        
                         

                    }

                  

             }
             catch(Exception excp)
             {

                 throw excp;

             }    

              return null;


         }    




         #endregion
        public async Task<List<AppBuyer>> GetBuyers()
        {
           
            if(db != null)
            {

               var  buyers = await db.AppBuyers.ToListAsync<AppBuyer>();
                return buyers;

            }

            return null;
        }


        public async Task<AppBuyer> GetBuyer(Guid? buyerId)
        {

             try 
             {       
                if (db != null)
                {

                    var buyer = await db.AppBuyers.FirstOrDefaultAsync<AppBuyer>(p=>p.AppBuyerId == buyerId  );
                    return buyer;

                }
             }
             catch(Exception excp)
             {
                // Controller should catch exception and return as BadRequest
                 throw excp;    
             }

            return null;
        }

        public async Task<AppSeller> GetSeller(Guid? sellerId)
        {
            try 
            { 
                if (db != null)
                {

                    var seller = await db.AppSellers.FirstOrDefaultAsync<AppSeller>(p => p.AppSellerId == sellerId);
                    return seller;

                }
             }
            catch(Exception excp)
            {
               throw excp;
                
            }

            return null;
        }



        public async Task<List<AppSeller>> GetSellers()
        {

             try 
             {
                    if (db != null)
                    {

                        var sellers = await db.AppSellers.ToListAsync<AppSeller>();
                        return sellers;

                    }
             }
             catch(Exception excp)
             {
                 throw excp;
                     
             }  

            return null;
        }

        public async Task<AppBuyer> UpdateBuyer(AppBuyer buyer)
        {
            if (db != null)
            {
                //Delete that post
                db.AppBuyers.Update(buyer);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return buyer;
        }

        public async Task<AppSeller> UpdateSeller(AppSeller seller)
        {

            if (db != null)
            {
                //Delete that post
                db.AppSellers.Update(seller);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

            return seller;
        }


        public async Task<AppUser> AddUser(AppUser user)
        {

            if (db != null)
            {

                var appUserRole = await db.AppUserRoles.FindAsync(user.AppRoleId);
                if (appUserRole != null)
                {

                    user.AppUserId = Guid.NewGuid();
                    user.AppUserPwd = Security.SecurityLogin.CreateHash(user.AppUserPwd);
                    user.CreatedDate = DateTime.Now;

                    await db.AppUsers.AddAsync(user);
                    await db.SaveChangesAsync();

                    return user;
                }
                else
                {
                      var userError = await db.AppErrors.FindAsync((int)BlueKangarooErrorCode.USER_ROLE_NOT_DEFINED);
                      throw new Exception(userError.AppErrorDescription);

                }
            }

            return user;

        }



      
        



    }
}

