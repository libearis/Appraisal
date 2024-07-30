using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AppraisalDataAccess.Models;

namespace AppraisalDataAccess
{
    public static class Dependencies
    {
        public static void ConfigureService(IConfiguration configuration, IServiceCollection service)
        {
            service.AddDbContext<AppraisalContext>(
                option => option.UseNpgsql(configuration.GetConnectionString("AppraisalConnection"))
            );
        }
    }
}
