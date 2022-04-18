using CloudCustomers.Data.Config;
using CloudCustomers.Services.Services;

namespace CloudCustomers.WebApi.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServiceCollections(this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<UsersApiOptions>(config.GetSection("UsersApiOptions"));
            services.AddScoped<IUserService, UserService>();
            services.AddHttpClient<IUserService, UserService>();
            return services;
        }
    }
}
