using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class ActivarSube : Form
    {
        private bool _IsNumeroTarjetaCorrect;
        private bool _IsCodigoSeguridadCorrect;
        private bool _IsUsuarioCorrect;
        private bool _IsContraseñaCorrect;


        private string _ruta;
        private string _nombreArchivoSubes;
        private string _nombreArchivoPersonas;
        private List<Sube> _subes;
        private List<Sube> _listaFiltrada;
        private List<Person> _listaPersonas;
        private Person _persona;
        private Sube _selectedSube;


        public bool IsNumeroTarjetaCorrect { get => _IsNumeroTarjetaCorrect; set => _IsNumeroTarjetaCorrect = value; }
        public bool IsCodigoSeguridadCorrect { get => _IsCodigoSeguridadCorrect; set => _IsCodigoSeguridadCorrect = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public string NombreArchivoSubes { get => _nombreArchivoSubes; set => _nombreArchivoSubes = value; }
        public Person Persona { get => _persona; set => _persona = value; }
        public bool IsUsuarioCorrect { get => _IsUsuarioCorrect; set => _IsUsuarioCorrect = value; }
        public bool IsContraseñaCorrect { get => _IsContraseñaCorrect; set => _IsContraseñaCorrect = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }
        public List<Sube> Subes { get => _subes; set => _subes = value; }
        public List<Person> ListaPersonas { get => _listaPersonas; set => _listaPersonas = value; }
        public string NombreArchivoPersonas { get => _nombreArchivoPersonas; set => _nombreArchivoPersonas = value; }
        public List<Sube> ListaFiltrada { get => _listaFiltrada; set => _listaFiltrada = value; }

        public ActivarSube(Person persona)
        {
            InitializeComponent();
            IsNumeroTarjetaCorrect = false;
            IsCodigoSeguridadCorrect = false;
            IsUsuarioCorrect = false;
            IsContraseñaCorrect = false;

            Persona = persona;
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";

            NombreArchivoSubes = @"\subes.xml";
            NombreArchivoPersonas = @"\personas.xml";

            string pathSube;
            string pathPerson;

            pathSube = Ruta + NombreArchivoSubes;
            pathPerson = Ruta + NombreArchivoPersonas;

            Sube.FileExist(pathSube);
            User.FileExist(pathPerson);


            ListaFiltrada = new List<Sube>();
            Subes = Serializadora.LeerSubeXML(pathSube);
            ListaPersonas = Serializadora.LeerPersonaXML(pathPerson);

            if (persona.ListaSube.Count == 4)
            {
                this.Enabled = false;
            }
        }

        private void txtCodigoSeguridad_TextChanged(object sender, EventArgs e)
        {
            bool isNumber;
            string input;

            input = txtCodigoSeguridad.Text;

            isNumber = input.All(char.IsDigit);

            if (isNumber && input.Length <= 8)
            {
                IsCodigoSeguridadCorrect = true;
            }
        }


        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            bool isNumber;
            string finalString;
            string input;

            input = txtNumeroTarjeta.Text;

            isNumber = input.All(char.IsDigit);
            finalString = "";

            if (isNumber && input.Length <= 16)
            {
                finalString = SepararNumerosTarjetas(input, 2);
            }
            else
            {
                finalString = "Numero invalido.";
            }

            lblNumeroTarjetaSUBE.Text = finalString;
        }

        private string SepararNumerosTarjetas(string numero, int numeroDeEspacios)
        {
            List<char> list;
            string final;
            int contador;

            list = new List<char>();
            final = "";
            contador = 0;


            foreach (char c in numero)
            {
                list.Add(c);
                contador++;

                if (contador == 4 || contador == 8 || contador == 12)
                {
                    for (int i = 0; i < numeroDeEspacios; i++)
                    {
                        list.Add((char)32);
                    }
                }
            }

            foreach (char c in list)
            {
                final += c;
            }

            return final;
        }

        private void btnHandleActivar_Click(object sender, EventArgs e)
        {
            HandleFormErrors();
        }

        private void HandleFormErrors()
        {
            string numeroTarjetaFinal;
            numeroTarjetaFinal = SepararNumerosTarjetas(txtNumeroTarjeta.Text, 1);

            string pathSube;
            pathSube = Ruta + NombreArchivoSubes;

            lblError.Visible = false;
            Subes = Serializadora.LeerSubeXML(pathSube);
            ListaFiltrada = new List<Sube>();

            foreach (Sube sube in Subes)
            {
                if (sube.NumeroDeTarjeta == numeroTarjetaFinal || sube.CodigoDeSeguridad == txtCodigoSeguridad.Text)
                {
                    ListaFiltrada.Add(sube);
                }
            }
            if ((Persona.Username != txtNombreUsuario.Text && Persona.Password != txtContraseña.Text) || Persona.Username != txtNombreUsuario.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Usuario o contraseña incorrectos";
            }
            else if (Persona.Password != txtContraseña.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Contraseña incorrecta";
            }
            else if (ListaFiltrada.Count == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Tarjeta inexistente";
            }
            else if (ListaFiltrada[0].NumeroDeTarjeta != numeroTarjetaFinal)
            {
                lblError.Visible = true;
                lblError.Text = "Numero de tarjeta incorrecto";
            }
            else if (ListaFiltrada[0].CodigoDeSeguridad != txtCodigoSeguridad.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Codigo incorrecto";
            }
            else if (ListaFiltrada[0].Activada)
            {
                lblError.Visible = true;
                lblError.Text = "Tarjeta ya activada";
            }
            else
            {
                string pathPerson;

                ListaFiltrada[0].Activada = true;
                ListaFiltrada[0].NombreCompletoPropietario = $"{Persona.Nombre} {Persona.Apellido}";
                ListaFiltrada[0].UsernamePropietario = Persona.Username;

                foreach (Person person in ListaPersonas)
                {
                    if (person.Username == Persona.Username)
                    {
                        if (person.ListaSube.Count < 4)
                        {
                            person.ListaSube.Add(ListaFiltrada[0]);

                            lblActivada.Visible = true;
                            lblActivada.Text = "Tarjeta Activada";
                            pathPerson = Ruta + @"\personas.xml";

                            Serializadora.EscribirSubeXML(pathSube, Subes);
                            Serializadora.EscribirPersonaXML(pathPerson, ListaPersonas);
                        }
                        else
                        {
                            lblError.Visible = true;
                            lblError.Text = "Alcanzo el maximo numero de tarjetas activadas";
                        }

                    }
                }




            }
        }

    }
}
