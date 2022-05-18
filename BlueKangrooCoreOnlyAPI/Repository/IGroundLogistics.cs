using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IGroundLogistics
    {

         Task<AppGroundLogistics> AddGroundLogistics(AppGroundLogistics groundLogistics);
         Task<int> DeleteGroundLogistics(Guid? groundLogisticsId);
         Task<AppGroundLogistics> UpdateGroundLogistics(AppGroundLogistics groundLogistics);
         Task<List<AppGroundLogistics>> GetAllGroundLogistics();
         Task<List<AppGroundActivity>> GetGroundActivities();
         Task<AppGroundLogistics> GetGroundLogisticsByZipCode(string zipCode);
        
        Task<AppGroundActivity> AddGroundActity(AppGroundActivity groundActivity);
        Task<List<AppGroundActivity>> LoadAllGroundActivities();
        Task<int> DeleteAppGroundActivity(Guid? groundLogistics);
        Task<int> DeleteAppGroundLogistics(Guid? groundLogisticsId);
        Task<AppGroundActivity> GetGroundActivity(Guid? groundActivityId);
        Task<AppGroundActivity> UpdateGroundActivity(AppGroundActivity activity);

    }
}

