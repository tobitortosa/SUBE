using Entities;
using SUBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private CargarSube _cargarSube;
        private Contact _contacto;

        private Person _person;
        private string _ruta;
        private string _nombreArchivoSubes;
        private string _nombreArchivoPersonas;
        private List<Person> _listaPersonas;


        public Menu(Person person)
        {
            InitializeComponent();
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            NombreArchivoPersonas = @"\personas.xml";

            this.IsMdiContainer = true;
            this.Person = person;

            UserDetails = new UserDetails(person);
            ActivarSube = new ActivarSube(person);
            ViajarMenu = new ViajarMenu(person);
            CargarSube = new CargarSube();
            Contacto = new Contact();


            UserDetails.MdiParent = this;
            ActivarSube.MdiParent = this;
            ViajarMenu.MdiParent = this;
            CargarSube.MdiParent = this;
            Contacto.MdiParent = this;

            UserDetails.Show();

            CargarSube.Close();
            ActivarSube.Close();
            Contacto.Close();
            ViajarMenu.Close();
        }
        private void activarSubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathPerson;
            pathPerson = Ruta + NombreArchivoPersonas;

            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);
            foreach (Person person in ListaPersonas)
            {
                if (person.Username == Person.Username)
                {
                    ActivarSube = new ActivarSube(person);
                    ActivarSube.MdiParent = this;

                    ActivarSube.Show();

                    CargarSube.Close();
                    Contacto.Close();
                    UserDetails.Close();
                    ViajarMenu.Close();
                }
            }

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathPerson;
            pathPerson = Ruta + NombreArchivoPersonas;

            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);

            foreach (Person person in ListaPersonas)
            {
                if (person.Username == Person.Username)
                {
                    UserDetails = new UserDetails(person);
                    UserDetails.MdiParent = this;

                    UserDetails.Show();

                    ActivarSube.Close();
                    Contacto.Close();
                    ViajarMenu.Close();
                    CargarSube.Close();
                }
            }
        }

        private void viajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathPerson;
            pathPerson = Ruta + NombreArchivoPersonas;

            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);

            foreach (Person person in ListaPersonas)
            {
                if (person.Username == Person.Username)
                {
                    ViajarMenu = new ViajarMenu(person);
                    ViajarMenu.MdiParent = this;

                    ViajarMenu.Show();

                    ActivarSube.Close();
                    Contacto.Close();
                    UserDetails.Close();
                    CargarSube.Close();
                }
            }
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void cargarSubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathPerson;
            pathPerson = Ruta + NombreArchivoPersonas;

            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);

            foreach (Person person in ListaPersonas)
            {
                if (person.Username == Person.Username)
                {
                    CargarSube = new CargarSube();
                    CargarSube.MdiParent = this;

                    CargarSube.Show();

                    ActivarSube.Close();
                    Contacto.Close();
                    UserDetails.Close();
                    ViajarMenu.Close();
                }
            }
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathPerson;
            pathPerson = Ruta + NombreArchivoPersonas;

            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);

            foreach (Person person in ListaPersonas)
            {
                if (person.Username == Person.Username)
                {
                    Contacto = new Contact();
                    Contacto.MdiParent = this;

                    Contacto.Show();

                    ActivarSube.Close();
                    CargarSube.Close();
                    UserDetails.Close();
                    ViajarMenu.Close();
                }
            }
        }

        public Person Person { get => _person; set => _person = value; }
        public UserDetails UserDetails { get => _userDetails; set => _userDetails = value; }
        public ActivarSube ActivarSube { get => _activarSube; set => _activarSube = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public string NombreArchivoSubes { get => _nombreArchivoSubes; set => _nombreArchivoSubes = value; }
        public string NombreArchivoPersonas { get => _nombreArchivoPersonas; set => _nombreArchivoPersonas = value; }
        public List<Person> ListaPersonas { get => _listaPersonas; set => _listaPersonas = value; }
        public ViajarMenu ViajarMenu { get => _viajarMenu; set => _viajarMenu = value; }
        public CargarSube CargarSube { get => _cargarSube; set => _cargarSube = value; }
        public Contact Contacto { get => _contacto; set => _contacto = value; }
    }
}
