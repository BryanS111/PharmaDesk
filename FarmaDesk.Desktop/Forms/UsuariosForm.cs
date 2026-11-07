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
    public partial class UsuariosForm : Form
    {
        private readonly UserRepository _services;
        private readonly RoleRepository _servicesRol;
        private readonly EstadoRepository _servicesEstado;
        List<User> _listUsuarios;
        private int _idSeleccionado = 0;

        public UsuariosForm(UserRepository repo, RoleRepository repoRol, EstadoRepository repoEstado)
        {
            InitializeComponent();
            _services = repo;
            _servicesRol = repoRol;
            _servicesEstado = repoEstado;
        }
        private void UpdateGrid()
        {
            _listUsuarios = _services.GetAll();

            var query = (from x in _listUsuarios
                         select new
                         {
                             Id = x.ID_Usuario,
                             Nombre = x.Nombre,
                             Usuario = x.Usuario,
                             Rol = x.Rol.Rol,
                             Estado = x.Estado.Estado
                         }).ToList();

            dgvUsuarios.DataSource = query;
        }

        private void UsuariosForm_Load_1(object sender, EventArgs e)
        {
            cmbRol.DataSource = _servicesRol.GetAll();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "ID_Rol";
            cmbRol.SelectedIndex = -1;

            cmbEstado.DataSource = _servicesEstado.GetAll();
            cmbEstado.DisplayMember = "Estado";
            cmbEstado.ValueMember = "ID_Estado";
            cmbEstado.SelectedIndex = -1;

            UpdateGrid();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            textUsuario.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            textUsuario.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dgvUsuarios.ClearSelection();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRol.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un rol.");
                    return;
                }

                if (_idSeleccionado == 0)
                {
                    var usuario = new User
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Usuario = textUsuario.Text.Trim(),
                        Clave = txtClave.Text.Trim(),
                        ID_Rol = Convert.ToInt32(cmbRol.SelectedValue)
                    };

                    _services.Insert(usuario);
                    MessageBox.Show("Usuario guardado correctamente.");
                }
                else
                {
                    var usuario = _services.GetById(_idSeleccionado);
                    if (usuario == null)
                    {
                        MessageBox.Show("Usuario no encontrado.");
                        return;
                    }

                    usuario.Nombre = txtNombre.Text.Trim();
                    usuario.Usuario = textUsuario.Text.Trim();
                    usuario.Clave = txtClave.Text.Trim();
                    usuario.ID_Rol = Convert.ToInt32(cmbRol.SelectedValue);

                    if (cmbEstado.SelectedValue != null)
                        usuario.ID_Estado = Convert.ToInt32(cmbEstado.SelectedValue);

                    _services.Update(usuario);
                    MessageBox.Show("Usuario actualizado correctamente.");
                }

                UpdateGrid();
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvUsuarios.Rows[e.RowIndex];
            _idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            var usuario = _services.GetById(_idSeleccionado);
            if (usuario == null) return;

            txtNombre.Text = usuario.Nombre;
            textUsuario.Text = usuario.Usuario;
            txtClave.Text = usuario.Clave;
            cmbRol.SelectedValue = usuario.ID_Rol;
            cmbEstado.SelectedValue = usuario.ID_Estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la tabla.");
                return;
            }

            var respuesta = MessageBox.Show(
                "¿Desea desactivar este usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                _services.Deactivate(_idSeleccionado);
                MessageBox.Show("Usuario desactivado correctamente.");

                UpdateGrid();
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
