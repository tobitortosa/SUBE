using Entities;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                Settings = Controladora.HandleLeerConfig(Persona);

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
                Settings = Controladora.HandleLeerConfig(Persona);
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

                Settings = Controladora.HandleLeerConfig(Persona);
            }
        }
    }
}
