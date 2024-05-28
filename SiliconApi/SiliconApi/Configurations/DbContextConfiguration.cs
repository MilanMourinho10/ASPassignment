using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace SiliconApi.Configurations;

public static class DbContextConfiguration
{
    public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(x => x.UseSqlServer(configuration.GetConnectionString("SqlServer"), b => b.MigrationsAssembly("SiliconApi")));
    }
}
