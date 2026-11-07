namespace FarmaDesk.Desktop
{
    public partial class login : Form
    {
        private readonly IServiceProvider services;

        public login(IServiceProvider services)
        {
            InitializeComponent();
            this.services = services;
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
            using var mainForm = (MainForm)services.GetService(typeof(MainForm))!;
            mainForm.ShowDialog();
            Close();
        }

        private void btn_salir_Click(object sender, EventArgs e) => Close();
    }
}
