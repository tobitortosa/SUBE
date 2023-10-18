namespace Interface
{
    partial class AdminSube
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
            label1 = new Label();
            dgvSubes = new DataGridView();
            btnCrearSube = new Button();
            btnEliminarSube = new Button();
            btnEditarSube = new Button();
            pictureBox1 = new PictureBox();
            lblSaldo = new Label();
            lblUsuarioPropietario = new Label();
            lblNumeroSube = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "Listado de Tarjetas";
            // 
            // dgvSubes
            // 
            dgvSubes.AllowUserToAddRows = false;
            dgvSubes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubes.Location = new Point(12, 51);
            dgvSubes.Name = "dgvSubes";
            dgvSubes.ReadOnly = true;
            dgvSubes.RowTemplate.Height = 25;
            dgvSubes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubes.Size = new Size(736, 347);
            dgvSubes.TabIndex = 1;
            dgvSubes.CellClick += dgvSubes_CellClick;
            // 
            // btnCrearSube
            // 
            btnCrearSube.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearSube.Location = new Point(451, 418);
            btnCrearSube.Name = "btnCrearSube";
            btnCrearSube.Size = new Size(177, 30);
            btnCrearSube.TabIndex = 15;
            btnCrearSube.Text = "Crear Sube";
            btnCrearSube.UseVisualStyleBackColor = true;
            btnCrearSube.Click += btnCrearSube_Click;
            // 
            // btnEliminarSube
            // 
            btnEliminarSube.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarSube.Location = new Point(451, 519);
            btnEliminarSube.Name = "btnEliminarSube";
            btnEliminarSube.Size = new Size(177, 30);
            btnEliminarSube.TabIndex = 16;
            btnEliminarSube.Text = "Eliminar Sube";
            btnEliminarSube.UseVisualStyleBackColor = true;
            btnEliminarSube.Click += btnEliminarSube_Click;
            // 
            // btnEditarSube
            // 
            btnEditarSube.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarSube.Location = new Point(451, 469);
            btnEditarSube.Name = "btnEditarSube";
            btnEditarSube.Size = new Size(177, 30);
            btnEditarSube.TabIndex = 17;
            btnEditarSube.Text = "Ver Cargas ";
            btnEditarSube.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 169);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.Location = new Point(245, 506);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(36, 17);
            lblSaldo.TabIndex = 21;
            lblSaldo.Text = "$999";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // lblUsuarioPropietario
            // 
            lblUsuarioPropietario.AutoSize = true;
            lblUsuarioPropietario.Location = new Point(28, 513);
            lblUsuarioPropietario.Name = "lblUsuarioPropietario";
            lblUsuarioPropietario.Size = new Size(98, 15);
            lblUsuarioPropietario.TabIndex = 20;
            lblUsuarioPropietario.Text = "Nombre Apellido";
            lblUsuarioPropietario.Click += lblUsuarioPropietario_Click;
            // 
            // lblNumeroSube
            // 
            lblNumeroSube.AutoSize = true;
            lblNumeroSube.BackColor = Color.Transparent;
            lblNumeroSube.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube.ForeColor = SystemColors.WindowText;
            lblNumeroSube.Location = new Point(28, 533);
            lblNumeroSube.Name = "lblNumeroSube";
            lblNumeroSube.Size = new Size(167, 22);
            lblNumeroSube.TabIndex = 19;
            lblNumeroSube.Text = "0000 0000 0000 0000";
            lblNumeroSube.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeroSube.Click += lblNumeroSube_Click;
            // 
            // AdminSube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 579);
            Controls.Add(lblSaldo);
            Controls.Add(lblUsuarioPropietario);
            Controls.Add(lblNumeroSube);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditarSube);
            Controls.Add(btnEliminarSube);
            Controls.Add(btnCrearSube);
            Controls.Add(dgvSubes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSube";
            Load += AdminSube_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSubes;
        private Button btnCrearSube;
        private Button btnEliminarSube;
        private Button btnEditarSube;
        private PictureBox pictureBox1;
        private Label lblSaldo;
        private Label lblUsuarioPropietario;
        private Label lblNumeroSube;
    }
}