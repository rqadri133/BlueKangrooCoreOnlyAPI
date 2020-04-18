using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    /// <summary>
    /// Continue ..
    /// </summary>
    public interface IFreightRepository
    {
        Task<AppFreight> AddFreight(AppFreight freight);
        Task<List<AppFreight>> LoadAllFreights();
        Task<int> DeleteFreightInfo(Guid? freightId);
        Task<AppFreight> GetFreightInfo(Guid? freightId);
        Task<AppFreight> UpdateFreight(AppFreight freight);


    }
}
