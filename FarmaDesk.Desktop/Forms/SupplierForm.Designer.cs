namespace FarmaDesk.Desktop.Forms
{
    partial class SupplierForm
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
            dataGrid_Proveedor = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            NIT = new DataGridViewTextBoxColumn();
            NRC = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label8 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            txtNRC = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtProveedor = new TextBox();
            label1 = new Label();
            textCorreo = new TextBox();
            textNIT = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Proveedor).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Proveedor
            // 
            dataGrid_Proveedor.BackgroundColor = Color.White;
            dataGrid_Proveedor.BorderStyle = BorderStyle.None;
            dataGrid_Proveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Proveedor.Columns.AddRange(new DataGridViewColumn[] { ID, Proveedor, Telefono, Direccion, Correo, Estado, NIT, NRC });
            dataGrid_Proveedor.Location = new Point(40, 288);
            dataGrid_Proveedor.Name = "dataGrid_Proveedor";
            dataGrid_Proveedor.Size = new Size(853, 249);
            dataGrid_Proveedor.TabIndex = 41;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            // 
            // Correo
            // 
            Correo.HeaderText = "Corro";
            Correo.Name = "Correo";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // NIT
            // 
            NIT.HeaderText = "NIT";
            NIT.Name = "NIT";
            // 
            // NRC
            // 
            NRC.HeaderText = "NRC";
            NRC.Name = "NRC";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(800, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(710, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(616, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(525, 221);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 37;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(567, 105);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 36;
            label8.Text = "Correo";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(565, 168);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(192, 23);
            cmbEstado.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 57);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 33;
            label7.Text = "Teléfono";
            // 
            // txtNRC
            // 
            txtNRC.Location = new Point(293, 220);
            txtNRC.Margin = new Padding(2);
            txtNRC.Name = "txtNRC";
            txtNRC.Size = new Size(192, 23);
            txtNRC.TabIndex = 32;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(567, 74);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(192, 23);
            txtTelefono.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 145);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 203);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 27;
            label4.Text = "NRC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 25;
            label3.Text = "NIT";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(80, 122);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(406, 69);
            txtDireccion.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 23;
            label2.Text = "Dirección";
            label2.Click += label2_Click;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(80, 74);
            txtProveedor.Margin = new Padding(2);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(406, 23);
            txtProveedor.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 21;
            label1.Text = "Proveedor";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(565, 122);
            textCorreo.Margin = new Padding(2);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(194, 23);
            textCorreo.TabIndex = 42;
            // 
            // textNIT
            // 
            textNIT.Location = new Point(80, 219);
            textNIT.Margin = new Padding(2);
            textNIT.Name = "textNIT";
            textNIT.Size = new Size(192, 23);
            textNIT.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 9);
            label6.Name = "label6";
            label6.Size = new Size(288, 30);
            label6.TabIndex = 44;
            label6.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 549);
            Controls.Add(label6);
            Controls.Add(textNIT);
            Controls.Add(textCorreo);
            Controls.Add(dataGrid_Proveedor);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label8);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(txtNRC);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtProveedor);
            Controls.Add(label1);
            Name = "SupplierForm";
            Text = "SupplierForm1";
            ((System.ComponentModel.ISupportInitialize)dataGrid_Proveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Proveedor;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label8;
        private ComboBox cmbEstado;
        private Label label7;
        private TextBox txtNRC;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtProveedor;
        private Label label1;
        private TextBox textCorreo;
        private TextBox textNIT;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn NIT;
        private DataGridViewTextBoxColumn NRC;
        private Label label6;
    }
}