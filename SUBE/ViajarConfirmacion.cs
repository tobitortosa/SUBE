using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class ViajarConfirmacion : Form
    {
        private Person _persona;
        private Sube _selectedSube;
        private string _ruta;
        private List<Sube> _allSubes;
        private double _costo;
        private string _origen;
        private string _destino;

        public ViajarConfirmacion(string origen, string destino, double costo, Person persona)
        {
            InitializeComponent();
            lblOrigen.Text = origen;
            lblDestino.Text = destino;
            lblCosto.Text = "$" + costo.ToString();

            Origen = origen;
            Destino = destino;


            Persona = persona;
            SelectedSube = Persona.ListaSube[0];
            Costo = costo;

            ImprimirSube(SelectedSube);

            AllSubes = Sube.ListaCompleta();

            cbSube.Items.Clear();
            foreach (Sube sube in persona.ListaSube)
            {
                cbSube.Items.Add(sube.NumeroDeTarjeta);
            }

            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";

        }

        public Person Persona { get => _persona; set => _persona = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public List<Sube> AllSubes { get => _allSubes; set => _allSubes = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public string Origen { get => _origen; set => _origen = value; }
        public string Destino { get => _destino; set => _destino = value; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<Person> persons;
            persons = Person.ListaCompleta();

            List<Person> personFiltradas;
            personFiltradas = new List<Person>();

            Person personaElejida;
            personaElejida = new Person();

            foreach (Person person in persons)
            {
                if (person.Username != Persona.Username)
                {
                    personFiltradas.Add(person);
                }
                else
                {
                    personaElejida = person;
                }
            }


            List<Sube> subeFiltrada;
            subeFiltrada = new List<Sube>();

            Sube subeElejida1;
            subeElejida1 = new Sube();

            foreach (Sube su in personaElejida.ListaSube)
            {
                if (su.NumeroDeTarjeta != SelectedSube.NumeroDeTarjeta)
                {
                    subeFiltrada.Add(su);
                }
                else
                {
                    subeElejida1 = su;
                }
            }

            if (subeElejida1.Saldo - Costo > 0)
            {
                Viaje nuevoViaje = new Viaje(Origen, Destino, Costo, DateTime.Now, subeElejida1.Saldo);
                subeElejida1.Saldo -= Costo;
                personaElejida.ListaViajes.Add(nuevoViaje);
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Saldo insuficiente";
            }


            subeFiltrada.Add(subeElejida1);
            personaElejida.ListaSube = subeFiltrada;
            personFiltradas.Add(personaElejida);

            Serializadora.EscribirPersonaXML(Ruta + @"\personas.xml", personFiltradas);









            List<Sube> listaFiltrada;
            listaFiltrada = new List<Sube>();
            Sube subeElejida;
            subeElejida = new Sube();

            string path;
            path = Ruta + @"\subes.xml";

            foreach (Sube sube in AllSubes)
            {
                if (sube.NumeroDeTarjeta != SelectedSube.NumeroDeTarjeta)
                {
                    listaFiltrada.Add(sube);
                }
                else
                {
                    subeElejida = sube;
                }
            }

            if (subeElejida.Saldo - Costo > 0)
            {
                subeElejida.Saldo -= Costo;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Saldo insuficiente";
            }

            listaFiltrada.Add(subeElejida);

            AllSubes = listaFiltrada;
            Serializadora.EscribirSubeXML(path, listaFiltrada);
        }
        private void ViajarConfirmacion_Load(object sender, EventArgs e)
        {
            cbSube.SelectedItem = null;
            cbSube.SelectedText = SelectedSube.NumeroDeTarjeta;
        }

        private void cbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Sube sube in Persona.ListaSube)
            {
                if (sube.NumeroDeTarjeta == cbSube.Text)
                {
                    SelectedSube = sube;
                }
            }
            ImprimirSube(SelectedSube);
        }

        private void ImprimirSube(Sube sube)
        {
            lblNumeroSube.Text = sube.NumeroDeTarjeta;
            lblSaldo.Text = "$" + sube.Saldo.ToString();
            lblUsuarioPropietario.Text = sube.NombreCompletoPropietario;
        }
    }
}
