namespace SUBE
{
    partial class LoginForm
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
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            llblRegister = new LinkLabel();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(141, 45);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 48);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario: ";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(113, 125);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 86);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(208, 15);
            label3.TabIndex = 5;
            label3.Text = "Si no tienes una cuenta creada puedes";
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Location = new Point(217, 162);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(63, 15);
            llblRegister.TabIndex = 6;
            llblRegister.TabStop = true;
            llblRegister.Text = "Registrarte";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 192);
            lblError.Name = "lblError";
            lblError.Size = new Size(285, 17);
            lblError.TabIndex = 7;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(309, 411);
            Controls.Add(lblError);
            Controls.Add(llblRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private LinkLabel llblRegister;
        private Label lblError;
    }
}