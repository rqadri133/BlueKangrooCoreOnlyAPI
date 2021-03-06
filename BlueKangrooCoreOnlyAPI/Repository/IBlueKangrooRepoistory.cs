﻿using BlueKangrooCoreOnlyAPI.Headers;
using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IBlueKangrooRepository
    {
         Task<List<AppBuyer>> GetBuyers();
         Task<CustomerToken> LoginUser(AppUser user);  

         Task<List<AppUser>> GetAllUsers();
         Task<AppUser> AddUser(AppUser user);


        Task<List<AppSeller>> GetSellers();


         Task<AppBuyer> GetBuyer(Guid? buyerId);
         Task<AppSeller> GetSeller(Guid? sellerId);

         Task<AppBuyer> AddBuyer(AppBuyer buyer);

         Task<int> DeleteBuyer(AppBuyer buyer);
         Task<int> DeleteSeller(AppSeller seller);
         Task<AppBuyer> UpdateBuyer(AppBuyer buyer);

         Task<AppSeller> UpdateSeller(AppSeller seller);
         Task<AppSeller> AddSeller(AppSeller seller);

         
    }
}

