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

        private blueKangrooContext db;
        public DispatchRepository(blueKangrooContext _db)
        {
            db = _db;
        }

        public Task<AppDispatch> CreateDispatchActivity(DispatchDetails details)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppDispatch>> LoadAllDispatcherDetailsBySenderID(Guid SenderID) {
           throw new NotImplementedException();


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
