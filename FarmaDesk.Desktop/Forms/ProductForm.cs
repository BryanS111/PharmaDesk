using FarmaDesk.BusinessLogic;
using FarmaDesk.Entity;

namespace FarmaDesk.Desktop.Forms.Productos;

public partial class ProductForm : Form
{
    private readonly ProductRepository productRepository;
    private readonly CategoriaRepository categoryRepository;
    private readonly EstadoRepository stateRepository;
    private int? selectedProductId;

    private void label2_Click(object? sender, EventArgs e) { }

    private void label3_Click(object? sender, EventArgs e) { }

    public ProductForm(ProductRepository productRepository, CategoriaRepository categoryRepository, EstadoRepository stateRepository)
    {
        InitializeComponent();
        this.productRepository = productRepository;
        this.categoryRepository = categoryRepository;
        this.stateRepository = stateRepository;
        Load += ProductForm_Load;
        btnNuevo.Click += (_, _) => ClearForm();
        btnLimpiar.Click += (_, _) => ClearForm();
        btnGuardar.Click += btnGuardar_Click;
        btnEliminar.Click += btnEliminar_Click;
        dgvProductos.CellClick += dgvProductos_CellClick;
        txtBuscar.TextChanged += (_, _) => LoadProducts();
        btnEliminar.Enabled = false;
    }

    private void ProductForm_Load(object? sender, EventArgs e)
    {
        LoadCategories();
        LoadStates();
        LoadProducts();
        ClearForm();
    }

    private void LoadCategories()
    {
        cmbCategoria.DataSource = categoryRepository.GetAll();
        cmbCategoria.DisplayMember = nameof(CategoriaEntity.Categoria);
        cmbCategoria.ValueMember = nameof(CategoriaEntity.ID_Categoria);
    }

    private void LoadStates()
    {
        cmbEstado.DataSource = stateRepository.GetAll();
        cmbEstado.DisplayMember = nameof(EstadoEntity.Estado);
        cmbEstado.ValueMember = nameof(EstadoEntity.ID_Estado);
        cmbEstado.SelectedValue = EstadoIds.Activo;
    }

    private void LoadProducts()
    {
        var search = txtBuscar.Text.Trim();
        var products = productRepository.GetAll()
            .Where(product => string.IsNullOrWhiteSpace(search) || product.Producto.Contains(search, StringComparison.OrdinalIgnoreCase))
            .Select(product => new
            {
                product.ID_Producto,
                product.Producto,
                Categoria = product.Categoria?.Categoria ?? string.Empty,
                Stock = product.Stock_Minimo
            }).ToList();

        ID.DataPropertyName = nameof(ProductoEntity.ID_Producto);
        Nombre.DataPropertyName = nameof(ProductoEntity.Producto);
        Categoria.DataPropertyName = "Categoria";
        Stock.DataPropertyName = "Stock";
        dgvProductos.AutoGenerateColumns = false;
        dgvProductos.DataSource = products;
    }

    private void dgvProductos_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var value = dgvProductos.Rows[e.RowIndex].Cells[nameof(ID)].Value;
        if (value is null || !int.TryParse(value.ToString(), out var id)) return;

        var product = productRepository.GetById(id);
        if (product is null) return;

        selectedProductId = product.ID_Producto;
        txtNombre.Text = product.Producto;
        txtDescripcion.Text = product.Descripcion ?? string.Empty;
        cmbCategoria.SelectedValue = product.ID_Categoria;
        numStockMinimo.Value = product.Stock_Minimo;
        cmbEstado.SelectedValue = product.ID_Estado;
        btnEliminar.Enabled = true;
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cmbCategoria.SelectedValue is null || cmbEstado.SelectedValue is null)
            {
                MessageBox.Show("Debe seleccionar una categoría y un estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new ProductoEntity
            {
                ID_Producto = selectedProductId ?? 0,
                ID_Categoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                Producto = txtNombre.Text.Trim(),
                Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim(),
                Stock_Minimo = Convert.ToInt32(numStockMinimo.Value),
                ID_Estado = Convert.ToInt32(cmbEstado.SelectedValue)
            };

            if (selectedProductId.HasValue)
            {
                productRepository.Update(product);
                MessageBox.Show("Producto actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                productRepository.Insert(product);
                MessageBox.Show("Producto guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadProducts();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se pudo guardar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (!selectedProductId.HasValue) return;
        var answer = MessageBox.Show("El registro no se eliminará físicamente. ¿Desea marcarlo como inactivo?", "Confirmar borrado lógico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (answer != DialogResult.Yes) return;

        try
        {
            productRepository.Deactivate(selectedProductId.Value);
            LoadProducts();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se pudo desactivar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearForm()
    {
        selectedProductId = null;
        txtNombre.Clear();
        txtDescripcion.Clear();
        numStockMinimo.Value = 0;
        if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
        if (cmbEstado.Items.Count > 0) cmbEstado.SelectedValue = EstadoIds.Activo;
        dgvProductos.ClearSelection();
        btnEliminar.Enabled = false;
        txtNombre.Focus();
    }

    private void ProductForm_Load_1(object sender, EventArgs e)
    {

    }
}
