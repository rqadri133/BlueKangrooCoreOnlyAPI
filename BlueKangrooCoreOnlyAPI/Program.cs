using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Autofac.Extensions.DependencyInjection;
using Autofac;
namespace BlueKangrooCoreOnlyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
     if (args == null)
    {
        // Handle the null case, e.g., initialize to empty array or log an error
        args = Array.Empty<string>();
    }
            CreateHostBuilder(args).Build().Run();

            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseSetting("https_port", "5005");
                   webBuilder.UseStartup<Startup>()
                      .UseUrls("http://0.0.0.0:80"); 
                    //webBuilder.UseConfigurati
                }
                
                
                )
               
            ;
    }
}
