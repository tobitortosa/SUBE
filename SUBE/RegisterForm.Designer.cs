using System.Drawing;
using System.Windows.Forms;

namespace Interface.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            lblNombre = new Label();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            txtRepeatedPassword = new TextBox();
            label6 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            llblRegister = new LinkLabel();
            btnRegister = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 10;
            label1.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre: ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(15, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 23);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 17;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 164);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 16;
            label4.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(282, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 268);
            label5.Name = "label5";
            label5.Size = new Size(127, 17);
            label5.TabIndex = 21;
            label5.Text = "Repetir Contraseña: ";
            // 
            // txtRepeatedPassword
            // 
            txtRepeatedPassword.Location = new Point(15, 288);
            txtRepeatedPassword.Name = "txtRepeatedPassword";
            txtRepeatedPassword.PasswordChar = '*';
            txtRepeatedPassword.Size = new Size(282, 23);
            txtRepeatedPassword.TabIndex = 6;
            txtRepeatedPassword.TextChanged += txtRepeatedPassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 112);
            label6.Name = "label6";
            label6.Size = new Size(126, 17);
            label6.TabIndex = 24;
            label6.Text = "Nombre de usuario:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(15, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 23);
            txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 382);
            label2.Name = "label2";
            label2.Size = new Size(231, 17);
            label2.TabIndex = 26;
            label2.Text = "Si ya tienes una cuenta creada puedes";
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            llblRegister.Location = new Point(241, 381);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(60, 17);
            llblRegister.TabIndex = 8;
            llblRegister.TabStop = true;
            llblRegister.Text = "Logearte";
            llblRegister.LinkClicked += llblRegister_LinkClicked_1;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(15, 317);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(282, 37);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(15, 357);
            lblError.Name = "lblError";
            lblError.Size = new Size(282, 24);
            lblError.TabIndex = 27;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 411);
            Controls.Add(lblError);
            Controls.Add(btnRegister);
            Controls.Add(llblRegister);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(txtRepeatedPassword);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creacion de cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblNombre;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtRepeatedPassword;
        private Label label6;
        private TextBox txtUsername;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private LinkLabel llblRegister;
        private Button btnRegister;
        private Label lblError;
    }
}