using FarmaDesk.BusinessLogic;
using FarmaDesk.DataAccess;
using FarmaDesk.Desktop.Forms;
using FarmaDesk.Desktop.Forms.Productos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FarmaDesk.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<EstadoRepository>();
            services.AddScoped<CategoriaRepository>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<PresentationRepository>();
            services.AddScoped<SupplierRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<RoleRepository>();
            services.AddTransient<CategoryForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<PresentationForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<login>();
            services.AddScoped<UserRepository>();

            using var serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<login>());
        }
    }
}
