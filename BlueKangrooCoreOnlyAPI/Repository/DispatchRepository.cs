using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Utilities;
using BlueKangrooCoreOnlyAPI.Models;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class DispatchRepository : IDispatchRepository
    {

   // Task<AppDispatch> CreateDispatchActivity(DispatchDetails details);
     //   Task<List<AppDispatch>> LoadAllDispatcherDetails();
       // Task<int> CancelDispatchOrder(AppDispatcher dispatcher);
       // Task<AppDispatch> GetDispatchInfoById(Guid? dispatchID);
       // Task<List<AppDispatch>> LoadDispatchLocations( );
        private blueKangrooContext db;
        public DispatchRepository(blueKangrooContext _db)
        {
            db = _db;
        }
        public async Task<AppDispatch> CreateDispatchActivity(DispatchDetails details)
        {
           throw new NotImplementedException();
        }
        
        public async  Task<List<AppDispatch>> LoadAllDispatcherDetails()
        {

          throw new NotImplementedException();

        }

       public async Task<int> CancelDispatchOrder(AppDispatch dispatcher)
       {

          throw new NotImplementedException();

      }

      public async Task<AppDispatch> GetDispatchInfoById(Guid? dispatchID) 
      {
          throw new NotImplementedException();


      }

     public async  Task<List<AppDispatch>> LoadDispatchLocations( )
     {

         throw new NotImplementedException();

     }






}

}
