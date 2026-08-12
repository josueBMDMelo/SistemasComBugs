namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double preco = double.Parse(txtPreco.Text);
            double desconto = double.Parse(txtDesconto.Text);

            double valorDesconto = preco * desconto;
            double valorFinal = preco - (valorDesconto / 100);

            lblResultado.Text =
                $"Produto: {produto}\n" +
                $"Valor do desconto: R$ {valorDesconto:F2}\n" +
                $"Valor final: R$ {valorFinal:F2}";
        }
    }
}
