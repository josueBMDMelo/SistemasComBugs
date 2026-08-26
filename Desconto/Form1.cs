using Microsoft.Data.SqlClient;

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
            string conexao =
            @"Server=NOME-DA-MAQUINA\SQLEXPRESS;
              Database=NOME-DO-BANCO;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

                        string sql = @"
            INSERT INTO Pessoas
            (
                Nome,
                Sobrenome,
                DataNascimento,
                Sexo,
                Email,
                Profissao
            )
            VALUES
            (
                @Nome,
                @Sobrenome,
                @DataNascimento,
                @Sexo,
                @Email,
                @Profissao
            )";

            try
            {
                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNome.Text);
                        command.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                        command.Parameters.AddWithValue("@DataNascimento", txtNascimento.Text);
                        command.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Profissao", txtProfissao.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pessoa cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

            if (!ValidarPessoa())
                return;

            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;

            sexo = "Masculino";

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
                "E-mail: " + email + "\n" +
                "Profissão: " + profissao
            );
        }
        private bool ValidarNome(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private bool ValidarEmail(string valor)
        {
            return valor.Contains("@");
        }

        private bool ValidarNascimento(string valor)
        {
            return DateTime.TryParse(valor, out _);
        }

        private bool ValidarPessoa()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
            {
                MessageBox.Show("Sobrenome é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-mail é obrigatório.");
                return false;
            }

            return true;
        }
    }
}
