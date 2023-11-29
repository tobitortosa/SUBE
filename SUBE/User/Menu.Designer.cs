using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            activarSubeToolStripMenuItem = new ToolStripMenuItem();
            viajarToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSecionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, activarSubeToolStripMenuItem, viajarToolStripMenuItem, configuracionToolStripMenuItem, contactoToolStripMenuItem, cerrarSecionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "File";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(132, 20);
            menuToolStripMenuItem.Text = "Informacion Personal";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // activarSubeToolStripMenuItem
            // 
            activarSubeToolStripMenuItem.Name = "activarSubeToolStripMenuItem";
            activarSubeToolStripMenuItem.Size = new Size(86, 20);
            activarSubeToolStripMenuItem.Text = "Activar SUBE";
            activarSubeToolStripMenuItem.Click += activarSubeToolStripMenuItem_Click;
            // 
            // viajarToolStripMenuItem
            // 
            viajarToolStripMenuItem.Name = "viajarToolStripMenuItem";
            viajarToolStripMenuItem.Size = new Size(48, 20);
            viajarToolStripMenuItem.Text = "Viajar";
            viajarToolStripMenuItem.Click += viajarToolStripMenuItem_Click;
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 20);
            configuracionToolStripMenuItem.Text = "Configuracion";
            configuracionToolStripMenuItem.Click += configuracionToolStripMenuItem_Click;
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(68, 20);
            contactoToolStripMenuItem.Text = "Contacto";
            contactoToolStripMenuItem.Click += contactoToolStripMenuItem_Click;
            // 
            // cerrarSecionToolStripMenuItem
            // 
            cerrarSecionToolStripMenuItem.Name = "cerrarSecionToolStripMenuItem";
            cerrarSecionToolStripMenuItem.Size = new Size(88, 20);
            cerrarSecionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSecionToolStripMenuItem.Click += cerrarSecionToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem activarSubeToolStripMenuItem;
        private ToolStripMenuItem viajarToolStripMenuItem;
        private ToolStripMenuItem cerrarSecionToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
    }
}