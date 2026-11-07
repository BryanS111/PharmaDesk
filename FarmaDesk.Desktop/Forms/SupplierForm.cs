using FarmaDesk.BusinessLogic;
using FarmaDesk.DataAccess;
using FarmaDesk.Entity;

namespace FarmaDesk.Desktop.Forms;

public partial class SupplierForm : Form
{
    private int? supplierId;
    public SupplierForm()
    {
        InitializeComponent(); ConfigureGrid(); cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList; cmbEstado.Items.AddRange(["ACTIVO", "INACTIVO"]);
        Load += (_, _) => { LoadSuppliers(); ClearForm(); }; btnNuevo.Click += (_, _) => ClearForm(); btnLimpiar.Click += (_, _) => ClearForm(); btnGuardar.Click += SaveSupplier; btnEliminar.Click += DeactivateSupplier; dataGrid_Proveedor.CellClick += SelectSupplier;
    }
    private static AppDBContext CreateContext() => new AppDBContextFactory().CreateDbContext([]);
    private void ConfigureGrid()
    {
        dataGrid_Proveedor.AutoGenerateColumns = false; dataGrid_Proveedor.AllowUserToAddRows = false; dataGrid_Proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ID.DataPropertyName = nameof(SupplierRow.ID_Proveedor); Proveedor.DataPropertyName = nameof(SupplierRow.Proveedor); Telefono.DataPropertyName = nameof(SupplierRow.Telefono); Direccion.DataPropertyName = nameof(SupplierRow.Direccion); Correo.DataPropertyName = nameof(SupplierRow.Correo); NIT.DataPropertyName = nameof(SupplierRow.NIT); NRC.DataPropertyName = nameof(SupplierRow.NRC); Estado.DataPropertyName = nameof(SupplierRow.Estado);
    }
    private void LoadSuppliers()
    {
        try { using var db = CreateContext(); dataGrid_Proveedor.DataSource = new SupplierRepository(db).GetAll().Select(s => new SupplierRow(s.ID_Proveedor, s.Proveedor, s.Telefono, s.Direccion, s.Correo, s.NIT, s.NRC, s.Estado.Estado)).ToList(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void SaveSupplier(object? sender, EventArgs e)
    {
        try
        {
            var entity = new Supplier { ID_Proveedor = supplierId ?? 0, Proveedor = txtProveedor.Text.Trim(), Telefono = txtTelefono.Text.Trim(), Direccion = txtDireccion.Text.Trim(), Correo = textCorreo.Text.Trim(), NIT = textNIT.Text.Trim(), NRC = txtNRC.Text.Trim(), ID_Estado = cmbEstado.SelectedItem?.ToString() == "INACTIVO" ? EstadoIds.Inactivo : EstadoIds.Activo };
            using var db = CreateContext(); var service = new SupplierRepository(db); if (supplierId.HasValue) service.Update(entity); else service.Insert(entity);
            MessageBox.Show("Proveedor guardado correctamente.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadSuppliers(); ClearForm();
        }
        catch (Exception ex) { ShowError(ex); }
    }
    private void SelectSupplier(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dataGrid_Proveedor.Rows[e.RowIndex].DataBoundItem is not SupplierRow row) return;
        supplierId = row.ID_Proveedor; txtProveedor.Text = row.Proveedor; txtTelefono.Text = row.Telefono; txtDireccion.Text = row.Direccion; textCorreo.Text = row.Correo; textNIT.Text = row.NIT; txtNRC.Text = row.NRC; cmbEstado.SelectedItem = row.Estado;
    }
    private void DeactivateSupplier(object? sender, EventArgs e)
    {
        if (!supplierId.HasValue) { MessageBox.Show("Seleccione un proveedor para desactivarlo.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (MessageBox.Show("¿Desea desactivar el proveedor seleccionado?", "Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try { using var db = CreateContext(); new SupplierRepository(db).Deactivate(supplierId.Value); LoadSuppliers(); ClearForm(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void ClearForm() { supplierId = null; txtProveedor.Clear(); txtTelefono.Clear(); txtDireccion.Clear(); textCorreo.Clear(); textNIT.Clear(); txtNRC.Clear(); cmbEstado.SelectedItem = "ACTIVO"; dataGrid_Proveedor.ClearSelection(); }
    private sealed record SupplierRow(int ID_Proveedor, string Proveedor, string Telefono, string Direccion, string Correo, string NIT, string NRC, string Estado);
    private static void ShowError(Exception ex) => MessageBox.Show(ex.GetBaseException().Message, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
