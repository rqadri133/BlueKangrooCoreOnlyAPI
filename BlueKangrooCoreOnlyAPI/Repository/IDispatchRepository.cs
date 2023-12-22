using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BlueKangrooCoreOnlyAPI.Models;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IDispatchRepository
    {
        Task<AppDispatch> CreateDispatchActivity(DispatchDetails details);
        Task<List<AppDispatchAssigned>> LoadAllDispatcherDetailsBySenderID(Guid SenderID);
        Task<AppDispatch> AddDispatchPrimaryData(AppDispatch model);
        Task<int> CancelDispatchOrder(AppSender senderInformation);
        Task<AppDispatch> GetDispatchInfoByRecipientId(Guid? recipient);
        Task<List<AppDispatch>> LoadDispatchLocations(Guid SenderID);
        
    }
}