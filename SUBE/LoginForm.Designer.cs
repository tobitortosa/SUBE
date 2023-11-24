using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUser = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            llblRegister = new LinkLabel();
            lblError = new Label();
            lblRazon = new Label();
            rtxtRazon = new RichTextBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 29);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(285, 25);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(12, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(285, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(285, 25);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 201);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 5;
            // 
            // llblRegister
            // 
            llblRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            llblRegister.Location = new Point(12, 200);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(285, 29);
            llblRegister.TabIndex = 4;
            llblRegister.TabStop = true;
            llblRegister.Text = "Crearse una cuenta";
            llblRegister.TextAlign = ContentAlignment.TopCenter;
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 229);
            lblError.Name = "lblError";
            lblError.Size = new Size(285, 27);
            lblError.TabIndex = 7;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRazon.Location = new Point(12, 265);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(110, 17);
            lblRazon.TabIndex = 14;
            lblRazon.Text = "Razon del baneo:";
            lblRazon.Visible = false;
            // 
            // rtxtRazon
            // 
            rtxtRazon.BorderStyle = BorderStyle.None;
            rtxtRazon.Enabled = false;
            rtxtRazon.Location = new Point(12, 288);
            rtxtRazon.Name = "rtxtRazon";
            rtxtRazon.Size = new Size(285, 62);
            rtxtRazon.TabIndex = 13;
            rtxtRazon.Text = "";
            rtxtRazon.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(309, 411);
            Controls.Add(lblRazon);
            Controls.Add(rtxtRazon);
            Controls.Add(lblError);
            Controls.Add(llblRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
        private Label lblRazon;
        private RichTextBox rtxtRazon;
    }
}