using BlueKangrooCoreOnlyAPI.Models;
using System.Threading.Tasks;
using System;

namespace BlueKangrooCoreOnlyAPI.Repositories {
    public interface IServiceBus<T>  where T  : AppDispatchAssigned {
         Task SendMessageAsync(AppDispatchAssigned assignedDetails);
    }
}