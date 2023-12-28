using BlueKangrooCoreOnlyAPI.AuthorizationHandlers;
using BlueKangrooCoreOnlyAPI.Caching;
using BlueKangrooCoreOnlyAPI.Controllers;
using BlueKangrooCoreOnlyAPI.Models;
using BlueKangrooCoreOnlyAPI.Repositories;
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
            services.AddSingleton<IRoleRepository, RoleRepository>();

            services.AddSingleton<ISellerActivityRepository, SellerActivityRepository>();
            services.AddSingleton<IAuthorizationHandler, CustomGuidAuthorizationHandler>();
            services.AddSingleton<IDemandRepository, DemandRepository>();  
            services.AddSingleton<IUserAuthorization, UserAuthorization>();
            services.AddSingleton<ISupplyRepository, SupplyRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<ICompanyRepository, CompanyRepository>();
            services.AddSingleton<ITemplateUIRepository, TemplateUIRepository>();
        
            services.AddScoped(typeof(ICacheManager<AppBuyer>), typeof(CacheManager<AppBuyer>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<CustomGuidAuthorizationHandler>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<UserAuthorization>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppDemandController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppBuyerController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<ActivityController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppUserController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppCompanyController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppGroundActivityController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<AppProductController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<CategoryController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<SellerActivityController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<RoleController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<TempUIController>));
            services.AddScoped(typeof(ILogger), typeof(ILogger<BrandController>));





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
            services.AddScoped(typeof(ICacheManager<AppCompany>), typeof(CacheManager<AppCompany>));
            services.AddScoped(typeof(ICacheManager<AppGroundActivity>), typeof(CacheManager<AppGroundActivity>));
            services.AddScoped(typeof(ICacheManager<AppUserRole>), typeof(CacheManager<AppUserRole>));
            services.AddScoped(typeof(ICacheManager<AppUserRoleDetail>), typeof(CacheManager<AppUserRoleDetail>));
            services.AddScoped(typeof(ICacheManager<AppUitemplate>), typeof(CacheManager<AppUitemplate>));
            services.AddScoped(typeof(ICacheManager<AppBrand>), typeof(CacheManager<AppBrand>));
            services.AddScoped(typeof(IServiceBus<AppDispatchAssigned>), typeof(DispatchItemServiceBus<AppDispatchAssigned>));

        }

    }
}
