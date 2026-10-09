namespace FarmaDesk.Desktop
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Ingresarbtn_Ingresar = new Button();
            btn_salir = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 12, 24);
            label1.Location = new Point(256, 204);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 4;
            // 
            // btn_Ingresarbtn_Ingresar
            // 
            btn_Ingresarbtn_Ingresar.BackColor = Color.FromArgb(5, 47, 123);
            btn_Ingresarbtn_Ingresar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ingresarbtn_Ingresar.ForeColor = Color.White;
            btn_Ingresarbtn_Ingresar.Location = new Point(244, 308);
            btn_Ingresarbtn_Ingresar.Name = "btn_Ingresarbtn_Ingresar";
            btn_Ingresarbtn_Ingresar.Size = new Size(146, 58);
            btn_Ingresarbtn_Ingresar.TabIndex = 5;
            btn_Ingresarbtn_Ingresar.Text = "INGRESAR";
            btn_Ingresarbtn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(5, 47, 123);
            btn_salir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(426, 308);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(146, 58);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "SALIR";
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 12, 24);
            label3.Location = new Point(236, 251);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 7;
            label3.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icono_usuario;
            pictureBox1.Location = new Point(331, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btn_salir);
            Controls.Add(btn_Ingresarbtn_Ingresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "login";
            Text = "INICIO DE SESION";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Ingresarbtn_Ingresar;
        private Button btn_salir;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
