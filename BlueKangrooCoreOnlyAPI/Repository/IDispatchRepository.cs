using BlueKangrooCoreOnlyAPI.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IDispatchRepository
    {
        Task<AppDispatch> CreateDispatchActivity(DispatchDetails details);
        Task<List<AppDispatch>> LoadAllDispatcherDetails();
        Task<int> CancelDispatchOrder(AppDispatch dispatcher);
        Task<AppDispatch> GetDispatchInfoById(Guid? dispatchID);
        Task<List<AppDispatch>> LoadDispatchLocations( );
    }
}