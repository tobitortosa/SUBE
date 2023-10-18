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
            groupBox1 = new GroupBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbSube = new PictureBox();
            groupBox2 = new GroupBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSube3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSube2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(147, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(0, 38);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(45, 17);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "label6";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(0, 184);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "label6";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(0, 130);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(45, 17);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "label6";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(0, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(45, 17);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 19);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 4;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 163);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 113);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSaldo4);
            groupBox2.Controls.Add(lblNombreCompleto4);
            groupBox2.Controls.Add(lblNumeroSube4);
            groupBox2.Controls.Add(pbSube4);
            groupBox2.Controls.Add(lblSaldo3);
            groupBox2.Controls.Add(lblNombreCompleto3);
            groupBox2.Controls.Add(lblNumeroSube3);
            groupBox2.Controls.Add(pbSube3);
            groupBox2.Controls.Add(lblNoSube);
            groupBox2.Controls.Add(lblSaldo2);
            groupBox2.Controls.Add(lblNombreCompleto2);
            groupBox2.Controls.Add(lblNumeroSube2);
            groupBox2.Controls.Add(pbSube2);
            groupBox2.Controls.Add(lblSaldo);
            groupBox2.Controls.Add(lblNombreCompleto);
            groupBox2.Controls.Add(lblNumeroSube);
            groupBox2.Controls.Add(pbSube);
            groupBox2.Location = new Point(165, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(583, 386);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mis Tarjetas";
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
            ClientSize = new Size(760, 410);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDetails";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSube4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSube3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSube2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox pbSube;
        private GroupBox groupBox2;
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