using FarmaDesk.BusinessLogic;
using FarmaDesk.Entity;

namespace FarmaDesk.Desktop.Forms;

public partial class PresentationForm : Form
{
    private readonly PresentationRepository presentationRepository;
    private readonly ProductRepository productRepository;
    private readonly EstadoRepository stateRepository;
    private int? selectedPresentationId;

    public PresentationForm(PresentationRepository presentationRepository, ProductRepository productRepository, EstadoRepository stateRepository)
    {
        InitializeComponent();
        this.presentationRepository = presentationRepository;
        this.productRepository = productRepository;
        this.stateRepository = stateRepository;

        Load += PresentationForm_Load;
        btnNuevo.Click += (_, _) => ClearForm();
        btnLimpiar.Click += (_, _) => ClearForm();
        btnGuardar.Click += btnGuardar_Click;
        btnEliminar.Click += btnEliminar_Click;
        dataGrid_Presentacion.CellClick += dataGrid_Presentacion_CellClick;
        btnEliminar.Enabled = false;
    }

    private void PresentationForm_Load(object? sender, EventArgs e)
    {
        LoadProducts();
        LoadStates();
        LoadPresentations();
        ClearForm();
    }

    private void LoadProducts()
    {
        txtProducto.DataSource = productRepository.GetAll();
        txtProducto.DisplayMember = nameof(ProductoEntity.Producto);
        txtProducto.ValueMember = nameof(ProductoEntity.ID_Producto);
    }

    private void LoadStates()
    {
        cmbEstado.DataSource = stateRepository.GetAll();
        cmbEstado.DisplayMember = nameof(EstadoEntity.Estado);
        cmbEstado.ValueMember = nameof(EstadoEntity.ID_Estado);
        cmbEstado.SelectedValue = EstadoIds.Activo;
    }

    private void LoadPresentations()
    {
        var presentations = presentationRepository.GetAll()
            .Select(presentation => new
            {
                presentation.ID_Presentacion,
                presentation.Presentacion,
                Categoria = presentation.Producto?.Producto ?? string.Empty,
                PVenta = presentation.Precio_Venta,
                Unidades = presentation.Unidades_Equivalentes,
                Estado = presentation.Estado?.Estado ?? string.Empty
            })
            .ToList();

        ID.DataPropertyName = nameof(PresentacionesEntity.ID_Presentacion);
        Presentacion.DataPropertyName = nameof(PresentacionesEntity.Presentacion);
        Categoria.DataPropertyName = "Categoria";
        PVenta.DataPropertyName = "PVenta";
        Unidades.DataPropertyName = "Unidades";
        Estado.DataPropertyName = "Estado";
        dataGrid_Presentacion.AutoGenerateColumns = false;
        dataGrid_Presentacion.DataSource = presentations;
    }

    private void dataGrid_Presentacion_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var value = dataGrid_Presentacion.Rows[e.RowIndex].Cells[nameof(ID)].Value;
        if (value is null || !int.TryParse(value.ToString(), out var id)) return;

        var presentation = presentationRepository.GetById(id);
        if (presentation is null) return;

        selectedPresentationId = presentation.ID_Presentacion;
        txtProducto.SelectedValue = presentation.ID_Producto;
        textPresentacion.Text = presentation.Presentacion;
        textBox1.Text = presentation.Precio_Venta.ToString("0.00");
        numUnidades.Value = presentation.Unidades_Equivalentes;
        cmbEstado.SelectedValue = presentation.ID_Estado;
        btnEliminar.Enabled = true;
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        try
        {
            if (txtProducto.SelectedValue is null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textPresentacion.Text))
            {
                MessageBox.Show("La presentación es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPresentacion.Focus();
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out var salePrice) || salePrice < 0)
            {
                MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numUnidades.Value <= 0 || cmbEstado.SelectedValue is null)
            {
                MessageBox.Show("Las unidades deben ser mayores que cero y debe seleccionar un estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var presentation = new PresentacionesEntity
            {
                ID_Presentacion = selectedPresentationId ?? 0,
                ID_Producto = Convert.ToInt32(txtProducto.SelectedValue),
                Presentacion = textPresentacion.Text.Trim(),
                Unidades_Equivalentes = Convert.ToInt32(numUnidades.Value),
                Precio_Venta = salePrice,
                ID_Estado = Convert.ToInt32(cmbEstado.SelectedValue)
            };

            if (selectedPresentationId.HasValue)
            {
                presentationRepository.Update(presentation);
                MessageBox.Show("Presentación actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                presentationRepository.Insert(presentation);
                MessageBox.Show("Presentación guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadPresentations();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se pudo guardar la presentación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (!selectedPresentationId.HasValue) return;
        var answer = MessageBox.Show("El registro no se eliminará físicamente. ¿Desea marcarlo como inactivo?", "Confirmar borrado lógico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (answer != DialogResult.Yes) return;

        try
        {
            presentationRepository.Deactivate(selectedPresentationId.Value);
            LoadPresentations();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se pudo desactivar la presentación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearForm()
    {
        selectedPresentationId = null;
        textPresentacion.Clear();
        textBox1.Clear();
        numUnidades.Value = 0;
        if (txtProducto.Items.Count > 0) txtProducto.SelectedIndex = 0;
        if (cmbEstado.Items.Count > 0) cmbEstado.SelectedValue = EstadoIds.Activo;
        dataGrid_Presentacion.ClearSelection();
        btnEliminar.Enabled = false;
        textPresentacion.Focus();
    }

    private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e) { }
}
