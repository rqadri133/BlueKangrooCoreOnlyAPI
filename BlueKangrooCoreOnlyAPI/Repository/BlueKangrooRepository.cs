using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

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
                await db.AppBuyer.AddAsync(buyer);
                await db.SaveChangesAsync();

                return buyer;
            }

            return buyer;
        }

        public async Task<AppSeller> AddSeller(AppSeller seller)
        {

            if (db != null)
            {
                await db.AppSeller.AddAsync(seller);
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
                var buyerDel = await db.AppBuyer.FirstOrDefaultAsync(p=>p.AppBuyerId == buyer.AppBuyerId);

                if (buyerDel != null)
                {
                    //Delete that post
                    db.AppBuyer.Remove(buyerDel);

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

                var  users = await db.AppUser.ToListAsync<AppUser>();
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
                var sellerDel = await db.AppSeller.FirstOrDefaultAsync(p => p.AppSellerId == seller.AppSellerId);

                if (sellerDel != null)
                {
                    //Delete that post
                    db.AppSeller.Remove(sellerDel);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;

        }
         #region "Login information"
         // not tested on postman
         public async Task<string> LoginUser(AppUser user)
         { 
             // test for injections 
            // Don't return any user id never 
             try
             {
                  if (db != null)
                  {
                      

                           //Find the post for specific post id
                           // user name entry found
                       var userinfo = await db.AppUser.FirstOrDefaultAsync(p => p.AppUserName ==   user.AppUserName);
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
                               return null; 
                            } 

                            var tokenInformation    = await db.AppToken.FirstOrDefaultAsync(token => token.AppTokenUserId == userinfo.AppUserId);    
                            if(tokenInformation != null)
                            {
                                 if(tokenInformation.TokenExpiredDate > DateTime.Now)
                                 {
                                      return tokenInformation.AppTokenId.ToString();
                                 }     
                            }
                            else 
                            {
                                // add the toke information first time login 
                                // the method is accessible earlier only with bearer token 
                                 // this is add on token to return to client 
                                 Guid _tokenId = Guid.NewGuid();
                                 var _newTokenInfo  = await db.AppToken.AddAsync(new AppToken() {  
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

                                           return _newTokenInfo.Entity.AppTokenId.ToString();



                            }   
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

               var  buyers = await db.AppBuyer.ToListAsync<AppBuyer>();
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

                    var buyer = await db.AppBuyer.FirstOrDefaultAsync<AppBuyer>(p=>p.AppBuyerId == buyerId  );
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

                    var seller = await db.AppSeller.FirstOrDefaultAsync<AppSeller>(p => p.AppSellerId == sellerId);
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

                        var sellers = await db.AppSeller.ToListAsync<AppSeller>();
                        return sellers;

                    }
             }
             catch(Exception excp)
             {
                 throw excp;
                     
             }  

            return null;
        }

        public async Task UpdateBuyer(AppBuyer buyer)
        {
            if (db != null)
            {
                //Delete that post
                db.AppBuyer.Update(buyer);

                //Commit the transaction
                await db.SaveChangesAsync();
            }

        }

        public async Task UpdateSeller(AppSeller seller)
        {

            if (db != null)
            {
                //Delete that post
                db.AppSeller.Update(seller);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }


        public async Task<AppUser> AddUser(AppUser user)
        {

            if (db != null)
            {
                user.AppUserId = Guid.NewGuid();
                user.AppUserPwd  = Security.SecurityLogin.CreateHash(user.AppUserPwd);
                user.CreatedDate = DateTime.Now;
               
                await db.AppUser.AddAsync(user);
                await db.SaveChangesAsync();

                return user;
            }

            return user;

        }



      
        



    }
}

