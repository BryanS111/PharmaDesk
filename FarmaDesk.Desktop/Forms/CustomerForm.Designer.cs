namespace FarmaDesk.Desktop.Forms
{
    partial class CustomerForm
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
            dataGrid_Presentacion = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textPresentacion = new TextBox();
            txtProducto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            txtDireccion = new TextBox();
            label6 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Presentacion).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Presentacion
            // 
            dataGrid_Presentacion.BackgroundColor = Color.White;
            dataGrid_Presentacion.BorderStyle = BorderStyle.None;
            dataGrid_Presentacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Presentacion.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Telefono, Documento, Direccion, Estado });
            dataGrid_Presentacion.Location = new Point(18, 312);
            dataGrid_Presentacion.Name = "dataGrid_Presentacion";
            dataGrid_Presentacion.Size = new Size(892, 249);
            dataGrid_Presentacion.TabIndex = 39;
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
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(734, 244);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(644, 244);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 37;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(459, 245);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 35;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 181);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 34;
            label5.Text = "Direccion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 141);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 23);
            textBox1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 124);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 31;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 124);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 30;
            label3.Text = "Documento";
            // 
            // textPresentacion
            // 
            textPresentacion.Location = new Point(458, 72);
            textPresentacion.Margin = new Padding(2);
            textPresentacion.Name = "textPresentacion";
            textPresentacion.Size = new Size(373, 23);
            textPresentacion.TabIndex = 28;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(36, 72);
            txtProducto.Margin = new Padding(2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(373, 23);
            txtProducto.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 55);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 26;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 25;
            label1.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(458, 141);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 23);
            textBox2.TabIndex = 40;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(36, 198);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(373, 69);
            txtDireccion.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 9);
            label6.Name = "label6";
            label6.Size = new Size(228, 30);
            label6.TabIndex = 42;
            label6.Text = "GESTIÓN DE CLENTES";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(458, 201);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(154, 23);
            cmbEstado.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(454, 184);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 43;
            label7.Text = "Estado";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 590);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(textBox2);
            Controls.Add(dataGrid_Presentacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textPresentacion);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dataGrid_Presentacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Presentacion;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TextBox textPresentacion;
        private TextBox txtProducto;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox txtDireccion;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private Label label6;
        private ComboBox cmbEstado;
        private Label label7;
        private DataGridViewTextBoxColumn Estado;
    }
}
