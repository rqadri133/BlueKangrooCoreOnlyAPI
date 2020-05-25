using BlueKangrooCoreOnlyAPI.AuthorizationHandlers;
using BlueKangrooCoreOnlyAPI.Caching;
using BlueKangrooCoreOnlyAPI.Controllers;
using BlueKangrooCoreOnlyAPI.Models;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
            services.AddSingleton<IActivityRepository, ActivityRepository>();
            services.AddSingleton<IBuyerActivityRepository, BuyerActivityRepository>();
            services.AddSingleton<ISellerActivityRepository, SellerActivityRepository>();
            services.AddSingleton<IAuthorizationHandler, CustomGuidAuthorizationHandler>();
            services.AddSingleton(typeof(ILogger), typeof(ILogger<AppBuyerController>));
            services.AddSingleton(typeof(ILogger), typeof(ILogger<ActivityController>));
            services.AddSingleton<IDemandRepository, DemandRepository>();  
            services.AddSingleton<IUserAuthorization, UserAuthorization>();
            services.AddSingleton<ISupplyRepository, SupplyRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddScoped(typeof(ICacheManager<AppBuyer>), typeof(CacheManager<AppBuyer>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<CustomGuidAuthorizationHandler>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<UserAuthorization>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppDemandController>));


            services.AddScoped(typeof(ICacheManager<AppProduct>), typeof(CacheManager<AppProduct>));
            services.AddScoped(typeof(ICacheManager<AppSupply>), typeof(CacheManager<AppSupply>));

            services.AddScoped(typeof(ICacheManager<AppCategory>), typeof(CacheManager<AppCategory>));
            // Adding Dependencies for Generics
            services.AddScoped(typeof(ICacheManager<AppSeller>), typeof(CacheManager<AppSeller>));
            services.AddScoped(typeof(ICacheManager<AppFreight>), typeof(CacheManager<AppFreight>));
            services.AddScoped(typeof(ICacheManager<AppActivity>), typeof(CacheManager<AppActivity>));
            services.AddScoped(typeof(ICacheManager<AppDemand>), typeof(CacheManager<AppDemand>));
            services.AddScoped(typeof(ICacheManager<AppBuyerActivity>), typeof(CacheManager<AppBuyerActivity>));
            services.AddScoped(typeof(ICacheManager<AppSellerActivity>), typeof(CacheManager<AppSellerActivity>));


        }

    }
}
