using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using DocumentationWebSiteApi.Services;
using DocumentationWebSiteApi.Database.EntityFramework;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Microsoft.EntityFrameworkCore;

namespace DocumentationWebSiteApi.Extentions
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IHashService, HashService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            var dataSource = dataSourceBuilder.Build();

            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                options.UseNpgsql(dataSource,
                    options =>
                    {
                        options.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name);
                        options.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30), errorCodesToAdd: null);
                        options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    })
                    .EnableSensitiveDataLogging();
            });
            services.AddScoped<IAppDbContext, AppDbContext>();

            return services;
        }
    }
}
