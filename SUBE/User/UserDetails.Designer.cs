using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    partial class UserDetails
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
            lblYDatosPersonales = new GroupBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTUsername = new Label();
            lblTEmail = new Label();
            lblTApellido = new Label();
            lblTNombre = new Label();
            pbSube = new PictureBox();
            lblYMisTarjetas = new GroupBox();
            lblSaldo4 = new Label();
            lblNombreCompleto4 = new Label();
            lblNumeroSube4 = new Label();
            pbSube4 = new PictureBox();
            lblSaldo3 = new Label();
            lblNombreCompleto3 = new Label();
            lblNumeroSube3 = new Label();
            pbSube3 = new PictureBox();
            lblNoSube = new Label();
            lblSaldo2 = new Label();
            lblNombreCompleto2 = new Label();
            lblNumeroSube2 = new Label();
            pbSube2 = new PictureBox();
            lblSaldo = new Label();
            lblNombreCompleto = new Label();
            lblNumeroSube = new Label();
            lblYDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube).BeginInit();
            lblYMisTarjetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSube3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSube2).BeginInit();
            SuspendLayout();
            // 
            // lblYDatosPersonales
            // 
            lblYDatosPersonales.Controls.Add(lblUsername);
            lblYDatosPersonales.Controls.Add(lblEmail);
            lblYDatosPersonales.Controls.Add(lblApellido);
            lblYDatosPersonales.Controls.Add(lblNombre);
            lblYDatosPersonales.Controls.Add(lblTUsername);
            lblYDatosPersonales.Controls.Add(lblTEmail);
            lblYDatosPersonales.Controls.Add(lblTApellido);
            lblYDatosPersonales.Controls.Add(lblTNombre);
            lblYDatosPersonales.Location = new Point(12, 12);
            lblYDatosPersonales.Name = "lblYDatosPersonales";
            lblYDatosPersonales.Size = new Size(147, 386);
            lblYDatosPersonales.TabIndex = 0;
            lblYDatosPersonales.TabStop = false;
            lblYDatosPersonales.Text = "Datos Personales";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(15, 117);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "label6";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(15, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "label6";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(15, 183);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(38, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "label6";
            lblApellido.Click += lblApellido_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(15, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "label6";
            // 
            // lblTUsername
            // 
            lblTUsername.AutoSize = true;
            lblTUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTUsername.Location = new Point(15, 91);
            lblTUsername.Name = "lblTUsername";
            lblTUsername.Size = new Size(70, 17);
            lblTUsername.TabIndex = 4;
            lblTUsername.Text = "Username:";
            // 
            // lblTEmail
            // 
            lblTEmail.AutoSize = true;
            lblTEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTEmail.Location = new Point(15, 217);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(42, 17);
            lblTEmail.TabIndex = 3;
            lblTEmail.Text = "Email:";
            // 
            // lblTApellido
            // 
            lblTApellido.AutoSize = true;
            lblTApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTApellido.Location = new Point(15, 154);
            lblTApellido.Name = "lblTApellido";
            lblTApellido.Size = new Size(59, 17);
            lblTApellido.TabIndex = 1;
            lblTApellido.Text = "Apellido:";
            // 
            // lblTNombre
            // 
            lblTNombre.AutoSize = true;
            lblTNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTNombre.Location = new Point(15, 37);
            lblTNombre.Name = "lblTNombre";
            lblTNombre.Size = new Size(60, 17);
            lblTNombre.TabIndex = 0;
            lblTNombre.Text = "Nombre:";
            // 
            // pbSube
            // 
            pbSube.BackgroundImage = Properties.Resources.sube;
            pbSube.BackgroundImageLayout = ImageLayout.Zoom;
            pbSube.Location = new Point(0, 22);
            pbSube.Name = "pbSube";
            pbSube.Size = new Size(284, 168);
            pbSube.TabIndex = 7;
            pbSube.TabStop = false;
            pbSube.Visible = false;
            // 
            // lblYMisTarjetas
            // 
            lblYMisTarjetas.Controls.Add(lblSaldo4);
            lblYMisTarjetas.Controls.Add(lblNombreCompleto4);
            lblYMisTarjetas.Controls.Add(lblNumeroSube4);
            lblYMisTarjetas.Controls.Add(pbSube4);
            lblYMisTarjetas.Controls.Add(lblSaldo3);
            lblYMisTarjetas.Controls.Add(lblNombreCompleto3);
            lblYMisTarjetas.Controls.Add(lblNumeroSube3);
            lblYMisTarjetas.Controls.Add(pbSube3);
            lblYMisTarjetas.Controls.Add(lblNoSube);
            lblYMisTarjetas.Controls.Add(lblSaldo2);
            lblYMisTarjetas.Controls.Add(lblNombreCompleto2);
            lblYMisTarjetas.Controls.Add(lblNumeroSube2);
            lblYMisTarjetas.Controls.Add(pbSube2);
            lblYMisTarjetas.Controls.Add(lblSaldo);
            lblYMisTarjetas.Controls.Add(lblNombreCompleto);
            lblYMisTarjetas.Controls.Add(lblNumeroSube);
            lblYMisTarjetas.Controls.Add(pbSube);
            lblYMisTarjetas.Location = new Point(165, 12);
            lblYMisTarjetas.Name = "lblYMisTarjetas";
            lblYMisTarjetas.Size = new Size(583, 386);
            lblYMisTarjetas.TabIndex = 5;
            lblYMisTarjetas.TabStop = false;
            lblYMisTarjetas.Text = "Mis Tarjetas";
            // 
            // lblSaldo4
            // 
            lblSaldo4.AutoSize = true;
            lblSaldo4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo4.Location = new Point(524, 318);
            lblSaldo4.Name = "lblSaldo4";
            lblSaldo4.Size = new Size(36, 17);
            lblSaldo4.TabIndex = 28;
            lblSaldo4.Text = "$999";
            lblSaldo4.Visible = false;
            // 
            // lblNombreCompleto4
            // 
            lblNombreCompleto4.AutoSize = true;
            lblNombreCompleto4.Location = new Point(307, 320);
            lblNombreCompleto4.Name = "lblNombreCompleto4";
            lblNombreCompleto4.Size = new Size(98, 15);
            lblNombreCompleto4.TabIndex = 27;
            lblNombreCompleto4.Text = "Nombre Apellido";
            lblNombreCompleto4.Visible = false;
            // 
            // lblNumeroSube4
            // 
            lblNumeroSube4.AutoSize = true;
            lblNumeroSube4.BackColor = Color.Transparent;
            lblNumeroSube4.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube4.ForeColor = SystemColors.WindowText;
            lblNumeroSube4.Location = new Point(307, 340);
            lblNumeroSube4.Name = "lblNumeroSube4";
            lblNumeroSube4.Size = new Size(167, 22);
            lblNumeroSube4.TabIndex = 26;
            lblNumeroSube4.Text = "0000 0000 0000 0000";
            lblNumeroSube4.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeroSube4.Visible = false;
            // 
            // pbSube4
            // 
            pbSube4.BackgroundImage = Properties.Resources.sube;
            pbSube4.BackgroundImageLayout = ImageLayout.Zoom;
            pbSube4.Location = new Point(293, 204);
            pbSube4.Name = "pbSube4";
            pbSube4.Size = new Size(284, 168);
            pbSube4.TabIndex = 25;
            pbSube4.TabStop = false;
            pbSube4.Visible = false;
            // 
            // lblSaldo3
            // 
            lblSaldo3.AutoSize = true;
            lblSaldo3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo3.Location = new Point(231, 318);
            lblSaldo3.Name = "lblSaldo3";
            lblSaldo3.Size = new Size(36, 17);
            lblSaldo3.TabIndex = 24;
            lblSaldo3.Text = "$999";
            lblSaldo3.Visible = false;
            // 
            // lblNombreCompleto3
            // 
            lblNombreCompleto3.AutoSize = true;
            lblNombreCompleto3.Location = new Point(14, 320);
            lblNombreCompleto3.Name = "lblNombreCompleto3";
            lblNombreCompleto3.Size = new Size(98, 15);
            lblNombreCompleto3.TabIndex = 23;
            lblNombreCompleto3.Text = "Nombre Apellido";
            lblNombreCompleto3.Visible = false;
            // 
            // lblNumeroSube3
            // 
            lblNumeroSube3.AutoSize = true;
            lblNumeroSube3.BackColor = Color.Transparent;
            lblNumeroSube3.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube3.ForeColor = SystemColors.WindowText;
            lblNumeroSube3.Location = new Point(14, 340);
            lblNumeroSube3.Name = "lblNumeroSube3";
            lblNumeroSube3.Size = new Size(167, 22);
            lblNumeroSube3.TabIndex = 22;
            lblNumeroSube3.Text = "0000 0000 0000 0000";
            lblNumeroSube3.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeroSube3.Visible = false;
            // 
            // pbSube3
            // 
            pbSube3.BackgroundImage = Properties.Resources.sube;
            pbSube3.BackgroundImageLayout = ImageLayout.Zoom;
            pbSube3.Location = new Point(0, 204);
            pbSube3.Name = "pbSube3";
            pbSube3.Size = new Size(284, 168);
            pbSube3.TabIndex = 21;
            pbSube3.TabStop = false;
            pbSube3.Visible = false;
            // 
            // lblNoSube
            // 
            lblNoSube.AutoSize = true;
            lblNoSube.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoSube.Location = new Point(159, 181);
            lblNoSube.Name = "lblNoSube";
            lblNoSube.Size = new Size(268, 20);
            lblNoSube.TabIndex = 19;
            lblNoSube.Text = "Usted no posee ninguna SUBE activada";
            lblNoSube.Visible = false;
            // 
            // lblSaldo2
            // 
            lblSaldo2.AutoSize = true;
            lblSaldo2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo2.Location = new Point(524, 136);
            lblSaldo2.Name = "lblSaldo2";
            lblSaldo2.Size = new Size(36, 17);
            lblSaldo2.TabIndex = 18;
            lblSaldo2.Text = "$999";
            lblSaldo2.Visible = false;
            // 
            // lblNombreCompleto2
            // 
            lblNombreCompleto2.AutoSize = true;
            lblNombreCompleto2.Location = new Point(307, 138);
            lblNombreCompleto2.Name = "lblNombreCompleto2";
            lblNombreCompleto2.Size = new Size(98, 15);
            lblNombreCompleto2.TabIndex = 17;
            lblNombreCompleto2.Text = "Nombre Apellido";
            lblNombreCompleto2.Visible = false;
            // 
            // lblNumeroSube2
            // 
            lblNumeroSube2.AutoSize = true;
            lblNumeroSube2.BackColor = Color.Transparent;
            lblNumeroSube2.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube2.ForeColor = SystemColors.WindowText;
            lblNumeroSube2.Location = new Point(307, 158);
            lblNumeroSube2.Name = "lblNumeroSube2";
            lblNumeroSube2.Size = new Size(167, 22);
            lblNumeroSube2.TabIndex = 16;
            lblNumeroSube2.Text = "0000 0000 0000 0000";
            lblNumeroSube2.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeroSube2.Visible = false;
            // 
            // pbSube2
            // 
            pbSube2.BackgroundImage = Properties.Resources.sube;
            pbSube2.BackgroundImageLayout = ImageLayout.Zoom;
            pbSube2.Location = new Point(293, 22);
            pbSube2.Name = "pbSube2";
            pbSube2.Size = new Size(284, 168);
            pbSube2.TabIndex = 15;
            pbSube2.TabStop = false;
            pbSube2.Visible = false;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.Location = new Point(232, 130);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(36, 17);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "$999";
            lblSaldo.Visible = false;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(15, 132);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(98, 15);
            lblNombreCompleto.TabIndex = 9;
            lblNombreCompleto.Text = "Nombre Apellido";
            lblNombreCompleto.Visible = false;
            // 
            // lblNumeroSube
            // 
            lblNumeroSube.AutoSize = true;
            lblNumeroSube.BackColor = Color.Transparent;
            lblNumeroSube.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube.ForeColor = SystemColors.WindowText;
            lblNumeroSube.Location = new Point(15, 152);
            lblNumeroSube.Name = "lblNumeroSube";
            lblNumeroSube.Size = new Size(167, 22);
            lblNumeroSube.TabIndex = 8;
            lblNumeroSube.Text = "0000 0000 0000 0000";
            lblNumeroSube.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeroSube.Visible = false;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(760, 410);
            Controls.Add(lblYMisTarjetas);
            Controls.Add(lblYDatosPersonales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDetails";
            lblYDatosPersonales.ResumeLayout(false);
            lblYDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube).EndInit();
            lblYMisTarjetas.ResumeLayout(false);
            lblYMisTarjetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSube3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSube2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox lblYDatosPersonales;
        private Label lblTNombre;
        private Label lblTApellido;
        private Label lblTEmail;
        private Label lblTUsername;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox pbSube;
        private GroupBox lblYMisTarjetas;
        private Label lblNumeroSube;
        private Label lblNombreCompleto;
        private Label lblSaldo;
        private Label lblSaldo2;
        private Label lblNombreCompleto2;
        private Label lblNumeroSube2;
        private PictureBox pbSube2;
        private Label label10;
        private Label lblNombreCompleto3;
        private Label label11;
        private Label lblNumeroSube3;
        private Label label12;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button1;
        private Label lblNoSube;
        private Label lblSaldo3;
        private PictureBox pbSube3;
        private Label lblSaldo4;
        private Label lblNombreCompleto4;
        private Label lblNumeroSube4;
        private PictureBox pbSube4;
    }
}