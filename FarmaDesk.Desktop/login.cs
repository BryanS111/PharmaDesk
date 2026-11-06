namespace FarmaDesk.Desktop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hide();
            using var mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void btn_salir_Click(object sender, EventArgs e) => Close();
    }
}
