using Contracts;
using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployee.Extensions;

public static class ServiceExtensions
{

    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
        });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddScoped<ILoggerManager, LoggerManager>();

    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
            builder => builder.MigrationsAssembly("CompanyEmployees")));
}
