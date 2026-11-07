namespace FarmaDesk.Desktop
{
    public partial class login : Form
    {
        private readonly IServiceProvider services;
        private readonly UserRepository users;

        public login(IServiceProvider services, UserRepository users)
        {
            InitializeComponent();
            this.services = services;
            this.users = users;
        }
        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseÃ±a.", "ValidaciÃ³n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var currentUser = users.Authenticate(textBox1.Text.Trim(), textBox2.Text);
            if (currentUser is null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o usuario inactivo.", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            using var mainForm = new MainForm(services, currentUser);
            mainForm.ShowDialog();
            Close();
        }

        private void btn_salir_Click(object sender, EventArgs e) => Close();
    }
}

