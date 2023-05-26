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
            services.AddScoped<IBlueKangrooRepository, BlueKangrooRepository>();
            services.AddScoped<IGroundLogistics, GroundLogistics>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IFreightRepository, FreightRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<IBuyerActivityRepository, BuyerActivityRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddScoped<ISellerActivityRepository, SellerActivityRepository>();
            services.AddScoped<IAuthorizationHandler, CustomGuidAuthorizationHandler>();

            services.AddScoped<IDemandRepository, DemandRepository>();  
            services.AddScoped<IUserAuthorization, UserAuthorization>();
            services.AddScoped<ISupplyRepository, SupplyRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ITemplateUIRepository, TemplateUIRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IAuthorizationService, AuthorizationService>();
            services.AddScoped(typeof(ICacheManager<AppBuyer>), typeof(CacheManager<AppBuyer>));
            
            
            services.AddScoped<IAuthorizationHandler, CustomGuidAuthorizationHandler>();

            services.AddScoped<IAuthorizationRequirement, CustomerGuidHandlerRequirement>();
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

        }

    }
}
