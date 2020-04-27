using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace BlueKangrooCoreOnlyAPI.Repository
{
   public interface IDemandRepository
    {
        Task<AppDemand> AddProductDemand(AppDemand demand);
        Task<List<AppDemand>> LoadAllDemands();
        Task<int> DeleteDemandInfo(Guid? demandId);
        Task<AppDemand> GetDemandInfo(Guid? demandId);
        Task<AppDemand> UpdateDemand(AppDemand demand);


    }
}
