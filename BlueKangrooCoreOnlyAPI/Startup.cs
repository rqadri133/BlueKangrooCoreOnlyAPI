using Autofac;
using BlueKangrooCoreOnlyAPI.AuthorizationHandlers;
using BlueKangrooCoreOnlyAPI.Caching;
using BlueKangrooCoreOnlyAPI.Headers;
using BlueKangrooCoreOnlyAPI.Models;
using BlueKangrooCoreOnlyAPI.Repository;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Scrutor;
using System;
using System.Collections.Generic;
using m = BlueKangrooCoreOnlyAPI.options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Antiforgery;
using BlueKangrooCoreOnlyAPI.Utilities;

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
            List<string> clientURLS = new List<string>();
            clientURLS.Add(Configuration["baseClientUrl"]);
            clientURLS.Add(Configuration["prodClientUrl"]);

            services.AddCors(options =>
            {
                options.AddPolicy(name: "BlueCorsPolicy",
                    builder => builder.WithOrigins(clientURLS.ToArray())
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                  );
            });


            services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               
           }).AddJwtBearer(options =>
           {
               options.Authority = $"https://{Configuration["Auth0:Domain"]}/";
               options.Audience = Configuration["Auth0:Audience"];
           });       
          
             services.AddDbContext<blueKangrooContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BlueKangrooDBConnection"), providerOptions => providerOptions.EnableRetryOnFailure()));
              

            services.AddControllers()
              .AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore 

               );        
        services.AddMvc(); 

               
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
             services.AddDependencies();


           
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

   

            services.AddMemoryCache();
            // Global validation no need at Class levels but question is its API 
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });
            


            services.AddStackExchangeRedisCache(options => { options.Configuration = Configuration["RedisServerURL"]; });
        
            // prevent from froegry token it must be added afetr Add Stack
                      
                          

        
        
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory logger , IAntiforgery antiforgery)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }
            else
            {          
                app.UseHttpsRedirection();
            }

           
     
            app.UseCors("BlueCorsPolicy");
            app.UseAuthentication();
         

            app.UseRouting();

            app.UseAuthorization(); 
                
              



            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
           
          // app.UseAntiforgeryTokens();
   
    /* app.Use(next => context =>
    {
        string path = context.Request.Path.Value!;

        if (string.Equals(path, "/", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(path, "/swagger", StringComparison.OrdinalIgnoreCase))
        {
            // The request token can be sent as a JavaScript-readable cookie, 
            // and Angular uses it by default.s
            var tokens = antiforgery.GetAndStoreTokens(context);
            

            context.Response.Cookies.Append("XSRF-TOKEN", tokens.RequestToken!, 
                new CookieOptions() { HttpOnly = false });
        }

        return next(context);
    }); */
             
         
            
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

         
           app.UseHttpsRedirection();

         

            // stored tokens shifting redirect

        }
          
         // If using Scrutor the folllowing is not required
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // this will supere cede all other registerations
            builder.RegisterType<BlueKangrooRepository>()
                    .As<IBlueKangrooRepository>()
                    .InstancePerLifetimeScope();
            builder.RegisterType<TemplateUIRepository>()
                    .As<ITemplateUIRepository>()
                    .InstancePerLifetimeScope();


            builder.RegisterType<CacheManager<AppBuyer>>().As<ICacheManager<AppBuyer>>();
            builder.RegisterType<CacheManager<AppProduct>>().As<ICacheManager<AppProduct>>();
            builder.RegisterType<CacheManager<AppSeller>>().As<ICacheManager<AppSeller>>();




        }

static void HandleMapTest1(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Map Test 1");
    });
}

static void HandleMapTest2(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Map Test 2");
    });
}
    }
}
