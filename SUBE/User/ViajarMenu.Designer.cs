using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    partial class ViajarMenu
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
            pictureBox1 = new PictureBox();
            cbOrigen = new ComboBox();
            rbtnLaPlata = new RadioButton();
            rbtnGutierrez = new RadioButton();
            rbtnChascomus = new RadioButton();
            rbtnCañuelas = new RadioButton();
            rbtnHaedo = new RadioButton();
            gbRamales = new GroupBox();
            lbl5 = new Label();
            cbDestino = new ComboBox();
            lbl6 = new Label();
            btnViajar = new Button();
            lblOrigen = new Label();
            lblDestino = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lblGasto = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbRamales.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.recorrido_tren;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(163, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 292);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cbOrigen
            // 
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Items.AddRange(new object[] { "Alejandro Korn", "Guernica", "Glew", "Burzaco" });
            cbOrigen.Location = new Point(12, 202);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(145, 23);
            cbOrigen.TabIndex = 3;
            cbOrigen.SelectedIndexChanged += cbOrigen_SelectedIndexChanged;
            // 
            // rbtnLaPlata
            // 
            rbtnLaPlata.AutoSize = true;
            rbtnLaPlata.Location = new Point(16, 22);
            rbtnLaPlata.Name = "rbtnLaPlata";
            rbtnLaPlata.Size = new Size(66, 19);
            rbtnLaPlata.TabIndex = 0;
            rbtnLaPlata.TabStop = true;
            rbtnLaPlata.Text = "La Plata";
            rbtnLaPlata.UseVisualStyleBackColor = true;
            rbtnLaPlata.CheckedChanged += rbtnLaPlata_CheckedChanged;
            // 
            // rbtnGutierrez
            // 
            rbtnGutierrez.AutoSize = true;
            rbtnGutierrez.Location = new Point(16, 47);
            rbtnGutierrez.Name = "rbtnGutierrez";
            rbtnGutierrez.Size = new Size(72, 19);
            rbtnGutierrez.TabIndex = 1;
            rbtnGutierrez.TabStop = true;
            rbtnGutierrez.Text = "Gutierrez";
            rbtnGutierrez.UseVisualStyleBackColor = true;
            rbtnGutierrez.CheckedChanged += rbtnGutierrez_CheckedChanged;
            // 
            // rbtnChascomus
            // 
            rbtnChascomus.AutoSize = true;
            rbtnChascomus.Location = new Point(16, 72);
            rbtnChascomus.Name = "rbtnChascomus";
            rbtnChascomus.Size = new Size(87, 19);
            rbtnChascomus.TabIndex = 2;
            rbtnChascomus.TabStop = true;
            rbtnChascomus.Text = "Chascomus";
            rbtnChascomus.UseVisualStyleBackColor = true;
            rbtnChascomus.CheckedChanged += rbtnChascomus_CheckedChanged;
            // 
            // rbtnCañuelas
            // 
            rbtnCañuelas.AutoSize = true;
            rbtnCañuelas.Location = new Point(16, 97);
            rbtnCañuelas.Name = "rbtnCañuelas";
            rbtnCañuelas.Size = new Size(73, 19);
            rbtnCañuelas.TabIndex = 3;
            rbtnCañuelas.TabStop = true;
            rbtnCañuelas.Text = "Cañuelas";
            rbtnCañuelas.UseVisualStyleBackColor = true;
            rbtnCañuelas.CheckedChanged += rbtnCañuelas_CheckedChanged;
            // 
            // rbtnHaedo
            // 
            rbtnHaedo.AutoSize = true;
            rbtnHaedo.Location = new Point(16, 122);
            rbtnHaedo.Name = "rbtnHaedo";
            rbtnHaedo.Size = new Size(60, 19);
            rbtnHaedo.TabIndex = 4;
            rbtnHaedo.TabStop = true;
            rbtnHaedo.Text = "Haedo";
            rbtnHaedo.UseVisualStyleBackColor = true;
            rbtnHaedo.CheckedChanged += rbtnHaedo_CheckedChanged;
            // 
            // gbRamales
            // 
            gbRamales.Controls.Add(rbtnHaedo);
            gbRamales.Controls.Add(rbtnCañuelas);
            gbRamales.Controls.Add(rbtnChascomus);
            gbRamales.Controls.Add(rbtnGutierrez);
            gbRamales.Controls.Add(rbtnLaPlata);
            gbRamales.Location = new Point(12, 12);
            gbRamales.Name = "gbRamales";
            gbRamales.Size = new Size(145, 160);
            gbRamales.TabIndex = 1;
            gbRamales.TabStop = false;
            gbRamales.Text = "Ramales";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(12, 184);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(71, 15);
            lbl5.TabIndex = 2;
            lbl5.Text = "Elejir Origen";
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Items.AddRange(new object[] { "Alejandro Korn", "Guernica", "Glew", "Burzaco" });
            cbDestino.Location = new Point(12, 266);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(145, 23);
            cbDestino.TabIndex = 3;
            cbDestino.SelectedIndexChanged += cbDestino_SelectedIndexChanged;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(12, 248);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(75, 15);
            lbl6.TabIndex = 4;
            lbl6.Text = "Elejir Destino";
            // 
            // btnViajar
            // 
            btnViajar.Location = new Point(12, 327);
            btnViajar.Name = "btnViajar";
            btnViajar.Size = new Size(145, 47);
            btnViajar.TabIndex = 5;
            btnViajar.Text = "Viajar";
            btnViajar.UseVisualStyleBackColor = true;
            btnViajar.Click += btnViajar_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigen.Location = new Point(170, 329);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(143, 20);
            lblOrigen.TabIndex = 7;
            lblOrigen.Text = "Origen";
            lblOrigen.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDestino
            // 
            lblDestino.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestino.Location = new Point(605, 329);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(143, 20);
            lblDestino.TabIndex = 8;
            lblDestino.Text = "Destino";
            lblDestino.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(319, 332);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(280, 15);
            lbl3.TabIndex = 9;
            lbl3.Text = "----------------------------------------------------->";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(377, 347);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(121, 17);
            lbl2.TabIndex = 10;
            lbl2.Text = "Gasto Aproximado:";
            // 
            // lblGasto
            // 
            lblGasto.AutoSize = true;
            lblGasto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGasto.Location = new Point(492, 347);
            lblGasto.Name = "lblGasto";
            lblGasto.Size = new Size(22, 17);
            lblGasto.TabIndex = 11;
            lblGasto.Text = "$0";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 377);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 12;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // ViajarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 410);
            Controls.Add(lblError);
            Controls.Add(lblGasto);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(pictureBox1);
            Controls.Add(btnViajar);
            Controls.Add(lbl6);
            Controls.Add(cbDestino);
            Controls.Add(lbl5);
            Controls.Add(gbRamales);
            Controls.Add(cbOrigen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViajarMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViajarMenu";
            Load += ViajarMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbRamales.ResumeLayout(false);
            gbRamales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox cbOrigen;
        private RadioButton rbtnLaPlata;
        private RadioButton rbtnGutierrez;
        private RadioButton rbtnChascomus;
        private RadioButton rbtnCañuelas;
        private RadioButton rbtnHaedo;
        private GroupBox gbRamales;
        private Label label1;
        private ComboBox cbDestino;
        private Label label2;
        private Button btnViajar;
        private Label lblOrigen;
        private Label lblDestino;
        private Label label3;
        private Label label4;
        private Label lblGasto;
        private Label lblError;
        private Label lbl5;
        private Label lbl6;
        private Label lbl3;
        private Label lbl2;
    }
}