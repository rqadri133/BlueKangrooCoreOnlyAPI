using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
  

    public class CustomGuidAuthorizationHandler : AuthorizationHandler<CustomerGuidHandlerRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerGuidHandlerRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.NameIdentifier &&
                                            c.Issuer == "http://contoso.com"))
            {
                //TODO: Use the following if targeting a version of
                //.NET Framework older than 4.6:
                //      return Task.FromResult(0);
                return Task.CompletedTask;
            }


            var guidCustomer =  context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier &&  c.Issuer == "http://contoso.com").Value;

            Guid exists;

            try
            {
                Guid.TryParse(guidCustomer, out exists);
                if(exists != null && requirement.customerGuid == exists.ToString() )
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
