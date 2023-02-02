using IPLSeasonStats.Extensions.Logger;
using IPLSeasonStats.Services.Contracts;
using IPLSeasonStats.Services;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore;
using IPLSeasonStats.Data;
using IPLSeasonStats.Repository;
using IPLSeasonStats.Repository.Contracts;

namespace IPLSeasonStats.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:MyWorldDbConnection"];
            services.AddDbContext<IPLSeasonStatsDBContext>(o => o.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString)));
        }

        //repository injection
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IIPLSeasonStatsDBRepository, IPLSeasonStatsDBRepository>();
        }

        //service injection
        public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();

    }
}
