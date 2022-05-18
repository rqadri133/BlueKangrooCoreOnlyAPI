using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface ISupplyRepository
    {
        Task<AppSupply> AddSupplyInfo(AppSupply supply);
        Task<List<AppSupply>> LoadAllSupplies();
        Task<int> DeleteSupplyInfo(Guid? supplyId);
        Task<AppSupply> GetSupplyInfo(Guid? supplyId);
        Task<AppSupply> UpdateSupply(AppSupply supply);

    }
}
