using System.Drawing;
using System.Windows.Forms;

namespace Interface.Admin
{
    partial class AdminViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViajes));
            label1 = new Label();
            dgvViajes = new DataGridView();
            lblNombreCompleto = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Viajes de ";
            // 
            // dgvViajes
            // 
            dgvViajes.AllowUserToAddRows = false;
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 43);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.ReadOnly = true;
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(504, 395);
            dgvViajes.TabIndex = 24;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCompleto.Location = new Point(75, 9);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(105, 20);
            lblNombreCompleto.TabIndex = 25;
            lblNombreCompleto.Text = "Tobias Tortosa";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(384, 9);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(132, 23);
            btnImprimir.TabIndex = 26;
            btnImprimir.Text = "Imprimir Viajes";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // AdminViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(btnImprimir);
            Controls.Add(lblNombreCompleto);
            Controls.Add(dgvViajes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminViajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viajes";
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvViajes;
        private Label lblNombreCompleto;
        private Button btnImprimir;
    }
}