using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;


namespace BlueKangrooCoreOnlyAPI.Utilities 
{
public class ValidateAntiForgeryTokenMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IAntiforgery _antiforgery;

        

        public ValidateAntiForgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
    {
        _next = next;
        _antiforgery = antiforgery;
    }

    public async Task Invoke(HttpContext context)
    {
        string path = context.Request.Path.Value!;
       
            // The request token can be sent as a JavaScript-readable cookie, 
            // and Angular uses it by default.
            var tokens = _antiforgery.GetAndStoreTokens(context);
            _antiforgery.GetTokens(context).CookieToken!.Replace(_antiforgery.GetTokens(context).CookieToken!,"X-CSRF-TOKEN");
            context.Response.Cookies.Append("X-CSRF-TOKEN", tokens.RequestToken!, 
                new CookieOptions() { HttpOnly = false });
        

    

            // validate authenticate header information here 
        if (HttpMethods.IsPost(context.Request.Method)  ||  HttpMethods.IsGet(context.Request.Method) || HttpMethods.IsTrace(context.Request.Method) || HttpMethods.IsPut(context.Request.Method))
        {
                
           
           
       //     Console.WriteLine($"Display  {_antiforgery.GetTokens(context)}");   
            await _antiforgery.ValidateRequestAsync(context);
        }

            

           await _next(context);
    
}
}
}


