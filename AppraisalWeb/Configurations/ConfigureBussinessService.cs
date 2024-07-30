using AppraisalBussiness.Interfaces;
using AppraisalBussiness.Repositories;
using AppraisalWeb.Services;

namespace AppraisalWeb.Configurations
{
    public static class ConfigureBussinessService
    {
        public static IServiceCollection AddBussinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IKPIRepository, KPIRepository>();

            services.AddScoped<ProfileService>();
            services.AddScoped<AuthorizationService>();
            services.AddScoped<PenilaianService>();

            return services;
        }
    }
}
