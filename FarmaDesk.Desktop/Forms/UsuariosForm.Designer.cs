namespace FarmaDesk.Desktop.Forms
{
    partial class UsuariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            label1 = new Label();
            textUsuario = new TextBox();
            label2 = new Label();
            cmbRol = new ComboBox();
            label3 = new Label();
            cmbEstado = new ComboBox();
            label4 = new Label();
            txtClave = new TextBox();
            label5 = new Label();
            dgvUsuarios = new DataGridView();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 31);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(406, 23);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "NOMBRE:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(443, 31);
            textUsuario.Margin = new Padding(2);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(226, 23);
            textUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "USUARIO:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(21, 90);
            cmbRol.Margin = new Padding(2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(192, 23);
            cmbRol.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "ROL:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(233, 90);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(192, 23);
            cmbEstado.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 74);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "ESTADO:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(443, 91);
            txtClave.Margin = new Padding(2);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(226, 23);
            txtClave.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 74);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "CLAVE:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, PVenta, Stock, Clave });
            dgvUsuarios.Location = new Point(21, 176);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(887, 249);
            dgvUsuarios.TabIndex = 25;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(844, 14);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(833, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(742, 148);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 250;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Usuario";
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // PVenta
            // 
            PVenta.HeaderText = "Rol";
            PVenta.Name = "PVenta";
            // 
            // Stock
            // 
            Stock.HeaderText = "Estado";
            Stock.Name = "Stock";
            Stock.Width = 90;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 528);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(cmbEstado);
            Controls.Add(label4);
            Controls.Add(cmbRol);
            Controls.Add(label3);
            Controls.Add(textUsuario);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private TextBox textUsuario;
        private Label label2;
        private ComboBox cmbRol;
        private Label label3;
        private ComboBox cmbEstado;
        private Label label4;
        private TextBox txtClave;
        private Label label5;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Clave;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}