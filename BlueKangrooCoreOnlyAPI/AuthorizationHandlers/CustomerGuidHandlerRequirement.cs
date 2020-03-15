using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
 
    public class CustomerGuidHandlerRequirement : IAuthorizationRequirement
    {
        public string customerGuid
        {
            get;
            set;

        }

        public string BearerTokenIfAny
        {
            get;
            set;

        }


    }
}
