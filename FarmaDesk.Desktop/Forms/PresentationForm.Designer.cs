namespace FarmaDesk.Desktop.Forms
{
    partial class PresentationForm
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
            label2 = new Label();
            txtProducto = new TextBox();
            textPresentacion = new TextBox();
            numUnidades = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            cmbEstado = new ComboBox();
            label5 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dataGrid_Presentacion = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Presentacion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PVenta = new DataGridViewTextBoxColumn();
            Unidades = new DataGridViewTextBoxColumn();
            Estados = new DataGridViewTextBoxColumn();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Presentacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 59);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Presentación";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(50, 76);
            txtProducto.Margin = new Padding(2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(373, 23);
            txtProducto.TabIndex = 3;
            // 
            // textPresentacion
            // 
            textPresentacion.Location = new Point(472, 76);
            textPresentacion.Margin = new Padding(2);
            textPresentacion.Name = "textPresentacion";
            textPresentacion.Size = new Size(373, 23);
            textPresentacion.TabIndex = 4;
            // 
            // numUnidades
            // 
            numUnidades.Location = new Point(472, 145);
            numUnidades.Margin = new Padding(2);
            numUnidades.Name = "numUnidades";
            numUnidades.Size = new Size(240, 23);
            numUnidades.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 128);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 9;
            label3.Text = "Unidades";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 128);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 10;
            label4.Text = "Precio venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 145);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 23);
            textBox1.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(50, 202);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(373, 23);
            cmbEstado.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 185);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 15;
            label5.Text = "Estados";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(752, 201);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(660, 201);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(566, 201);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(475, 202);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Presentacion
            // 
            dataGrid_Presentacion.BackgroundColor = Color.White;
            dataGrid_Presentacion.BorderStyle = BorderStyle.None;
            dataGrid_Presentacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Presentacion.Columns.AddRange(new DataGridViewColumn[] { ID, Presentacion, Categoria, PVenta, Unidades, Estados });
            dataGrid_Presentacion.Location = new Point(26, 275);
            dataGrid_Presentacion.Name = "dataGrid_Presentacion";
            dataGrid_Presentacion.Size = new Size(892, 249);
            dataGrid_Presentacion.TabIndex = 24;
            dataGrid_Presentacion.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // Presentacion
            // 
            Presentacion.HeaderText = "Presentacion";
            Presentacion.Name = "Presentacion";
            Presentacion.Width = 250;
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
            // Unidades
            // 
            Unidades.HeaderText = "Unidades";
            Unidades.Name = "Unidades";
            Unidades.Width = 90;
            // 
            // Estados
            // 
            Estados.HeaderText = "Estados";
            Estados.Name = "Estados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(311, 9);
            label6.Name = "label6";
            label6.Size = new Size(321, 30);
            label6.TabIndex = 43;
            label6.Text = "GESTIÓN DE PRESENTACIONES";
            // 
            // PresentationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 560);
            Controls.Add(label6);
            Controls.Add(dataGrid_Presentacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label5);
            Controls.Add(cmbEstado);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numUnidades);
            Controls.Add(textPresentacion);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PresentationForm";
            Text = "PresentationForm";
            ((System.ComponentModel.ISupportInitialize)numUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Presentacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProducto;
        private TextBox textPresentacion;
        private NumericUpDown numUnidades;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox cmbEstado;
        private Label label5;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dataGrid_Presentacion;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Presentacion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PVenta;
        private DataGridViewTextBoxColumn Unidades;
        private DataGridViewTextBoxColumn Estados;
        private Label label6;
    }
}