namespace Desconto
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
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProfissao = new Label();
            textBox3 = new TextBox();
            txtEmail = new TextBox();
            Sexi = new Label();
            cmbSexo = new ComboBox();
            btnListar = new Button();
            btnCadastrar = new Button();
            lblMostrar = new Label();
            txtNascimento = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(113, 72);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(121, 23);
            txtSobrenome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 230);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail:";
            // 
            // txtProfissao
            // 
            txtProfissao.AutoSize = true;
            txtProfissao.Location = new Point(45, 272);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(58, 15);
            txtProfissao.TabIndex = 5;
            txtProfissao.Text = "Profissão:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 7;
            // 
            // Sexi
            // 
            Sexi.AutoSize = true;
            Sexi.Location = new Point(59, 179);
            Sexi.Name = "Sexi";
            Sexi.Size = new Size(34, 15);
            Sexi.TabIndex = 9;
            Sexi.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexo.Location = new Point(113, 176);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 10;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(32, 368);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(202, 23);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(32, 328);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(202, 23);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Location = new Point(298, 24);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(0, 15);
            lblMostrar.TabIndex = 13;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(113, 124);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(121, 23);
            txtNascimento.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 127);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 15;
            label5.Text = "Nascimento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtNascimento);
            Controls.Add(lblMostrar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnListar);
            Controls.Add(cmbSexo);
            Controls.Add(Sexi);
            Controls.Add(txtEmail);
            Controls.Add(textBox3);
            Controls.Add(txtProfissao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtProfissao;
        private TextBox textBox3;
        private TextBox txtEmail;
        private Label Sexi;
        private ComboBox cmbSexo;
        private Button btnListar;
        private Button btnCadastrar;
        private Label lblMostrar;
        private TextBox txtNascimento;
        private Label label5;
    }
}
