﻿using BlueKangrooCoreOnlyAPI.AuthorizationHandlers;
using BlueKangrooCoreOnlyAPI.Caching;
using BlueKangrooCoreOnlyAPI.Models;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace BlueKangrooCoreOnlyAPI
{
    public static class RepositoryAndContollerDependencies
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IBlueKangrooRepository, BlueKangrooRepository>();
            services.AddSingleton<IGroundLogistics, GroundLogistics>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IFreightRepository, FreightRepository>();
            services.AddSingleton<IAuthorizationHandler, CustomGuidAuthorizationHandler>();
            services.AddSingleton<IUserAuthorization, UserAuthorization>();
            services.AddScoped(typeof(ICacheManager<AppBuyer>), typeof(CacheManager<AppBuyer>));
            services.AddScoped(typeof(ICacheManager<AppProduct>), typeof(CacheManager<AppProduct>));
            // Adding Dependencies for Generics
            services.AddScoped(typeof(ICacheManager<AppSeller>), typeof(CacheManager<AppSeller>));
            services.AddScoped(typeof(ICacheManager<AppFreight>), typeof(CacheManager<AppFreight>));


        }

    }
}
