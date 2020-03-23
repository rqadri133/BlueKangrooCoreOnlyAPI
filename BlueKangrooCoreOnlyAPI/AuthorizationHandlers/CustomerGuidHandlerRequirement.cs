using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel.Jwk;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
 
    public class CustomerGuidHandlerRequirement : IAuthorizationRequirement
    {


       
        public string Authorization
        {
            get;
            set;

        }

        public string CustomerGuidKey
        {
            get;
            set;

        }


    }
}
