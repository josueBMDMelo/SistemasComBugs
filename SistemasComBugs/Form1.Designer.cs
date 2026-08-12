namespace SistemasComBugs
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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUser = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(69, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(149, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(11, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(11, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuário: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(11, 59);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(45, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Senha: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPassword;
    }
}
