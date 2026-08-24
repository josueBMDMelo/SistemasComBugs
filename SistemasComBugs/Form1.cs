namespace SistemasComBugs
{
    public partial class Form1 : Form
    {
        string usuario = "admin";
        string senha = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = txtUser.Text.ToUpper();
            string senhaDigitada = txtPassword.Text;

            if (usuarioDigitado == usuario.ToUpper() && senhaDigitada == senha)
            {
                MessageBox.Show("Login realizado!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
