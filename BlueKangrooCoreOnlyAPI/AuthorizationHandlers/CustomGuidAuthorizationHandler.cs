using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using BlueKangrooCoreOnlyAPI.Repository;

namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
  

    public class CustomGuidAuthorizationHandler : AuthorizationHandler<CustomerGuidHandlerRequirement>
    {
        IUserAuthorization userAuthorization;
        public CustomGuidAuthorizationHandler(IUserAuthorization userAuthorization)
        {
            this.userAuthorization = userAuthorization; 

        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerGuidHandlerRequirement requirement)
        {
           // !Request.Headers.ContainsKey("Authorization")

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.NameIdentifier &&
                                            c.Issuer == "http://contoso.com"))
            {
                //TODO: Use the following if targeting a version of
                //.NET Framework older than 4.6:
                //      return Task.FromResult(0);
                return Task.CompletedTask;
            }

            var guidCustomer =  context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier &&  c.Issuer == "http://contoso.com").Value;

            Task<bool> _IsUserExist   =  this.userAuthorization.IsUserAuthorized(Guid.Parse(guidCustomer));
            Guid exists;

            try
            {
                Guid.TryParse(guidCustomer, out exists);
                if(exists != null && requirement.CustomerGuidKey == exists.ToString()  && _IsUserExist.Result )
                {
                    context.Succeed(requirement);

                }
            }
            catch (Exception excp)
            {


            }
           // as for now leave it later create a downstream service to 

            //TODO: Use the following if targeting a version of
            //.NET Framework older than 4.6:
            //      return Task.FromResult(0);
            return Task.CompletedTask;
        }
    }
}
