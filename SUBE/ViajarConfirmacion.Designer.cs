using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    partial class ViajarConfirmacion
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
            btnConfirmar = new Button();
            cbSube = new ComboBox();
            label3 = new Label();
            lblSaldo = new Label();
            lblUsuarioPropietario = new Label();
            lblNumeroSube = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lblDestino = new Label();
            label1 = new Label();
            lblOrigen = new Label();
            label2 = new Label();
            label4 = new Label();
            lblCosto = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 368);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(285, 35);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar Viaje";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbSube
            // 
            cbSube.FormattingEnabled = true;
            cbSube.Location = new Point(27, 34);
            cbSube.Name = "cbSube";
            cbSube.Size = new Size(253, 23);
            cbSube.TabIndex = 5;
            cbSube.SelectedIndexChanged += cbSube_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 14);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 6;
            label3.Text = "Elegir Sube";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.Location = new Point(223, 160);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(35, 15);
            lblSaldo.TabIndex = 25;
            lblSaldo.Text = "$999";
            // 
            // lblUsuarioPropietario
            // 
            lblUsuarioPropietario.AutoSize = true;
            lblUsuarioPropietario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioPropietario.Location = new Point(48, 162);
            lblUsuarioPropietario.Name = "lblUsuarioPropietario";
            lblUsuarioPropietario.Size = new Size(94, 13);
            lblUsuarioPropietario.TabIndex = 24;
            lblUsuarioPropietario.Text = "Nombre Apellido";
            // 
            // lblNumeroSube
            // 
            lblNumeroSube.AutoSize = true;
            lblNumeroSube.BackColor = Color.Transparent;
            lblNumeroSube.BorderStyle = BorderStyle.FixedSingle;
            lblNumeroSube.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroSube.ForeColor = SystemColors.WindowText;
            lblNumeroSube.Location = new Point(48, 178);
            lblNumeroSube.Name = "lblNumeroSube";
            lblNumeroSube.Size = new Size(134, 19);
            lblNumeroSube.TabIndex = 23;
            lblNumeroSube.Text = "0000 0000 0000 0000";
            lblNumeroSube.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(7, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 144);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDestino);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblOrigen);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 113);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.Location = new Point(15, 78);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(45, 17);
            lblDestino.TabIndex = 30;
            lblDestino.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 27;
            label1.Text = "Origen:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrigen.Location = new Point(15, 36);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(45, 17);
            lblOrigen.TabIndex = 29;
            lblOrigen.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 28;
            label2.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 210);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 31;
            label4.Text = "Costo del Viaje: ";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(185, 212);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(21, 15);
            lblCosto.TabIndex = 32;
            lblCosto.Text = "$0";
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(7, 346);
            lblError.Name = "lblError";
            lblError.Size = new Size(295, 19);
            lblError.TabIndex = 33;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // ViajarConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 415);
            Controls.Add(lblError);
            Controls.Add(lblCosto);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lblSaldo);
            Controls.Add(lblUsuarioPropietario);
            Controls.Add(lblNumeroSube);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cbSube);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViajarConfirmacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViajarConfirmacion";
            Load += ViajarConfirmacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ComboBox cbSube;
        private Label label3;
        private Label lblSaldo;
        private Label lblUsuarioPropietario;
        private Label lblNumeroSube;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label4;
        private Label lblDestino;
        private Label label1;
        private Label lblOrigen;
        private Label label2;
        private Label lblCosto;
        private Label lblError;
    }
}