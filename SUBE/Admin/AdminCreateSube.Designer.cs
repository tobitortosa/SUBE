namespace Interface.Admin
{
    partial class AdminCreateSube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCreateSube));
            label3 = new Label();
            lblCodigoDeSeguridad = new Label();
            label5 = new Label();
            lblUsernameAdmin = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblFechaDeCreacion = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            lblSaldo = new Label();
            lblNombreCompleto = new Label();
            lblNumeroSube = new Label();
            btnCrearSube = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(146, 16);
            label3.TabIndex = 3;
            label3.Text = "Numero de Seguridad: ";
            // 
            // lblCodigoDeSeguridad
            // 
            lblCodigoDeSeguridad.AutoSize = true;
            lblCodigoDeSeguridad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoDeSeguridad.Location = new Point(155, 193);
            lblCodigoDeSeguridad.Name = "lblCodigoDeSeguridad";
            lblCodigoDeSeguridad.Size = new Size(81, 20);
            lblCodigoDeSeguridad.TabIndex = 4;
            lblCodigoDeSeguridad.Text = "00000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 6;
            label5.Text = "Creada por:";
            // 
            // lblUsernameAdmin
            // 
            lblUsernameAdmin.AutoSize = true;
            lblUsernameAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameAdmin.Location = new Point(90, 227);
            lblUsernameAdmin.Name = "lblUsernameAdmin";
            lblUsernameAdmin.Size = new Size(104, 17);
            lblUsernameAdmin.TabIndex = 7;
            lblUsernameAdmin.Text = "AdminUsername";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 259);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 8;
            label6.Text = "Fecha de creacion:";
            // 
            // lblFechaDeCreacion
            // 
            lblFechaDeCreacion.AutoSize = true;
            lblFechaDeCreacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaDeCreacion.Location = new Point(12, 286);
            lblFechaDeCreacion.Name = "lblFechaDeCreacion";
            lblFechaDeCreacion.Size = new Size(74, 17);
            lblFechaDeCreacion.TabIndex = 9;
            lblFechaDeCreacion.Text = "00/00/0000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 316);
            label11.Name = "label11";
            label11.Size = new Size(276, 20);
            label11.TabIndex = 19;
            label11.Text = "● El saldo por defecto es de $500 pesos.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 181);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.Location = new Point(244, 127);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(36, 17);
            lblSaldo.TabIndex = 23;
            lblSaldo.Text = "$500";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(27, 134);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(70, 15);
            lblNombreCompleto.TabIndex = 22;
            lblNombreCompleto.Text = "Desactivada";
            // 
            // lblNumeroSube
            // 
            lblNumeroSube.AutoSize = true;
            lblNumeroSube.BackColor = Color.Transparent;
            lblNumeroSube.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube.ForeColor = SystemColors.WindowText;
            lblNumeroSube.Location = new Point(27, 154);
            lblNumeroSube.Name = "lblNumeroSube";
            lblNumeroSube.Size = new Size(167, 22);
            lblNumeroSube.TabIndex = 21;
            lblNumeroSube.Text = "0000 0000 0000 0000";
            lblNumeroSube.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCrearSube
            // 
            btnCrearSube.Location = new Point(12, 365);
            btnCrearSube.Name = "btnCrearSube";
            btnCrearSube.Size = new Size(285, 38);
            btnCrearSube.TabIndex = 24;
            btnCrearSube.Text = "CREAR SUBE";
            btnCrearSube.UseVisualStyleBackColor = true;
            btnCrearSube.Click += btnCrearSube_Click;
            // 
            // AdminCreateSube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 415);
            Controls.Add(btnCrearSube);
            Controls.Add(lblSaldo);
            Controls.Add(lblNombreCompleto);
            Controls.Add(lblNumeroSube);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(lblFechaDeCreacion);
            Controls.Add(label6);
            Controls.Add(lblUsernameAdmin);
            Controls.Add(label5);
            Controls.Add(lblCodigoDeSeguridad);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminCreateSube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Tarjeta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label lblCodigoDeSeguridad;
        private Label label5;
        private Label lblUsernameAdmin;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblFechaDeCreacion;
        private Label label11;
        private PictureBox pictureBox1;
        private Label lblSaldo;
        private Label lblNombreCompleto;
        private Label lblNumeroSube;
        private Button btnCrearSube;
    }
}