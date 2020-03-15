using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IMaterialLogistics
    {
         Task<List<AppGroundLogistics>> GetAllGroundLogistics();
         Task<List<AppGroundActivity>> GetGroundActivities();
         Task<AppGroundLogistics> GetGroundLogisticsByZipCode(string zipCode);
         Task<AppSensitiveMaterial> LoadAllSensitiveMaterial();
         Task<AppSensitiveMaterial> GetAllDamagedFragiles();



      

         
    }
}

