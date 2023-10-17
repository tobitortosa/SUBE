namespace Interface.Admin
{
    partial class AdminUsers
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
            btnVerViajes = new Button();
            btnEliminarUsuario = new Button();
            btnModificarUsuario = new Button();
            dgvSubes = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            lblUltimoViaje = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblSubesActivadas = new Label();
            lblNombre = new Label();
            lblUsername = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerViajes
            // 
            btnVerViajes.Location = new Point(506, 467);
            btnVerViajes.Name = "btnVerViajes";
            btnVerViajes.Size = new Size(177, 30);
            btnVerViajes.TabIndex = 26;
            btnVerViajes.Text = "Ver Viajes ";
            btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(506, 517);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(177, 30);
            btnEliminarUsuario.TabIndex = 25;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(506, 416);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(177, 30);
            btnModificarUsuario.TabIndex = 24;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
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
            dgvSubes.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 22;
            label1.Text = "Listado de Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(lblUltimoViaje);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblSubesActivadas);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 163);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(70, 104);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblUltimoViaje
            // 
            lblUltimoViaje.AutoSize = true;
            lblUltimoViaje.Location = new Point(85, 143);
            lblUltimoViaje.Name = "lblUltimoViaje";
            lblUltimoViaje.Size = new Size(171, 15);
            lblUltimoViaje.TabIndex = 13;
            lblUltimoViaje.Text = "Avellaneda - Lomas de Zamora";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(51, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "tobi@gmail.com";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(66, 40);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(45, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Tortosa";
            // 
            // lblSubesActivadas
            // 
            lblSubesActivadas.AutoSize = true;
            lblSubesActivadas.Location = new Point(209, 123);
            lblSubesActivadas.Name = "lblSubesActivadas";
            lblSubesActivadas.Size = new Size(13, 15);
            lblSubesActivadas.TabIndex = 12;
            lblSubesActivadas.Text = "2";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(66, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(40, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Tobias";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(124, 83);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 15);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "tobitortosa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 143);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 6;
            label8.Text = "Ultimo viaje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 62);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 123);
            label7.Name = "label7";
            label7.Size = new Size(197, 15);
            label7.TabIndex = 5;
            label7.Text = "Cantidad de tarjetas SUBE activadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 3;
            label5.Text = "Nombre de usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 4;
            label6.Text = "Es admin:";
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 579);
            Controls.Add(groupBox1);
            Controls.Add(btnVerViajes);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(dgvSubes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)dgvSubes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerViajes;
        private Button btnEliminarUsuario;
        private Button btnModificarUsuario;
        private DataGridView dgvSubes;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblUltimoViaje;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblSubesActivadas;
        private Label lblNombre;
        private Label lblUsername;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
    }
}