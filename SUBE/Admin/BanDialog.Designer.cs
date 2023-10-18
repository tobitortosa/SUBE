namespace Interface.Admin
{
    partial class BanDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanDialog));
            label1 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblUsername = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            rtxtRazon = new RichTextBox();
            label6 = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 0;
            label1.Text = "BANEAR A USUARIO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(142, 303);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(27, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 3;
            label5.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(97, 113);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 17);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "tobitortosa";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(97, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Tobias";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(97, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(53, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Tortosa";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(97, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(106, 17);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "tobi@gmail.com";
            // 
            // rtxtRazon
            // 
            rtxtRazon.BorderStyle = BorderStyle.FixedSingle;
            rtxtRazon.Location = new Point(12, 194);
            rtxtRazon.Name = "rtxtRazon";
            rtxtRazon.Size = new Size(222, 80);
            rtxtRazon.TabIndex = 11;
            rtxtRazon.Text = "";
            rtxtRazon.TextChanged += rtxtRazon_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 174);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 12;
            label6.Text = "Razon del baneo:";
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 277);
            lblError.Name = "lblError";
            lblError.Size = new Size(222, 23);
            lblError.TabIndex = 13;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // BanDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 338);
            Controls.Add(lblError);
            Controls.Add(label6);
            Controls.Add(rtxtRazon);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(btnCancelar);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BanDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblUsername;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private RichTextBox rtxtRazon;
        private Label label6;
        private Label lblError;
    }
}