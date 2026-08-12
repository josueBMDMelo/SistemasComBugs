namespace Cadastro
{
    partial class Form1
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
            txtProduto = new TextBox();
            txtPreco = new TextBox();
            txtDesconto = new TextBox();
            btnCalcular = new Button();
            lblProduto = new Label();
            lblPreco = new Label();
            lblDesconto = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(76, 17);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(124, 23);
            txtProduto.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(76, 60);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(124, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(76, 102);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(124, 23);
            txtDesconto.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 149);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(188, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(10, 20);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(53, 15);
            lblProduto.TabIndex = 4;
            lblProduto.Text = "Produto:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(10, 60);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(10, 105);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(60, 15);
            lblDesconto.TabIndex = 6;
            lblDesconto.Text = "Desconto:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 189);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblDesconto);
            Controls.Add(lblPreco);
            Controls.Add(lblProduto);
            Controls.Add(btnCalcular);
            Controls.Add(txtDesconto);
            Controls.Add(txtPreco);
            Controls.Add(txtProduto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduto;
        private TextBox txtPreco;
        private TextBox txtDesconto;
        private Button btnCalcular;
        private Label lblProduto;
        private Label lblPreco;
        private Label lblDesconto;
        private Label lblResultado;
    }
}
