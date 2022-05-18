using System.Collections.Generic;
using System.Linq;
using BlueKangrooCoreOnlyAPI.Filters;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlueKangrooCoreOnlyAPI.Headers
{
    public class AuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();
             var descriptor = context.ApiDescription.ActionDescriptor as ControllerActionDescriptor;
            if (descriptor != null && descriptor.ControllerName  != "AppUser")
            {
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "CustomerGuidKey",
                    In = ParameterLocation.Header,
                    Description = "after login guid",
                 
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                        Default = new OpenApiString("apitoken") ,
                        Format = "string"
                    } 
                    

                     
                });

            }
        }
        
    }
}
