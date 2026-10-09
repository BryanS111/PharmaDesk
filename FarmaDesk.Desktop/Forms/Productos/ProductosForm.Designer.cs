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
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(578, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 123);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 2;
            label2.Text = "DESCRIPCION:";
            label2.Click += label2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(47, 151);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(578, 113);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 286);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "CATEGORIA:";
            label3.Click += label3_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(47, 314);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(272, 33);
            cmbCategoria.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 287);
            label4.Name = "label4";
            label4.Size = new Size(257, 25);
            label4.TabIndex = 6;
            label4.Text = "HUMBRAL DE STOCK MINIMO:";
            // 
            // numStockMinimo
            // 
            numStockMinimo.Location = new Point(351, 315);
            numStockMinimo.Name = "numStockMinimo";
            numStockMinimo.Size = new Size(272, 31);
            numStockMinimo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 366);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 8;
            label5.Text = "PRECIO COMPRA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 366);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 9;
            label6.Text = "PRECIO VENTA:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(47, 403);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(272, 31);
            txtPrecioCompra.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(351, 403);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(272, 31);
            txtPrecioVenta.TabIndex = 11;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 746);
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
            Name = "ProductosForm";
            Text = "PRODUCTOS - CRUD";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).EndInit();
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
    }
}