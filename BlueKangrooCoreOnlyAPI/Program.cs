using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
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

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Scrutor;
using System;
using System.Collections.Generic;
using m = BlueKangrooCoreOnlyAPI.options;
using AWS.Logger.AspNetCore;
using Microsoft.AspNetCore.Http;
using Google;
using BlueKangrooCoreOnlyAPI.Controllers;
using Microsoft.AspNetCore.Cors.Infrastructure;
using BlueKangrooCoreOnlyAPI;
using Microsoft.AspNetCore.DataProtection;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var services = builder.Services;
      List<string> clientURLS = new List<string>();
            clientURLS.Add(builder.Configuration["baseClientUrl"]);
            clientURLS.Add(builder.Configuration["prodClientUrl"]);

            services.AddCors(options =>
            {
                options.AddPolicy(name: "BlueCorsPolicy",
                    builder => builder.WithOrigins(clientURLS.ToArray())
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                  );
            });

        services.AddEndpointsApiExplorer();          
            
            services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               
           }).AddJwtBearer(options =>
           {
               options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}/";
               options.Audience = builder.Configuration["Auth0:Audience"];
           });           
            

            services.AddAuthorization(options =>
            {
                options.AddPolicy("CustomGuidAuthorization", policy =>
                    policy.Requirements.Add(new CustomerGuidHandlerRequirement()));
            });
     
                

            
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0); 
            services.AddDbContext<blueKangrooContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("BlueKangrooDBConnection"), providerOptions => providerOptions.EnableRetryOnFailure()));
            services.AddHttpContextAccessor();
            
            
            
            services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(@"\users\syedqadri\documents\tempkeys\"));
            

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


            services.AddControllers()
              .AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
               );

            services.AddMemoryCache();
            services.AddStackExchangeRedisCache(options => { options.Configuration = builder.Configuration["RedisServerURL"]; });

       
           services.AddDependencies();



var app = builder.Build();


if (builder.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }

            app.UseCors("BlueCorsPolicy");
            app.UseAuthentication();
                   
            app.UseRouting();
           app.UseAuthorization();

   
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
           
            
            
            var swaggerOptions = new m.SwaggerOptions();
            builder.Configuration.GetSection(nameof(m.SwaggerOptions)).Bind(swaggerOptions);

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
                context.Response.Headers.Add("Authorization", "bearer" );
                context.Response.Headers.Add("CustomerGuidKey", "entercustomerkey");
                
                await next.Invoke();
            });

            

            // AWS Logging configurati
    
           

            Console.WriteLine(builder.Environment.EnvironmentName);
   
            app.Run();