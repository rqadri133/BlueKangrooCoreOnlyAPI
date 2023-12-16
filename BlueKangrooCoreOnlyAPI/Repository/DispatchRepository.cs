using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Utilities;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;


namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class DispatchRepository : IDispatchRepository
    {

        private blueKangrooContext db;
        public DispatchRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        public async Task<AppDispatch> CreateDispatchActivity(DispatchDetails details)
        {
            AppDispatch assigned  = new AppDispatch();

           
          // var userType = dbContext.Set().FromSql("dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada");
             ParallelOptions parallelOptions = new()
            {
              MaxDegreeOfParallelism = 3
            };
 
             // Send to each Queue messages 
            await Parallel.ForEachAsync<DispatchItemList>(details.ItemsToDsipatch, async (dispatchList,token) =>
            {
                // Service Bus Security 
                // this entry set of transaction will save routes
                // check route availibility 
                // override routing feature from Grpah Routes  
                // dispatchList.CurrentRoutes
                // Problem with design here add routing ID in Dispatch details
                 
                foreach(AppDispatchAssigned dispatchAssigned in dispatchList.AllItems)
                {
                      


                }
                //var user = await client.GetFromJsonAsync<GitHubUser>(uri, token);
                // Send to Service Bus Saga
                // Console.WriteLine($"Name: {user.Name}\nBio: {user.Bio}\n");
            });
            
              return assigned;

             
        }

        public async Task<List<AppDispatchAssigned>> LoadAllDispatcherDetailsBySenderID(Guid SenderID) {

            List<AppDispatchAssigned> lstDispatchesAssigned = new List<AppDispatchAssigned>(); 
            if (db != null)
            {
                var dispatchedData = await db.AppDispatches.FirstOrDefaultAsync<AppDispatch>(p=>p.AppSenderId == SenderID);
                
                if(dispatchedData != null)
                {
                   var currentID = dispatchedData.AppDispatchId ;
                   // Send Current ID
                   if(currentID != null)
                   {
                       lstDispatchesAssigned = db.AppDispatchAssigneds.ToList().FindAll(p=>p.AppDispatchRefId == currentID);
                   }

                   return lstDispatchesAssigned;



                }

            } 
            return lstDispatchesAssigned;


        }
        public Task<int> CancelDispatchOrder(AppSender senderInformation) {

            throw new NotImplementedException();
        }
        public Task<AppDispatch> GetDispatchInfoByRecipientId(Guid? recipient) {
            throw new NotImplementedException();
        }
        public Task<List<AppDispatch>> LoadDispatchLocations(Guid SenderID) {
                throw new NotImplementedException();
     
            
        }
     


}

}
