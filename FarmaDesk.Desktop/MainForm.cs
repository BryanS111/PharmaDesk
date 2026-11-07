using FarmaDesk.Desktop.Forms;
using FarmaDesk.Desktop.Forms.Productos;
using Microsoft.Extensions.DependencyInjection;

namespace FarmaDesk.Desktop;

public class MainForm : Form
{
    private readonly Panel contentPanel = new();
    private readonly Panel dashboardPanel = new();
    private readonly IServiceProvider services;
    private readonly User currentUser;
    private Form? activeForm;

    public MainForm(IServiceProvider services, User currentUser)
    {
        this.services = services;
        this.currentUser = currentUser;
        InitializeLayout();
        ShowDashboard();
    }

    private void InitializeLayout()
    {
        Text = "PharmaDesk - Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        WindowState = FormWindowState.Maximized;
        MinimumSize = new Size(900, 600);

        var menu = new MenuStrip();

        var inventory = new ToolStripMenuItem("Inventario");
        inventory.DropDownItems.Add("Productos", null, (_, _) => OpenForm(services.GetRequiredService<ProductForm>()));
        inventory.DropDownItems.Add("CategorÃ­as", null, (_, _) => OpenForm(services.GetRequiredService<CategoryForm>()));
        inventory.DropDownItems.Add("Presentaciones", null, (_, _) => OpenForm(services.GetRequiredService<PresentationForm>()));

        var sales = new ToolStripMenuItem("Ventas");
        sales.DropDownItems.Add("Clientes", null, (_, _) => OpenForm(new CustomerForm()));
        sales.DropDownItems.Add("Caja", null, (_, _) => OpenForm(new CashRegisterForms(currentUser.ID_Usuario)));
        sales.DropDownItems.Add("Ventas prÃ³ximamente", null, (_, _) => ShowComingSoon("El mÃ³dulo de ventas estarÃ¡ disponible prÃ³ximamente."));

        var purchases = new ToolStripMenuItem("Compras");
        purchases.DropDownItems.Add("Proveedores", null, (_, _) => OpenForm(new SupplierForm()));
        purchases.DropDownItems.Add("Compras prÃ³ximamente", null, (_, _) => ShowComingSoon("El mÃ³dulo de compras estarÃ¡ disponible prÃ³ximamente."));

        var administration = new ToolStripMenuItem("AdministraciÃ³n");
        administration.DropDownItems.Add("Usuarios", null, (_, _) => OpenForm(services.GetRequiredService<UsuariosForm>()));
        administration.DropDownItems.Add("Roles", null, (_, _) => OpenForm(services.GetRequiredService<RoleForm>()));

        menu.Items.AddRange([
            new ToolStripMenuItem("Inicio", null, (_, _) => ShowDashboard()),
            inventory,
            sales,
            purchases,
            administration,
            new ToolStripMenuItem("Cerrar sesiÃ³n", null, (_, _) => Close())
        ]);

        MainMenuStrip = menu;
        Controls.Add(menu);

        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Padding = new Padding(20);
        Controls.Add(contentPanel);
        contentPanel.BringToFront();
    }

    private void ShowDashboard()
    {
        activeForm?.Close();
        activeForm = null;
        contentPanel.Controls.Clear();
        dashboardPanel.Controls.Clear();
        dashboardPanel.Dock = DockStyle.Fill;

        var title = new Label { Text = "Dashboard", AutoSize = true, Location = new Point(10, 10) };
        var description = new Label { Text = "Resumen general de PharmaDesk", AutoSize = true, Location = new Point(10, 45) };

        var summary = new GroupBox { Text = "Resumen", Location = new Point(10, 80), Size = new Size(500, 150) };
        summary.Controls.Add(new Label { Text = "Total vendido hoy: $0.00", AutoSize = true, Location = new Point(20, 30) });
        summary.Controls.Add(new Label { Text = "Productos registrados: 0", AutoSize = true, Location = new Point(20, 60) });
        summary.Controls.Add(new Label { Text = "Productos con stock bajo: 0", AutoSize = true, Location = new Point(20, 90) });
        summary.Controls.Add(new Label { Text = "Estado de caja: Cerrada", AutoSize = true, Location = new Point(20, 120) });

        var alerts = new GroupBox { Text = "Alertas del sistema", Location = new Point(10, 250), Size = new Size(500, 140) };
        alerts.Controls.Add(new Label
        {
            Text = "- No hay ventas registradas durante el dÃ­a.\n- No hay productos con stock bajo.\n- La caja aÃºn no ha sido abierta.",
            AutoSize = true,
            Location = new Point(20, 30)
        });

        var shortcuts = new GroupBox { Text = "Accesos rÃ¡pidos", Location = new Point(540, 80), Size = new Size(300, 180) };
        var productsButton = new Button { Text = "Productos", AutoSize = true, Location = new Point(20, 30) };
        productsButton.Click += (_, _) => OpenForm(services.GetRequiredService<ProductForm>());
        var categoriesButton = new Button { Text = "CategorÃ­as", AutoSize = true, Location = new Point(20, 70) };
        categoriesButton.Click += (_, _) => OpenForm(services.GetRequiredService<CategoryForm>());
        var presentationsButton = new Button { Text = "Presentaciones", AutoSize = true, Location = new Point(20, 110) };
        presentationsButton.Click += (_, _) => OpenForm(services.GetRequiredService<PresentationForm>());
        shortcuts.Controls.AddRange([productsButton, categoriesButton, presentationsButton]);

        dashboardPanel.Controls.AddRange([title, description, summary, alerts, shortcuts]);
        contentPanel.Controls.Add(dashboardPanel);
    }

    private void OpenForm(Form form)
    {
        activeForm?.Close();
        activeForm = form;
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        contentPanel.Controls.Clear();
        contentPanel.Controls.Add(form);
        form.Show();
    }

    private void InitializeComponent()
    {

    }

    private static void ShowComingSoon(string message)
    {
        MessageBox.Show(message, "MÃ³dulo pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

