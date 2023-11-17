using Microsoft.EntityFrameworkCore;
using PostgresDemo.Repositories;

namespace PostgresDemo.Data;

public static class DataAccessConfiguration
{
    public static void AddScopedServices(this IServiceCollection services)
    {
        services.AddScoped<ITeamRepository, TeamRepository>();
        //services.AddScoped<IPlayerRepository, TeamRepository>();
        //services.AddScoped<IPlayerMediaRepository, TeamRepository>();
    }

    public static void ConfigureDbContext(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApiDbContext>(options =>
                    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
    }
}
