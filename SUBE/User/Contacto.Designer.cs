namespace Interface
{
    partial class Contacto
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
            lblvo = new System.Windows.Forms.Label();
            lblmen = new System.Windows.Forms.Label();
            lbla = new System.Windows.Forms.Label();
            lblasas = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtMensaje = new System.Windows.Forms.RichTextBox();
            txtAsunto = new System.Windows.Forms.TextBox();
            btnEnviar = new System.Windows.Forms.Button();
            lblEnviando = new System.Windows.Forms.Label();
            lblEnviado = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            lbl2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblvo
            // 
            lblvo.AutoSize = true;
            lblvo.Location = new System.Drawing.Point(12, 9);
            lblvo.Name = "lblvo";
            lblvo.Size = new System.Drawing.Size(56, 15);
            lblvo.TabIndex = 0;
            lblvo.Text = "Contacto";
            // 
            // lblmen
            // 
            lblmen.AutoSize = true;
            lblmen.Location = new System.Drawing.Point(206, 43);
            lblmen.Name = "lblmen";
            lblmen.Size = new System.Drawing.Size(54, 15);
            lblmen.TabIndex = 1;
            lblmen.Text = "Mensaje:";
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new System.Drawing.Point(206, 177);
            lbla.Name = "lbla";
            lbla.Size = new System.Drawing.Size(48, 15);
            lbla.TabIndex = 2;
            lbla.Text = "Asunto:";
            // 
            // lblasas
            // 
            lblasas.AutoSize = true;
            lblasas.Location = new System.Drawing.Point(206, 249);
            lblasas.Name = "lblasas";
            lblasas.Size = new System.Drawing.Size(361, 15);
            lblasas.TabIndex = 3;
            lblasas.Text = "El mesaje será enviado desde el correo con el que realizo el registro:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(206, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "email";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new System.Drawing.Point(206, 61);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new System.Drawing.Size(361, 96);
            txtMensaje.TabIndex = 5;
            txtMensaje.Text = "";
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new System.Drawing.Point(206, 195);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new System.Drawing.Size(162, 23);
            txtAsunto.TabIndex = 6;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new System.Drawing.Point(206, 309);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new System.Drawing.Size(361, 36);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar Correo";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblEnviando
            // 
            lblEnviando.AutoSize = true;
            lblEnviando.Location = new System.Drawing.Point(359, 366);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Size = new System.Drawing.Size(65, 15);
            lblEnviando.TabIndex = 8;
            lblEnviando.Text = "Enviando...";
            lblEnviando.Visible = false;
            // 
            // lblEnviado
            // 
            lblEnviado.AutoSize = true;
            lblEnviado.Location = new System.Drawing.Point(359, 366);
            lblEnviado.Name = "lblEnviado";
            lblEnviado.Size = new System.Drawing.Size(55, 15);
            lblEnviado.TabIndex = 9;
            lblEnviado.Text = "Enviado!!";
            lblEnviado.Visible = false;
            // 
            // lblError
            // 
            lblError.Location = new System.Drawing.Point(12, 366);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(736, 25);
            lblError.TabIndex = 10;
            lblError.Text = "Se produjo un error al querer enviar el correo. Por favor intentelo mas tade.";
            lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new System.Drawing.Point(374, 198);
            lbl2.Name = "lbl2";
            lbl2.Size = new System.Drawing.Size(45, 15);
            lbl2.TabIndex = 11;
            lbl2.Text = "(Titulo)";
            // 
            // Contacto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 410);
            Controls.Add(lbl2);
            Controls.Add(lblError);
            Controls.Add(lblEnviado);
            Controls.Add(lblEnviando);
            Controls.Add(btnEnviar);
            Controls.Add(txtAsunto);
            Controls.Add(txtMensaje);
            Controls.Add(lblEmail);
            Controls.Add(lblasas);
            Controls.Add(lbla);
            Controls.Add(lblmen);
            Controls.Add(lblvo);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Contacto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblvo;
        private System.Windows.Forms.Label lblmen;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblasas;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEnviando;
        private System.Windows.Forms.Label lblEnviado;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbl2;
    }
}