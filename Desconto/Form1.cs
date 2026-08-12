namespace Desconto
{
    public partial class Form1 : Form
    {
        string nome = "";
        string sobrenome = "";
        string sexo = "";
        string nascimento = "";
        string email = "";
        string profissao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;

            // BUG 1
            sexo = "Masculino";

            // BUG 2
            nascimento = DateTime.Parse(txtNascimento.Text)
                                 .ToString("MM/dd/yyyy");

            email = txtEmail.Text;
            profissao = txtProfissao.Text;

            MessageBox.Show("Pessoa cadastrada!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nome: " + nome + "\n" +
                "Sobrenome: " + sobrenome + "\n" +
                "Sexo: " + sexo + "\n" +
                "Nascimento: " + nascimento + "\n" +
                "Profissão: " + profissao
            );
        }
    }
}
