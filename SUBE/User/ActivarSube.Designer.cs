using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    partial class ActivarSube
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
            lbl1 = new Label();
            groupBox1 = new GroupBox();
            lblActivada = new Label();
            lblError = new Label();
            txtContraseña = new TextBox();
            lbl4 = new Label();
            txtNombreUsuario = new TextBox();
            lbl3 = new Label();
            btnHandleActivar = new Button();
            txtCodigoSeguridad = new TextBox();
            lbl2 = new Label();
            txtNumeroTarjeta = new TextBox();
            groupBox2 = new GroupBox();
            lblSaldoSUBE = new Label();
            lblNombreCompletoSUBE = new Label();
            lblNumeroTarjetaSUBE = new Label();
            pictureBox1 = new PictureBox();
            lbl5 = new Label();
            lbl8 = new Label();
            lbl6 = new Label();
            lbl9 = new Label();
            lbl7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(8, 52);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(169, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ingrese el numero de la tarjeta:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblActivada);
            groupBox1.Controls.Add(lblError);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Controls.Add(btnHandleActivar);
            groupBox1.Controls.Add(txtCodigoSeguridad);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(txtNumeroTarjeta);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 386);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos";
            // 
            // lblActivada
            // 
            lblActivada.ForeColor = Color.Chartreuse;
            lblActivada.Location = new Point(6, 285);
            lblActivada.Name = "lblActivada";
            lblActivada.Size = new Size(203, 19);
            lblActivada.TabIndex = 13;
            lblActivada.Text = "Creada";
            lblActivada.TextAlign = ContentAlignment.TopCenter;
            lblActivada.Visible = false;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(6, 285);
            lblError.Name = "lblError";
            lblError.Size = new Size(203, 19);
            lblError.TabIndex = 11;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(6, 250);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(203, 23);
            txtContraseña.TabIndex = 10;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(6, 232);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(124, 15);
            lbl4.TabIndex = 9;
            lbl4.Text = "Ingrese su contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(6, 192);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(203, 23);
            txtNombreUsuario.TabIndex = 8;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(8, 174);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(166, 15);
            lbl3.TabIndex = 7;
            lbl3.Text = "Ingrese su nombre de usuario:";
            // 
            // btnHandleActivar
            // 
            btnHandleActivar.Location = new Point(6, 321);
            btnHandleActivar.Name = "btnHandleActivar";
            btnHandleActivar.Size = new Size(203, 23);
            btnHandleActivar.TabIndex = 3;
            btnHandleActivar.Text = "ACTIVAR SUBE";
            btnHandleActivar.UseVisualStyleBackColor = true;
            btnHandleActivar.Click += btnHandleActivar_Click;
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.Location = new Point(6, 132);
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(203, 23);
            txtCodigoSeguridad.TabIndex = 6;
            txtCodigoSeguridad.TextChanged += txtCodigoSeguridad_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(8, 114);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(171, 15);
            lbl2.TabIndex = 4;
            lbl2.Text = "Ingrese el codigo de seguridad:";
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(6, 70);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(203, 23);
            txtNumeroTarjeta.TabIndex = 2;
            txtNumeroTarjeta.TextChanged += txtNumeroTarjeta_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSaldoSUBE);
            groupBox2.Controls.Add(lblNombreCompletoSUBE);
            groupBox2.Controls.Add(lblNumeroTarjetaSUBE);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(240, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 225);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Previsualizacion";
            // 
            // lblSaldoSUBE
            // 
            lblSaldoSUBE.AutoSize = true;
            lblSaldoSUBE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldoSUBE.Location = new Point(341, 142);
            lblSaldoSUBE.Name = "lblSaldoSUBE";
            lblSaldoSUBE.Size = new Size(36, 17);
            lblSaldoSUBE.TabIndex = 14;
            lblSaldoSUBE.Text = "$500";
            // 
            // lblNombreCompletoSUBE
            // 
            lblNombreCompletoSUBE.AutoSize = true;
            lblNombreCompletoSUBE.Location = new Point(124, 144);
            lblNombreCompletoSUBE.Name = "lblNombreCompletoSUBE";
            lblNombreCompletoSUBE.Size = new Size(98, 15);
            lblNombreCompletoSUBE.TabIndex = 13;
            lblNombreCompletoSUBE.Text = "Nombre Apellido";
            // 
            // lblNumeroTarjetaSUBE
            // 
            lblNumeroTarjetaSUBE.AutoSize = true;
            lblNumeroTarjetaSUBE.BackColor = Color.Transparent;
            lblNumeroTarjetaSUBE.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroTarjetaSUBE.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroTarjetaSUBE.ForeColor = SystemColors.WindowText;
            lblNumeroTarjetaSUBE.Location = new Point(124, 164);
            lblNumeroTarjetaSUBE.Name = "lblNumeroTarjetaSUBE";
            lblNumeroTarjetaSUBE.Size = new Size(167, 22);
            lblNumeroTarjetaSUBE.TabIndex = 12;
            lblNumeroTarjetaSUBE.Text = "0000 0000 0000 0000";
            lblNumeroTarjetaSUBE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(109, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 168);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5.Location = new Point(240, 261);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(464, 20);
            lbl5.TabIndex = 4;
            lbl5.Text = "● Le recordamos que para poder validar una sube, esta deberá estar ";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl8.Location = new Point(240, 351);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(466, 20);
            lbl8.TabIndex = 5;
            lbl8.Text = "● Tambien deberá  contar con el codigo de seguridad obtenido en la";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6.Location = new Point(253, 281);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(142, 20);
            lbl6.TabIndex = 6;
            lbl6.Text = "liberada de fabrica. ";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl9.Location = new Point(253, 371);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(147, 20);
            lbl9.TabIndex = 7;
            lbl9.Text = "compra de la tarjeta.";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7.Location = new Point(240, 312);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(276, 20);
            lbl7.TabIndex = 8;
            lbl7.Text = "● El saldo por defecto es de $500 pesos.";
            // 
            // ActivarSube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 410);
            Controls.Add(lbl7);
            Controls.Add(lbl9);
            Controls.Add(lbl6);
            Controls.Add(lbl8);
            Controls.Add(lbl5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivarSube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivarSube";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtNumeroTarjeta;
        private GroupBox groupBox2;
        private TextBox txtCodigoSeguridad;
        private Button btnHandleActivar;
        private Label label4;
        private Label label5;
        private TextBox txtContraseña;
        private Label label9;
        private TextBox txtNombreUsuario;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label lblSaldoSUBE;
        private Label lblNombreCompletoSUBE;
        private Label lblNumeroTarjetaSUBE;
        private PictureBox pictureBox1;
        private Label label11;
        private Label lblError;
        private Label lblActivada;
        private Label lbl1;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl5;
        private Label lbl8;
        private Label lbl6;
        private Label lbl9;
        private Label lbl7;
    }
}