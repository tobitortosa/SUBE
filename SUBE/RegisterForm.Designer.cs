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
            label2 = new Label();
            llblRegister = new LinkLabel();
            btnRegister = new Button();
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
            lblError = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 350);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 13;
            label2.Text = "Si ya tienes cuenta creada puede";
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Location = new Point(215, 350);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(53, 15);
            llblRegister.TabIndex = 12;
            llblRegister.TabStop = true;
            llblRegister.Text = "Logearte";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(115, 376);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 82);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 10;
            label1.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(86, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre: ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(159, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 8;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 198);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 159);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 15;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 234);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 21;
            label5.Text = "Repetir Contraseña: ";
            // 
            // txtRepeatedPassword
            // 
            txtRepeatedPassword.Location = new Point(159, 231);
            txtRepeatedPassword.Name = "txtRepeatedPassword";
            txtRepeatedPassword.PasswordChar = '*';
            txtRepeatedPassword.Size = new Size(100, 23);
            txtRepeatedPassword.TabIndex = 19;
            txtRepeatedPassword.TextChanged += txtRepeatedPassword_TextChanged;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 335);
            lblError.Name = "lblError";
            lblError.Size = new Size(285, 15);
            lblError.TabIndex = 22;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 121);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 24;
            label6.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(159, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(59, 278);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 411);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(lblError);
            Controls.Add(label5);
            Controls.Add(txtRepeatedPassword);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(llblRegister);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel llblRegister;
        private Button btnRegister;
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
        private Label lblError;
        private Label label6;
        private TextBox txtUsername;
        private DateTimePicker dateTimePicker1;
    }
}