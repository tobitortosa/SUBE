using Entities;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Configuracion : Form
    {
        private Person _persona;
        private Config _settings;

        public Configuracion(Person persona)
        {
            InitializeComponent();
            Persona = persona;

            try
            {
                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                if (Settings != null)
                {
                    panelFondo.BackColor = Settings.BackgroundColor;
                    panelFuente.BackColor = Settings.FontColor;
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        public Person Persona { get => _persona; set => _persona = value; }
        public Config Settings { get => _settings; set => _settings = value; }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = panelFondo.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelFondo.BackColor = cd.Color;
                Controladora.HandleEscribirConfig(cd.Color, Persona, true);
                Settings = ControladoraAdmin.HandleLeerConfig(Persona);
            }
        }

        private void cambiarFColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = panelFuente.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelFuente.BackColor = cd.Color;
                Controladora.HandleEscribirConfig(cd.Color, Persona, false);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dialog.FileName.ToString();
                    string path = Path.Combine(@"-\image\");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var fileName = Path.GetFileName(dialog.FileName);
                    path = path + fileName;
                    File.Copy(dialog.FileName, path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Controladora.HandleException(ex);
            }
        }
    }
}
