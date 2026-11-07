using FarmaDesk.BusinessLogic;
using FarmaDesk.DataAccess;
using FarmaDesk.Entity;

namespace FarmaDesk.Desktop.Forms;

public partial class CustomerForm : Form
{
    private int? customerId;
    public CustomerForm()
    {
        InitializeComponent();
        ConfigureGrid();
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEstado.Items.AddRange(["ACTIVO", "INACTIVO"]);
        Load += (_, _) => { LoadCustomers(); ClearForm(); };
        btnNuevo.Click += (_, _) => ClearForm(); btnLimpiar.Click += (_, _) => ClearForm();
        btnGuardar.Click += SaveCustomer; btnEliminar.Click += DeactivateCustomer;
        dataGrid_Presentacion.CellClick += SelectCustomer;
    }
    private static AppDBContext CreateContext() => new AppDBContextFactory().CreateDbContext([]);
    private void ConfigureGrid()
    {
        dataGrid_Presentacion.AutoGenerateColumns = false; dataGrid_Presentacion.AllowUserToAddRows = false;
        dataGrid_Presentacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ID.DataPropertyName = nameof(CustomerRow.ID_Cliente); Nombre.DataPropertyName = nameof(CustomerRow.Nombre);
        Apellido.DataPropertyName = nameof(CustomerRow.Apellido); Telefono.DataPropertyName = nameof(CustomerRow.Telefono);
        Documento.DataPropertyName = nameof(CustomerRow.Documento); Direccion.DataPropertyName = nameof(CustomerRow.Direccion); Estado.DataPropertyName = nameof(CustomerRow.Estado);
    }
    private void LoadCustomers()
    {
        try { using var db = CreateContext(); dataGrid_Presentacion.DataSource = new CustomerRepository(db).GetAll().Select(c => new CustomerRow(c.ID_Cliente, c.Nombre, c.Apellido, c.Telefono, c.Documento, c.Direccion, c.Estado.Estado, c.ID_Estado)).ToList(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void SaveCustomer(object? sender, EventArgs e)
    {
        try
        {
            var entity = new Customer { ID_Cliente = customerId ?? 0, Nombre = txtProducto.Text.Trim(), Apellido = textPresentacion.Text.Trim(), Telefono = textBox1.Text.Trim(), Documento = textBox2.Text.Trim(), Direccion = txtDireccion.Text.Trim(), ID_Estado = cmbEstado.SelectedItem?.ToString() == "INACTIVO" ? EstadoIds.Inactivo : EstadoIds.Activo };
            using var db = CreateContext(); var service = new CustomerRepository(db);
            if (customerId.HasValue) service.Update(entity); else service.Insert(entity);
            MessageBox.Show("Cliente guardado correctamente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadCustomers(); ClearForm();
        }
        catch (Exception ex) { ShowError(ex); }
    }
    private void SelectCustomer(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dataGrid_Presentacion.Rows[e.RowIndex].DataBoundItem is not CustomerRow row) return;
        customerId = row.ID_Cliente; txtProducto.Text = row.Nombre; textPresentacion.Text = row.Apellido; textBox1.Text = row.Telefono; textBox2.Text = row.Documento; txtDireccion.Text = row.Direccion; cmbEstado.SelectedItem = row.Estado;
    }
    private void DeactivateCustomer(object? sender, EventArgs e)
    {
        if (!customerId.HasValue) { MessageBox.Show("Seleccione un cliente para desactivarlo.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (MessageBox.Show("¿Desea desactivar el cliente seleccionado?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try { using var db = CreateContext(); new CustomerRepository(db).Deactivate(customerId.Value); LoadCustomers(); ClearForm(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void ClearForm()
    {
        customerId = null; txtProducto.Clear(); textPresentacion.Clear(); textBox1.Clear(); textBox2.Clear(); txtDireccion.Clear(); cmbEstado.SelectedItem = "ACTIVO"; dataGrid_Presentacion.ClearSelection();
    }
    private sealed record CustomerRow(int ID_Cliente, string Nombre, string Apellido, string Telefono, string Documento, string Direccion, string Estado, int ID_Estado);
    private static void ShowError(Exception ex) => MessageBox.Show(ex.GetBaseException().Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
