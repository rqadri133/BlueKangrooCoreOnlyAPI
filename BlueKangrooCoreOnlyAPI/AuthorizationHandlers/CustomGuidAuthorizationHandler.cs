using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
    // this class will take AppToken ID

    public class CustomGuidAuthorizationHandler : AuthorizationHandler<CustomerGuidHandlerRequirement> , IAuthorizationRequirement
    {
     
        IUserAuthorization userAuthorization;
        IHttpContextAccessor _httpContextAccessor = null;
        ILogger _logger = null;
        public CustomGuidAuthorizationHandler(IUserAuthorization userAuthorization, IHttpContextAccessor httpContextAccessor  , ILogger<CustomGuidAuthorizationHandler> logger)
        {
            this.userAuthorization = userAuthorization;
            this._httpContextAccessor = httpContextAccessor;
            this._logger = logger;

        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomerGuidHandlerRequirement requirement)
        {
            HttpContext httpContext = _httpContextAccessor.HttpContext;
            _logger.LogInformation("Inside Handle Requirement Async");
            string guidCustomer = httpContext.Request.Headers["CustomerGuidKey"];
            string _auth0Key = httpContext.Request.Headers["Authorization"];
            if (String.IsNullOrEmpty(guidCustomer))
            {
                //TODO: Use the following if targeting a version of
                //.NET Framework older than 4.6:
                //      return Task.FromResult(0);
                return Task.CompletedTask;
            }

     
            Guid exists;

            try
            {
                Guid.TryParse(guidCustomer, out exists);
                if(exists != null)
                {
                    Task<bool> _IsUserExist = this.userAuthorization.IsUserAuthorized(exists);
                    if (_IsUserExist.Result)
                    {
                        requirement.CustomerGuidKey = exists.ToString();
                        requirement.Authorization = _auth0Key;
                        context.Succeed(requirement);
                    }
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
