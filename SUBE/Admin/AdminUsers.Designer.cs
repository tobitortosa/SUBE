using System.Drawing;
using System.Windows.Forms;

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
            btnBanearUsuario = new Button();
            dgvUsers = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblBaneado = new Label();
            cbAdmin = new CheckBox();
            lblUltimoViaje = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblSubesActivadas = new Label();
            lblNombre = new Label();
            lblUsername = new Label();
            lblUltimoViajeTitle = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTarjetasActivadasTitle = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerViajes
            // 
            btnVerViajes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerViajes.Location = new Point(506, 443);
            btnVerViajes.Name = "btnVerViajes";
            btnVerViajes.Size = new Size(177, 30);
            btnVerViajes.TabIndex = 26;
            btnVerViajes.Text = "Ver Viajes ";
            btnVerViajes.UseVisualStyleBackColor = true;
            btnVerViajes.Click += btnVerViajes_Click;
            // 
            // btnBanearUsuario
            // 
            btnBanearUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanearUsuario.Location = new Point(506, 493);
            btnBanearUsuario.Name = "btnBanearUsuario";
            btnBanearUsuario.Size = new Size(177, 30);
            btnBanearUsuario.TabIndex = 25;
            btnBanearUsuario.Text = "Banear Usuario";
            btnBanearUsuario.UseVisualStyleBackColor = true;
            btnBanearUsuario.Click += btnBanearUsuario_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 51);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(736, 347);
            dgvUsers.TabIndex = 23;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 22;
            label1.Text = "Listado de Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBaneado);
            groupBox1.Controls.Add(cbAdmin);
            groupBox1.Controls.Add(lblUltimoViaje);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblSubesActivadas);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblUltimoViajeTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTarjetasActivadasTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 165);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // lblBaneado
            // 
            lblBaneado.AutoSize = true;
            lblBaneado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaneado.ForeColor = Color.Red;
            lblBaneado.Location = new Point(326, 12);
            lblBaneado.Name = "lblBaneado";
            lblBaneado.Size = new Size(68, 20);
            lblBaneado.TabIndex = 15;
            lblBaneado.Text = "Baneado";
            lblBaneado.Visible = false;
            // 
            // cbAdmin
            // 
            cbAdmin.AutoSize = true;
            cbAdmin.Enabled = false;
            cbAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbAdmin.Location = new Point(70, 105);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(15, 14);
            cbAdmin.TabIndex = 14;
            cbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblUltimoViaje
            // 
            lblUltimoViaje.AutoSize = true;
            lblUltimoViaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUltimoViaje.Location = new Point(82, 142);
            lblUltimoViaje.Name = "lblUltimoViaje";
            lblUltimoViaje.Size = new Size(190, 17);
            lblUltimoViaje.TabIndex = 13;
            lblUltimoViaje.Text = "Avellaneda - Lomas de Zamora";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(45, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 17);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "tobi@gmail.com";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(63, 39);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Tortosa";
            // 
            // lblSubesActivadas
            // 
            lblSubesActivadas.AutoSize = true;
            lblSubesActivadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubesActivadas.Location = new Point(190, 122);
            lblSubesActivadas.Name = "lblSubesActivadas";
            lblSubesActivadas.Size = new Size(15, 17);
            lblSubesActivadas.TabIndex = 12;
            lblSubesActivadas.Text = "2";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(63, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Tobias";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(132, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "tobitortosa";
            // 
            // lblUltimoViajeTitle
            // 
            lblUltimoViajeTitle.AutoSize = true;
            lblUltimoViajeTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUltimoViajeTitle.Location = new Point(6, 142);
            lblUltimoViajeTitle.Name = "lblUltimoViajeTitle";
            lblUltimoViajeTitle.Size = new Size(79, 17);
            lblUltimoViajeTitle.TabIndex = 6;
            lblUltimoViajeTitle.Text = "Ultimo viaje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 61);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 39);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            // 
            // lblTarjetasActivadasTitle
            // 
            lblTarjetasActivadasTitle.AutoSize = true;
            lblTarjetasActivadasTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarjetasActivadasTitle.Location = new Point(6, 122);
            lblTarjetasActivadasTitle.Name = "lblTarjetasActivadasTitle";
            lblTarjetasActivadasTitle.Size = new Size(187, 17);
            lblTarjetasActivadasTitle.TabIndex = 5;
            lblTarjetasActivadasTitle.Text = "Cantidad de tarjetas activadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 82);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 3;
            label5.Text = "Nombre de usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 102);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
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
            Controls.Add(btnBanearUsuario);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerViajes;
        private Button btnBanearUsuario;
        private DataGridView dgvUsers;
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
        private Label lblUltimoViajeTitle;
        private Label lblTarjetasActivadasTitle;
        private Label label5;
        private Label label6;
        private CheckBox cbAdmin;
        private Label lblBaneado;
    }
}