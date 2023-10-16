namespace Interface
{
    partial class AdminMenu
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
            menuStrip1 = new MenuStrip();
            sUBESToolStripMenuItem = new ToolStripMenuItem();
            pETICIONESDECARGASToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(700, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Admin Menu";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sUBESToolStripMenuItem, pETICIONESDECARGASToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // sUBESToolStripMenuItem
            // 
            sUBESToolStripMenuItem.Name = "sUBESToolStripMenuItem";
            sUBESToolStripMenuItem.Size = new Size(52, 20);
            sUBESToolStripMenuItem.Text = "SUBES";
            // 
            // pETICIONESDECARGASToolStripMenuItem
            // 
            pETICIONESDECARGASToolStripMenuItem.Name = "pETICIONESDECARGASToolStripMenuItem";
            pETICIONESDECARGASToolStripMenuItem.Size = new Size(64, 20);
            pETICIONESDECARGASToolStripMenuItem.Text = "CARGAS";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdminMenu";
            Text = "AdminMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sUBESToolStripMenuItem;
        private ToolStripMenuItem pETICIONESDECARGASToolStripMenuItem;
    }
}