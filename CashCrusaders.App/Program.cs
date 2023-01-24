using CashCrusaders.Data;
using CashCrusaders.Data.Repositories;
using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Resources;

namespace CashCrusaders.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using var provider = services.BuildServiceProvider();

            var main = provider.GetRequiredService<Main>();
            Application.Run(main);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            const string resxFile = @".\CashCrusadersResource.resx";
            var connection = string.Empty;
            using (var resxSet = new ResXResourceSet(resxFile))
            {
                connection = resxSet.GetString("connectionString");
            }

            services.AddScoped<IProductsRepository, ProductsRepository>()
                    .AddScoped<IOrdersRepository, OrdersRepository>()
                    .AddSingleton<ISuppliersRepository, SuppliersRepository>()
                    .AddScoped<IProductsService, ProductsService>()
                    .AddScoped<IOrdersService, OrdersService>()
                    .AddScoped<ISuppliersService, SuppliersService>();
            services.AddScoped<Main>();
            services.AddDbContext<Storage>(options =>
            {
                options.UseSqlServer(connection, other =>
                {
                    other.MigrationsAssembly(typeof(Storage).Assembly.FullName);
                    other.EnableRetryOnFailure(3);
                    other.CommandTimeout(30000);
                });
            });
        }
    }
}