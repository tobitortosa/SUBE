namespace Interface.Admin
{
    partial class UnbanDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnbanDialog));
            label6 = new Label();
            rtxtRazon = new RichTextBox();
            lblEmail = new Label();
            lblApellido = new Label();
            btnCancelar = new Button();
            lblNombre = new Label();
            btnConfirmar = new Button();
            lblUsername = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 176);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 26;
            label6.Text = "Razon del baneo:";
            // 
            // rtxtRazon
            // 
            rtxtRazon.BorderStyle = BorderStyle.FixedSingle;
            rtxtRazon.Location = new Point(12, 196);
            rtxtRazon.Name = "rtxtRazon";
            rtxtRazon.ReadOnly = true;
            rtxtRazon.Size = new Size(222, 80);
            rtxtRazon.TabIndex = 25;
            rtxtRazon.Text = "";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(96, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(106, 17);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "tobi@gmail.com";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(96, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(53, 17);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Tortosa";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(27, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(96, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 17);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Tobias";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(142, 305);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(96, 111);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 17);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "tobitortosa";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 14;
            label1.Text = "DESBANEAR A USUARIO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 17;
            label3.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 108);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 20;
            label5.Text = "Username:";
            // 
            // UnbanDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 338);
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
            Name = "UnbanDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desbanear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private RichTextBox rtxtRazon;
        private Label lblEmail;
        private Label lblApellido;
        private Button btnCancelar;
        private Label lblNombre;
        private Button btnConfirmar;
        private Label lblUsername;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}