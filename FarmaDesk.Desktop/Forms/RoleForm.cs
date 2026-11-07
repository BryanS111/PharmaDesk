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
    public partial class RoleForm : Form
    {
        private readonly RoleRepository _services;
        List<Role> _listRoles;
        private int _idSeleccionado = 0;

        public RoleForm(RoleRepository repo)
        {
            InitializeComponent();
            _services = repo;
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listRoles = _services.GetAll();

            var query = (from x in _listRoles
                         select new
                         {
                             Id = x.ID_Rol,
                             Rol = x.Rol,
                             Descripcion = x.Descripcion,
                             Estado = x.Estado.Estado
                         }).ToList();

            dataGrid_Rol.DataSource = query;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idSeleccionado = 0;
            txtRol.Clear();
            textDescripcion.Clear();
            dataGrid_Rol.ClearSelection();
            txtRol.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idSeleccionado = 0;
            txtRol.Clear();
            textDescripcion.Clear();
            txtRol.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    var rol = new Role
                    {
                        Rol = txtRol.Text.Trim(),
                        Descripcion = string.IsNullOrWhiteSpace(textDescripcion.Text) ? null : textDescripcion.Text.Trim()
                    };

                    _services.Insert(rol);
                    MessageBox.Show("Rol guardado correctamente.");
                }
                else
                {
                    var rol = _services.GetById(_idSeleccionado);
                    if (rol == null)
                    {
                        MessageBox.Show("Rol no encontrado.");
                        return;
                    }

                    rol.Rol = txtRol.Text.Trim();
                    rol.Descripcion = string.IsNullOrWhiteSpace(textDescripcion.Text) ? null : textDescripcion.Text.Trim();

                    _services.Update(rol);
                    MessageBox.Show("Rol actualizado correctamente.");
                }

                UpdateGrid();
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un rol de la tabla.");
                return;
            }

            var respuesta = MessageBox.Show(
                "¿Desea desactivar este rol?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                _services.Deactivate(_idSeleccionado);
                MessageBox.Show("Rol desactivado correctamente.");

                UpdateGrid();
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_Rol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGrid_Rol.Rows[e.RowIndex];
            _idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            var rol = _services.GetById(_idSeleccionado);
            if (rol == null) return;

            txtRol.Text = rol.Rol;
            textDescripcion.Text = rol.Descripcion ?? "";
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
