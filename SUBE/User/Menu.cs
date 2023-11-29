using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using SUBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Interface
{
    public partial class Menu : Form
    {
        private UserDetails _userDetails;
        private ActivarSube _activarSube;
        private ViajarMenu _viajarMenu;
        private Person Persona;
        private List<Person> _listaPersonas;
        private Configuracion _configuracion;
        private Config Settings;
        private Contacto _contacto;

        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.MdiParent = this;
            menuInicial.Show();
        }

        public void RecivirPersona(Person persona)
        {
            this.Persona = persona;
        }

        public void PaintLabel(Control control)
        {
            if (control is Label)
            {
                Label lbl = (Label)control;
                if (lbl.Name.StartsWith("lbl"))
                    lbl.ForeColor = Settings.FontColor;
            }
            else
            {
                foreach (Control child in control.Controls)
                {
                    PaintLabel(child);
                }
            }
        }
        private void activarSubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCRUD personCRUD = new PersonCRUD();
                Persona = personCRUD.GetByPK(Persona.username);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                ActivarSube = new ActivarSube(Persona, PaintLabel, Settings);
                ActivarSube.MdiParent = this;
                ActivarSube.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCRUD personCRUD = new PersonCRUD();
                Persona = personCRUD.GetByPK(Persona.username);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                UserDetails = new UserDetails(Persona, PaintLabel, Settings);
                UserDetails.MdiParent = this;
                UserDetails.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void viajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCRUD personCRUD = new PersonCRUD();
                Persona = personCRUD.GetByPK(Persona.username);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                ViajarMenu = new ViajarMenu(Persona, PaintLabel, Settings);
                ViajarMenu.MdiParent = this;
                ViajarMenu.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCRUD personCRUD = new PersonCRUD();
                Persona = personCRUD.GetByPK(Persona.username);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                Configuracion = new Configuracion(Persona);
                Configuracion.MdiParent = this;
                Configuracion.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCRUD personCRUD = new PersonCRUD();
                Persona = personCRUD.GetByPK(Persona.username);

                Settings = ControladoraAdmin.HandleLeerConfig(Persona);

                Contacto = new Contacto(Persona, PaintLabel, Settings);
                Contacto.MdiParent = this;
                Contacto.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        public UserDetails UserDetails { get => _userDetails; set => _userDetails = value; }
        public ActivarSube ActivarSube { get => _activarSube; set => _activarSube = value; }
        public List<Person> ListaPersonas { get => _listaPersonas; set => _listaPersonas = value; }
        public ViajarMenu ViajarMenu { get => _viajarMenu; set => _viajarMenu = value; }
        public Contacto Contacto { get => _contacto; set => _contacto = value; }
        public Configuracion Configuracion { get => _configuracion; set => _configuracion = value; }
    }
}
