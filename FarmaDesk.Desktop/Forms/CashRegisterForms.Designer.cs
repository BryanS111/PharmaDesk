namespace FarmaDesk.Desktop.Forms
{
    partial class CashRegisterForms
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
            label2 = new Label();
            cmbUsuario = new ComboBox();
            label1 = new Label();
            dtpFechaApertura = new DateTimePicker();
            txtMontoInicial = new TextBox();
            label3 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            dtpFechaCierre = new DateTimePicker();
            label4 = new Label();
            txtMontoFinal = new TextBox();
            label5 = new Label();
            dgvProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Apertura = new DataGridViewTextBoxColumn();
            Cierre = new DataGridViewTextBoxColumn();
            MontoInicial = new DataGridViewTextBoxColumn();
            MontoFinal = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "USUARIO:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Enabled = false;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(36, 41);
            cmbUsuario.Margin = new Padding(2);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(192, 23);
            cmbUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 8;
            label1.Text = "FECHA APERTURA:";
            // 
            // dtpFechaApertura
            // 
            dtpFechaApertura.Enabled = false;
            dtpFechaApertura.Location = new Point(271, 42);
            dtpFechaApertura.Name = "dtpFechaApertura";
            dtpFechaApertura.Size = new Size(241, 23);
            dtpFechaApertura.TabIndex = 9;
            // 
            // txtMontoInicial
            // 
            txtMontoInicial.Location = new Point(36, 94);
            txtMontoInicial.Margin = new Padding(2);
            txtMontoInicial.Name = "txtMontoInicial";
            txtMontoInicial.PlaceholderText = "0.00";
            txtMontoInicial.Size = new Size(192, 23);
            txtMontoInicial.TabIndex = 11;
            // 
            // label3
            // 
            label3.AccessibleDescription = "";
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.Location = new Point(36, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "MONTO INICIAL:";
            // 
            // cmbEstado
            // 
            cmbEstado.Enabled = false;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(271, 94);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(241, 23);
            cmbEstado.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 77);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 14;
            label7.Text = "ESTADO:";
            // 
            // dtpFechaCierre
            // 
            dtpFechaCierre.Enabled = false;
            dtpFechaCierre.Location = new Point(36, 153);
            dtpFechaCierre.Name = "dtpFechaCierre";
            dtpFechaCierre.Size = new Size(241, 23);
            dtpFechaCierre.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 16;
            label4.Text = "FECHA CIERRE:";
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.Location = new Point(318, 152);
            txtMontoFinal.Margin = new Padding(2);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.PlaceholderText = "0.00";
            txtMontoFinal.Size = new Size(192, 23);
            txtMontoFinal.TabIndex = 19;
            // 
            // label5
            // 
            label5.AccessibleDescription = "";
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.Location = new Point(318, 135);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 18;
            label5.Text = "MONTO FINAL:";
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Usuario, Apertura, Cierre, MontoInicial, MontoFinal, Estado });
            dgvProductos.Location = new Point(4, 236);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(778, 249);
            dgvProductos.TabIndex = 21;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.Width = 150;
            // 
            // Apertura
            // 
            Apertura.HeaderText = "Apertura";
            Apertura.Name = "Apertura";
            // 
            // Cierre
            // 
            Cierre.HeaderText = "Cierre";
            Cierre.Name = "Cierre";
            // 
            // MontoInicial
            // 
            MontoInicial.HeaderText = "M. Inicial";
            MontoInicial.Name = "MontoInicial";
            MontoInicial.Width = 90;
            // 
            // MontoFinal
            // 
            MontoFinal.HeaderText = "M. Final";
            MontoFinal.Name = "MontoFinal";
            MontoFinal.Width = 90;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(622, 207);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Cerrar Caja";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(541, 207);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 22;
            btnNuevo.Text = "Abrir Caja";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // CashRegisterForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 552);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvProductos);
            Controls.Add(txtMontoFinal);
            Controls.Add(label5);
            Controls.Add(dtpFechaCierre);
            Controls.Add(label4);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(txtMontoInicial);
            Controls.Add(label3);
            Controls.Add(dtpFechaApertura);
            Controls.Add(label1);
            Controls.Add(cmbUsuario);
            Controls.Add(label2);
            Name = "CashRegisterForms";
            Text = "CashRegisterForms";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cmbUsuario;
        private Label label1;
        private DateTimePicker dtpFechaApertura;
        private TextBox txtMontoInicial;
        private Label label3;
        private ComboBox cmbEstado;
        private Label label7;
        private DateTimePicker dtpFechaCierre;
        private Label label4;
        private TextBox txtMontoFinal;
        private Label label5;
        private DataGridView dgvProductos;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Apertura;
        private DataGridViewTextBoxColumn Cierre;
        private DataGridViewTextBoxColumn MontoInicial;
        private DataGridViewTextBoxColumn MontoFinal;
        private DataGridViewTextBoxColumn Estado;
    }
}



