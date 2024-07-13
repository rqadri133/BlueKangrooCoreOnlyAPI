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
    
        var tokenSet = _antiforgery.GetAndStoreTokens(context);
          Trace.Write(tokenSet);
                 Trace.Write(tokenSet.CookieToken!);

            // validate authenticate header information here 
        if (HttpMethods.IsPost(context.Request.Method)  ||  HttpMethods.IsTrace(context.Request.Method))
        {
                var requestPath = context.Request.Path.Value;
                
           
            context.Response.Cookies.Append("XSRF-TOKEN", tokenSet.RequestToken!,
                    new CookieOptions { HttpOnly = false });
            Console.WriteLine($"Display  {_antiforgery.GetTokens(context)}");   
            await _antiforgery.ValidateRequestAsync(context);
        }

            

           await _next(context);
    }
}

}
