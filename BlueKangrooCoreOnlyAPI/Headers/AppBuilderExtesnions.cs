
// This will 
using Microsoft.AspNetCore.Builder;
using BlueKangrooCoreOnlyAPI.Utilities;
public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseAntiforgeryTokens(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();
    }
}