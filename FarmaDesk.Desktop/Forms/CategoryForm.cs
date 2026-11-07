using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaDesk.BusinessLogic;
using FarmaDesk.Entity;

namespace FarmaDesk.Desktop.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoriaRepository categoryRepository;
        private readonly EstadoRepository stateRepository;
        private int? selectedCategoryId;

        public CategoryForm(CategoriaRepository categoryRepository, EstadoRepository stateRepository)
        {
            InitializeComponent();
            this.categoryRepository = categoryRepository;
            this.stateRepository = stateRepository;
            Load += CategoryForm_Load;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnEliminar.Click += btnEliminar_Click;
            dataGrid_Categoria.CellClick += dataGrid_Categoria_CellClick;
            btnEliminar.Enabled = false;
        }

        private void CategoryForm_Load(object? sender, EventArgs e)
        {
            LoadStates();
            LoadCategories();
            ClearForm();
        }

        private void LoadStates()
        {
            cmbEstado.DataSource = stateRepository.GetAll();
            cmbEstado.DisplayMember = nameof(EstadoEntity.Estado);
            cmbEstado.ValueMember = nameof(EstadoEntity.ID_Estado);
            cmbEstado.SelectedValue = EstadoIds.Activo;
        }

        private void LoadCategories()
        {
            var categories = categoryRepository.GetAll()
                .Select(category => new
                {
                    category.ID_Categoria,
                    category.Categoria,
                    category.Descripcion,
                    ID_Estado = category.ID_Estado,
                    Estado = category.Estado?.Estado ?? string.Empty
                })
                .ToList();

            Id.DataPropertyName = nameof(CategoriaEntity.ID_Categoria);
            Categoria.DataPropertyName = nameof(CategoriaEntity.Categoria);
            Descripcion.DataPropertyName = nameof(CategoriaEntity.Descripcion);
            Estado.DataPropertyName = "Estado";
            dataGrid_Categoria.AutoGenerateColumns = false;
            dataGrid_Categoria.DataSource = categories;
        }

        private void dataGrid_Categoria_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var idValue = dataGrid_Categoria.Rows[e.RowIndex].Cells[nameof(Id)].Value;
            if (idValue is null || !int.TryParse(idValue.ToString(), out var id)) return;

            var category = categoryRepository.GetById(id);
            if (category is null) return;

            selectedCategoryId = category.ID_Categoria;
            txtCategoria.Text = category.Categoria;
            textDescripcion.Text = category.Descripcion ?? string.Empty;
            cmbEstado.SelectedValue = category.ID_Estado;
            btnEliminar.Enabled = true;
        }

        private void btnNuevo_Click(object? sender, EventArgs e) => ClearForm();

        private void btnLimpiar_Click(object? sender, EventArgs e) => ClearForm();

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("La categoría es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoria.Focus();
                    return;
                }

                var stateId = Convert.ToInt32(cmbEstado.SelectedValue);
                var category = new CategoriaEntity
                {
                    ID_Categoria = selectedCategoryId ?? 0,
                    Categoria = txtCategoria.Text.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(textDescripcion.Text) ? null : textDescripcion.Text.Trim(),
                    ID_Estado = stateId
                };

                if (selectedCategoryId.HasValue)
                {
                    categoryRepository.Update(category);
                    MessageBox.Show("Categoría actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    categoryRepository.Insert(category);
                    MessageBox.Show("Categoría guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadCategories();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar la categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (!selectedCategoryId.HasValue) return;

            var answer = MessageBox.Show(
                "El registro no se eliminará físicamente. ¿Desea marcarlo como inactivo?",
                "Confirmar borrado lógico",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes) return;

            try
            {
                categoryRepository.Deactivate(selectedCategoryId.Value);
                LoadCategories();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo desactivar la categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedCategoryId = null;
            txtCategoria.Clear();
            textDescripcion.Clear();
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedValue = EstadoIds.Activo;
            dataGrid_Categoria.ClearSelection();
            btnEliminar.Enabled = false;
            txtCategoria.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
