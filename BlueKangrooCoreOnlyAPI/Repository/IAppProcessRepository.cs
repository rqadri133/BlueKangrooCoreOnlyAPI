using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    interface IAppProcessRepository
    {
        Task<AppProcess> AddProcess(AppProcess process);
        Task<List<AppProcess>> LoadAllProcesses();
        Task<int> DeleteProcessInfo(Guid? ProcessId);
        Task<AppProcess> GetProcessInfo(Guid? processInfo);
        Task<AppProcess> UpdateProcess(AppProcess process);
    }
}
