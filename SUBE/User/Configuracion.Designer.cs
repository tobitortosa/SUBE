namespace Interface
{
    partial class Configuracion
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
            label1 = new System.Windows.Forms.Label();
            panelFondo = new System.Windows.Forms.Panel();
            btnBGColor = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cambiarFColor = new System.Windows.Forms.Button();
            panelFuente = new System.Windows.Forms.Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Configuracion";
            // 
            // panelFondo
            // 
            panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelFondo.Location = new System.Drawing.Point(18, 22);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new System.Drawing.Size(30, 30);
            panelFondo.TabIndex = 1;
            // 
            // btnBGColor
            // 
            btnBGColor.Location = new System.Drawing.Point(54, 22);
            btnBGColor.Name = "btnBGColor";
            btnBGColor.Size = new System.Drawing.Size(120, 30);
            btnBGColor.TabIndex = 2;
            btnBGColor.Text = "Cambiar Color";
            btnBGColor.UseVisualStyleBackColor = true;
            btnBGColor.Click += btnBGColor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBGColor);
            groupBox1.Controls.Add(panelFondo);
            groupBox1.Location = new System.Drawing.Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(195, 69);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color de Fondo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cambiarFColor);
            groupBox2.Controls.Add(panelFuente);
            groupBox2.Location = new System.Drawing.Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(195, 69);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color de Fuente";
            // 
            // cambiarFColor
            // 
            cambiarFColor.Location = new System.Drawing.Point(54, 22);
            cambiarFColor.Name = "cambiarFColor";
            cambiarFColor.Size = new System.Drawing.Size(120, 30);
            cambiarFColor.TabIndex = 2;
            cambiarFColor.Text = "Cambiar Color";
            cambiarFColor.UseVisualStyleBackColor = true;
            cambiarFColor.Click += cambiarFColor_Click;
            // 
            // panelFuente
            // 
            panelFuente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelFuente.Location = new System.Drawing.Point(18, 22);
            panelFuente.Name = "panelFuente";
            panelFuente.Size = new System.Drawing.Size(30, 30);
            panelFuente.TabIndex = 1;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 410);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Configuracion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Configuracion";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnBGColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cambiarFColor;
        private System.Windows.Forms.Panel panelFuente;
    }
}