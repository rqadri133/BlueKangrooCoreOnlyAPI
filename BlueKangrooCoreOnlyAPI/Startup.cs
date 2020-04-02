using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.EntityFrameworkCore;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Logging;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using  m = BlueKangrooCoreOnlyAPI.options;
using Microsoft.AspNetCore.Authentication;
using BlueKangrooCoreOnlyAPI.AuthenticationHandlers;
using BlueKangrooCoreOnlyAPI.Headers;
using BlueKangrooCoreOnlyAPI.AuthorizationHandlers;
using Scrutor;
using Google.Cloud.Diagnostics.AspNetCore;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace BlueKangrooCoreOnlyAPI
{
    public class Startup
    {


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
        
            
           services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               
           }).AddJwtBearer(options =>
           {
               options.Authority = $"https://{Configuration["Auth0:Domain"]}/";
               options.Audience = Configuration["Auth0:Audience"];
           });           
            services.AddControllers();
            services.AddCors(option => option.AddPolicy("MyPolicy", builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();  }));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0); 
            services.AddDbContext<blueKangrooContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BlueKangrooDBConnection"), providerOptions => providerOptions.EnableRetryOnFailure()));
            services.AddHttpContextAccessor();
             
            


            services.Scan(scan => scan
            .FromAssemblyOf<IAuthorizationHandler>()
            .AddClasses()
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsSelf()
            .WithSingletonLifetime());
            services.AddAuthorization(options =>
            {
                options.AddPolicy("CustomGuidAuthorization", policy =>
                    policy.Requirements.Add(new CustomerGuidHandlerRequirement()));
            });
            services.AddSingleton<IBlueKangrooRepository, BlueKangrooRepository>();
            services.AddSingleton<IAuthorizationHandler, CustomGuidAuthorizationHandler>();
            services.AddSingleton<IUserAuthorization, UserAuthorization>();
          
            services.AddSwaggerGen(c =>
          {
             c.SwaggerDoc("v1", new OpenApiInfo() { Title = "BlueKangrooAPI", Version = "V1" } );
              c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
              {
                  Description =
                   "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                  Name = "Authorization",
                  In = ParameterLocation.Header,
                  Type = SecuritySchemeType.ApiKey,
                  Scheme = "Bearer"
              });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
               {
                         new OpenApiSecurityScheme
                        {
                     Reference = new OpenApiReference
                       {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header,

           },
             new List<string>()
            }
         }); 
              c.OperationFilter<AuthorizationHeaderParameterOperationFilter>();


          });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
           
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCors("MyPolicy");

          
            //  app.UseMvc();
       
            var swaggerOptions = new m.SwaggerOptions();
            Configuration.GetSection(nameof(m.SwaggerOptions)).Bind(swaggerOptions);

            /*Enabling Swagger ui, consider doing it on Development env only*/
            app.UseSwagger(option =>
          {
              option.RouteTemplate = swaggerOptions.JsonRoute;
      
          });

           app.UseSwaggerUI(option =>
             {
                 option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
                 option.DisplayOperationId();
            });
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Authorization", "bearer");
                context.Response.Headers.Add("CustomerGuidKey", "entercustomerkey");
                await next.Invoke();
            });
            var credential = GoogleCredential.FromFile("BlueKangrooCoreApiOnly-6d3cfabd9cfc.json");
            var storage = StorageClient.Create(credential);

            Console.WriteLine(env.EnvironmentName);
    
        }

         // If using Scrutor the folllowing is not required
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // this will supere cede all other registerations
            builder.RegisterType<BlueKangrooRepository>()
                    .As<IBlueKangrooRepository>()
                    .InstancePerLifetimeScope();
                    
           

        }
    }
}
