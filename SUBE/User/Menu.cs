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
        private Person _person;
        private List<Person> _listaPersonas;
        private Configuracion _configuracion;
        private Config _settings;

        public Menu(Person person)
        {
            InitializeComponent();

            IsMdiContainer = true;

            Person = person;
            Settings = Controladora.HandleLeerConfig(Person);

            UserDetails = new UserDetails(Person, PaintLabel, Settings);
            ActivarSube = new ActivarSube(Person, PaintLabel, Settings);
            ViajarMenu = new ViajarMenu(Person, PaintLabel, Settings);
            Configuracion = new Configuracion(Person);

            UserDetails.MdiParent = this;
            ActivarSube.MdiParent = this;
            ViajarMenu.MdiParent = this;
            Configuracion.MdiParent = this;

            UserDetails.Show();
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
                Person = personCRUD.GetByPK(Person.username);

                Settings = Controladora.HandleLeerConfig(Person);

                ActivarSube = new ActivarSube(Person, PaintLabel, Settings);
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
                Person = personCRUD.GetByPK(Person.username);

                Settings = Controladora.HandleLeerConfig(Person);

                UserDetails = new UserDetails(Person, PaintLabel, Settings);
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
                Person = personCRUD.GetByPK(Person.username);

                Settings = Controladora.HandleLeerConfig(Person);

                ViajarMenu = new ViajarMenu(Person, PaintLabel, Settings);
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
                Person = personCRUD.GetByPK(Person.username);

                Settings = Controladora.HandleLeerConfig(Person);

                Configuracion = new Configuracion(Person);
                Configuracion.MdiParent = this;
                Configuracion.Show();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        public Person Person { get => _person; set => _person = value; }
        public UserDetails UserDetails { get => _userDetails; set => _userDetails = value; }
        public ActivarSube ActivarSube { get => _activarSube; set => _activarSube = value; }
        public List<Person> ListaPersonas { get => _listaPersonas; set => _listaPersonas = value; }
        public ViajarMenu ViajarMenu { get => _viajarMenu; set => _viajarMenu = value; }
        public Configuracion Configuracion { get => _configuracion; set => _configuracion = value; }
        public Config Settings { get => _settings; set => _settings = value; }
    }
}
