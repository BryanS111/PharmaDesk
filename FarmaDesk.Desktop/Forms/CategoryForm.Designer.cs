namespace FarmaDesk.Desktop.Forms
{
    partial class CategoryForm
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
            label3 = new Label();
            label4 = new Label();
            txtCategoria = new TextBox();
            textDescripcion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dataGrid_Categoria = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbEstado = new ComboBox();
            label2 = new Label();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Categoria).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 107);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 152);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(203, 99);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(406, 23);
            txtCategoria.TabIndex = 4;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(203, 149);
            textDescripcion.Margin = new Padding(2);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(406, 23);
            textDescripcion.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(647, 98);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(647, 152);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(756, 99);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(756, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Categoria
            // 
            dataGrid_Categoria.BackgroundColor = Color.White;
            dataGrid_Categoria.BorderStyle = BorderStyle.None;
            dataGrid_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Categoria.Columns.AddRange(new DataGridViewColumn[] { Id, Categoria, Descripcion, Estado });
            dataGrid_Categoria.Location = new Point(101, 229);
            dataGrid_Categoria.Name = "dataGrid_Categoria";
            dataGrid_Categoria.Size = new Size(708, 214);
            dataGrid_Categoria.TabIndex = 21;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 33);
            label1.Name = "label1";
            label1.Size = new Size(482, 30);
            label1.TabIndex = 22;
            label1.Text = "GESTIÓN DE CATEGORÍAS DE MEDICAMENTOS ";
            label1.Click += label1_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(203, 187);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(154, 23);
            cmbEstado.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 190);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 23;
            label2.Text = "Estado";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 529);
            Controls.Add(cmbEstado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGrid_Categoria);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(textDescripcion);
            Controls.Add(txtCategoria);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "CategoryForm";
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)dataGrid_Categoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox txtCategoria;
        private TextBox textDescripcion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dataGrid_Categoria;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Descripcion;
        private Label label1;
        private ComboBox cmbEstado;
        private Label label2;
        private DataGridViewTextBoxColumn Estado;
    }
}