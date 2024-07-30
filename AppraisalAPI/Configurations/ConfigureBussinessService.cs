using AppraisalAPI.Services;
using AppraisalBussiness.Interfaces;
using AppraisalBussiness.Repositories;

namespace AppraisalAPI.Configurations
{
    public static class ConfigureBussinessService
    {
        public static IServiceCollection AddBussinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IKPIRepository, KPIRepository>();

            services.AddScoped<KPIService>();

            return services;
        }
    }
}
