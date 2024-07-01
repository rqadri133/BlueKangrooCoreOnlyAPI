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
using Google.Protobuf;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Text.Json;
using Google.Rpc;
using BlueKangrooCoreOnlyAPI.Repositories;


namespace BlueKangrooCoreOnlyAPI.Repository
{
    public class DispatchRepository : IDispatchRepository
    {

        private blueKangrooContext db;
        private IServiceBus<AppDispatchAssigned> _serviceBus ;
        public DispatchRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        public async Task<AppDispatch> CreateDispatchActivity(DispatchDetails details , IServiceBus<AppDispatchAssigned> serviceBus)
        {
            AppDispatch assigned  = new AppDispatch();
            _serviceBus = serviceBus;
           
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
                // override routing feature from Graph Routes  
                // dispatchList.CurrentRoutes
                // Problem with design here add routing ID in Dispatch details

                 
                foreach(AppDispatchAssigned dispatchAssigned in dispatchList.AllItems)
                {
                    // 
                      // sending to service bus to process 
                      await   serviceBus.SendMessageAsync(dispatchAssigned);


                }
                //var user = await client.GetFromJsonAsync<GitHubUser>(uri, token);
                // Send to Service Bus Saga
                // Console.WriteLine($"Name: {user.Name}\nBio: {user.Bio}\n");
            });
            
              return assigned;

             
        }

        public async Task<AppDispatch> LoadAllDispatcherDetailsBySenderID(Guid SenderID) {
             AppDispatch appDispatch = new AppDispatch();

            if (db != null)
            {
                appDispatch = await db.AppDispatches.FirstOrDefaultAsync<AppDispatch>(p=>p.AppSenderId == SenderID);
                
               

            } 
            return appDispatch;


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
   

       // Assuming this dispacth has ITem Json and json structure needs to be vaildated
        public async Task<AppDispatch> AddDispatchPrimaryData(AppDispatch dispatch)
        {
            // earlier you have to validate the items provided as well 
            
           if (db != null)
            {
                
                 dispatch.AppDispatchId = Guid.NewGuid();
                 dispatch.CreatedDate = DateTime.Now;
                 
                  try 
                  { 

                     JsonDocument.Parse(dispatch.ItemCombinationJson);
                  }
                  catch(Exception excp)
                  {
                      // tell client app not a valid json if not valid
                     throw new JsonException("Unable to parse items json Not a valid Json format " + excp.Message);
                  }

            }

                await db.AppDispatches.AddAsync(dispatch);
                await db.SaveChangesAsync();

                return dispatch;
            }

        public Task<AppDispatch> CreateDispatchActivity(DispatchDetails details)
        {
            throw new NotImplementedException();
        }
    }

    

}
