namespace FarmaDesk.Desktop.Forms.Productos
{
    partial class ProductosForm
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            cmbCategoria = new ComboBox();
            label4 = new Label();
            numStockMinimo = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            label7 = new Label();
            cmbEstado = new ComboBox();
            txtBuscar = new TextBox();
            label8 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 43);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(406, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "DESCRIPCION:";
            label2.Click += label2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(33, 91);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(406, 69);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "CATEGORIA:";
            label3.Click += label3_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(33, 188);
            cmbCategoria.Margin = new Padding(2, 2, 2, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(192, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 172);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 15);
            label4.TabIndex = 6;
            label4.Text = "HUMBRAL DE STOCK MINIMO:";
            // 
            // numStockMinimo
            // 
            numStockMinimo.Location = new Point(246, 189);
            numStockMinimo.Margin = new Padding(2, 2, 2, 2);
            numStockMinimo.Name = "numStockMinimo";
            numStockMinimo.Size = new Size(190, 23);
            numStockMinimo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 220);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "PRECIO COMPRA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 220);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 9;
            label6.Text = "PRECIO VENTA:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(33, 242);
            txtPrecioCompra.Margin = new Padding(2, 2, 2, 2);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(192, 23);
            txtPrecioCompra.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(246, 242);
            txtPrecioVenta.Margin = new Padding(2, 2, 2, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(192, 23);
            txtPrecioVenta.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 26);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 12;
            label7.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(468, 43);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(352, 23);
            cmbEstado.TabIndex = 13;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(468, 111);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese el nombre de Producto a buscar";
            txtBuscar.Size = new Size(352, 23);
            txtBuscar.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 94);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 15;
            label8.Text = "BUSCAR:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(470, 242);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(561, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(655, 241);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(745, 241);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, PVenta, Stock });
            dataGridView1.Location = new Point(33, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 249);
            dataGridView1.TabIndex = 20;
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
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // PVenta
            // 
            PVenta.HeaderText = "Precio Venta";
            PVenta.Name = "PVenta";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Width = 90;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 548);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numStockMinimo);
            Controls.Add(label4);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ProductosForm";
            Text = "PRODUCTOS - CRUD";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private ComboBox cmbCategoria;
        private Label label4;
        private NumericUpDown numStockMinimo;
        private Label label5;
        private Label label6;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private Label label7;
        private ComboBox cmbEstado;
        private TextBox txtBuscar;
        private Label label8;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PVenta;
        private DataGridViewTextBoxColumn Stock;
    }
}