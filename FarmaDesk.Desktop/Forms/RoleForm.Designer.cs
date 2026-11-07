namespace FarmaDesk.Desktop.Forms
{
    partial class RoleForm
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
            dataGrid_Rol = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            textDescripcion = new TextBox();
            txtRol = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Rol).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Rol
            // 
            dataGrid_Rol.BackgroundColor = Color.White;
            dataGrid_Rol.BorderStyle = BorderStyle.None;
            dataGrid_Rol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Rol.Columns.AddRange(new DataGridViewColumn[] { Id, Rol, Descripcion });
            dataGrid_Rol.Location = new Point(106, 213);
            dataGrid_Rol.Name = "dataGrid_Rol";
            dataGrid_Rol.Size = new Size(708, 214);
            dataGrid_Rol.TabIndex = 30;
            dataGrid_Rol.CellContentClick += dataGrid_Rol_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(761, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(761, 83);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(652, 136);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(652, 82);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(208, 133);
            textDescripcion.Margin = new Padding(2);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(406, 23);
            textDescripcion.TabIndex = 25;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(208, 83);
            txtRol.Margin = new Padding(2);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(406, 23);
            txtRol.TabIndex = 24;
            txtRol.TextChanged += txtRol_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 136);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 91);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 22;
            label3.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 24);
            label6.Name = "label6";
            label6.Size = new Size(205, 30);
            label6.TabIndex = 44;
            label6.Text = "GESTIÓN DE ROLES";
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 526);
            Controls.Add(label6);
            Controls.Add(dataGrid_Rol);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(textDescripcion);
            Controls.Add(txtRol);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "RoleForm";
            Text = "RoleForm";
            ((System.ComponentModel.ISupportInitialize)dataGrid_Rol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Rol;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox textDescripcion;
        private TextBox txtRol;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Descripcion;
        private Label label6;
    }
}