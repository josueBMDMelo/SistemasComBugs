namespace SistemasComBugs
{
    public partial class Form1 : Form
    {
        string usuario = "ADMIN";
        string senha = "Senha123";
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
            string senhaDigitada = txtPassword.Text.ToUpper();

            if (usuarioDigitado == "ADMIN" && senhaDigitada == "Senha123")
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
