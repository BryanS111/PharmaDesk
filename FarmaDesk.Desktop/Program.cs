using FarmaDesk.Desktop.Forms.Productos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; // me acuerdan que temporalmente estoy usando el formulario de productos para probar la aplicacion
using FarmaDesk.DataAccess;

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
            /*

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("conn"),
                    b => b.MigrationsAssembly("KioscoSV.DataAccess")
                ));

            
            services.AddScoped<ProductRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<CategoriaRepository>();
            services.AddScoped<EstadoRepository>();

            services.AddTransient<frmProductos>();
            services.AddTransient<frmCategorias>();
            services.AddTransient<frmCategoriasNuevo>();
            services.AddTransient<frmPrincipal>();


            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<frmPrincipal>();
            */
            Application.Run(new Forms.CashRegisterForms());
        }
    }
}