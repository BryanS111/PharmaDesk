using FarmaDesk.Desktop.Forms.Productos; // me acuerdan que temporalmente estoy usando el formulario de productos para probar la aplicacion

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
            //Application.Run(new Form1());
            Application.Run(new ProductosForm());
        }
    }
}