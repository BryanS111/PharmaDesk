using FarmaDesk.BusinessLogic;
using FarmaDesk.DataAccess;
using FarmaDesk.Entity;
using System.Globalization;

namespace FarmaDesk.Desktop.Forms;

public partial class CashRegisterForms : Form
{
    private readonly int currentUserId;
    private int? cashRegisterId;
    public CashRegisterForms(int currentUserId)
    {
        this.currentUserId = currentUserId;
        InitializeComponent(); ConfigureGrid(); cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList; cmbUsuario.Enabled = false; cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList; cmbEstado.Items.AddRange(["ABIERTA", "CERRADA"]); cmbEstado.Enabled = false;
        Load += (_, _) => { LoadUsers(); LoadCashRegisters(); PrepareOpening(); }; btnNuevo.Click += OpenCashRegister; btnGuardar.Click += CloseCashRegister; dgvProductos.CellClick += SelectCashRegister;
    }
    private static AppDBContext CreateContext() => new AppDBContextFactory().CreateDbContext([]);
    private void ConfigureGrid()
    {
        dgvProductos.AutoGenerateColumns = false; dgvProductos.AllowUserToAddRows = false; dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ID.DataPropertyName = nameof(CashRow.ID_Caja); Usuario.DataPropertyName = nameof(CashRow.Usuario); Apertura.DataPropertyName = nameof(CashRow.Fecha_Apertura); Cierre.DataPropertyName = nameof(CashRow.Fecha_Cierre); MontoInicial.DataPropertyName = nameof(CashRow.Monto_Inicial); MontoFinal.DataPropertyName = nameof(CashRow.Monto_Final); Estado.DataPropertyName = nameof(CashRow.Estado); MontoInicial.DefaultCellStyle.Format = "C2"; MontoFinal.DefaultCellStyle.Format = "C2";
    }
    private void LoadUsers()
    {
        try { using var db = CreateContext(); cmbUsuario.DataSource = new CashRegisterRepository(db).GetUsers(); cmbUsuario.DisplayMember = nameof(User.Nombre); cmbUsuario.ValueMember = nameof(User.ID_Usuario); cmbUsuario.SelectedValue = currentUserId; }
        catch (Exception ex) { ShowError(ex); }
    }
    private void LoadCashRegisters()
    {
        try { using var db = CreateContext(); dgvProductos.DataSource = new CashRegisterRepository(db).GetAll().Select(c => new CashRow(c.ID_Caja, c.User.Nombre, c.Fecha_Apertura, c.Fecha_Cierre, c.Monto_Inicial, c.Monto_Final, c.Estado.Estado, c.ID_Usuario)).ToList(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void OpenCashRegister(object? sender, EventArgs e)
    {
        if (cmbUsuario.SelectedValue is not int userId) { MessageBox.Show("Debe haber un usuario registrado para abrir caja.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (!TryAmount(txtMontoInicial.Text, out var amount)) return;
        try { using var db = CreateContext(); var openedId = new CashRegisterRepository(db).Open(userId, amount); MessageBox.Show("Caja abierta correctamente.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadCashRegisters(); SelectRow(openedId); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void SelectRow(int id)
    {
        var rowIndex = dgvProductos.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.DataBoundItem is CashRow row && row.ID_Caja == id)?.Index ?? -1;
        if (rowIndex >= 0)
        {
            dgvProductos.CurrentCell = dgvProductos.Rows[rowIndex].Cells[0];
            SelectCashRegister(dgvProductos, new DataGridViewCellEventArgs(0, rowIndex));
        }
    }

    private void SelectCashRegister(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvProductos.Rows[e.RowIndex].DataBoundItem is not CashRow row) return;
        cashRegisterId = row.ID_Caja; cmbUsuario.SelectedValue = row.ID_Usuario; cmbUsuario.Enabled = false; cmbEstado.SelectedItem = row.Estado; dtpFechaApertura.Value = row.Fecha_Apertura; dtpFechaCierre.Value = row.Fecha_Cierre ?? DateTime.Now; txtMontoInicial.Text = row.Monto_Inicial.ToString("0.00"); txtMontoFinal.Text = row.Monto_Final?.ToString("0.00") ?? string.Empty; txtMontoInicial.Enabled = false; txtMontoFinal.Enabled = !row.Fecha_Cierre.HasValue; btnGuardar.Enabled = !row.Fecha_Cierre.HasValue;
    }
    private void CloseCashRegister(object? sender, EventArgs e)
    {
        if (!cashRegisterId.HasValue) { MessageBox.Show("Seleccione una caja abierta para cerrarla.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (!TryAmount(txtMontoFinal.Text, out var amount)) return;
        try { using var db = CreateContext(); new CashRegisterRepository(db).Close(cashRegisterId.Value, amount); MessageBox.Show("Caja cerrada correctamente.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadCashRegisters(); PrepareOpening(); }
        catch (Exception ex) { ShowError(ex); }
    }
    private void PrepareOpening() { cashRegisterId = null; cmbUsuario.Enabled = false; cmbEstado.SelectedItem = "CERRADA"; txtMontoInicial.Clear(); txtMontoInicial.Enabled = true; txtMontoFinal.Clear(); txtMontoFinal.Enabled = false; dtpFechaApertura.Value = DateTime.Now; dtpFechaCierre.Value = DateTime.Now; btnGuardar.Enabled = false; dgvProductos.ClearSelection(); }
    private static bool TryAmount(string value, out decimal amount) => decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out amount) || decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
    private sealed record CashRow(int ID_Caja, string Usuario, DateTime Fecha_Apertura, DateTime? Fecha_Cierre, decimal Monto_Inicial, decimal? Monto_Final, string Estado, int ID_Usuario);
    private static void ShowError(Exception ex) => MessageBox.Show(ex.GetBaseException().Message, "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    private void CashRegisterForms_Load(object sender, EventArgs e)
    {

    }
}





