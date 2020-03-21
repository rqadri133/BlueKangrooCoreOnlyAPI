using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Repository
{
    public interface IUserAuthorization
    {
        Task<bool> IsUserAuthorized(Guid CustomerGuid);

    }
}
