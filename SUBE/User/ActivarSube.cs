using Entities;
using Entities.CRUDs;
using Entities.Entidades;
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
        private List<Sube> _subes;
        private List<Sube> _listaFiltrada;
        private List<Person> _listaPersonas;
        private Person _persona;
        private Sube _selectedSube;


        public bool IsNumeroTarjetaCorrect { get => _IsNumeroTarjetaCorrect; set => _IsNumeroTarjetaCorrect = value; }
        public bool IsCodigoSeguridadCorrect { get => _IsCodigoSeguridadCorrect; set => _IsCodigoSeguridadCorrect = value; }
        public Person Persona { get => _persona; set => _persona = value; }
        public bool IsUsuarioCorrect { get => _IsUsuarioCorrect; set => _IsUsuarioCorrect = value; }
        public bool IsContraseñaCorrect { get => _IsContraseñaCorrect; set => _IsContraseñaCorrect = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }
        public List<Sube> Subes { get => _subes; set => _subes = value; }
        public List<Person> ListaPersonas { get => _listaPersonas; set => _listaPersonas = value; }
        public List<Sube> ListaFiltrada { get => _listaFiltrada; set => _listaFiltrada = value; }

        public ActivarSube(Person persona, Action<Control> PaintLabel, Config settings)
        {
            InitializeComponent();
            IsNumeroTarjetaCorrect = false;
            IsCodigoSeguridadCorrect = false;
            IsUsuarioCorrect = false;
            IsContraseñaCorrect = false;

            Persona = persona;

            this.BackColor = settings.BackgroundColor;
            PaintLabel(this);

            SubeCRUD subeCRUD = new SubeCRUD();
            List<Sube> listaSubes = subeCRUD.GetByFK(Persona.username);

            if (listaSubes.Count == 4)
            {
                this.Enabled = false;
            }
        }

        private void txtCodigoSeguridad_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }


        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
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

            lblError.Visible = false;
            Subes = Select<Sube>.SelectAll("sube");
            ListaFiltrada = new List<Sube>();

            foreach (Sube sube in Subes)
            {
                if (sube.numeroDeTarjeta == numeroTarjetaFinal || sube.codigoDeSeguridad == txtCodigoSeguridad.Text)
                {
                    ListaFiltrada.Add(sube);
                }
            }
            if ((Persona.username != txtNombreUsuario.Text && Persona.password != txtContraseña.Text) || Persona.username != txtNombreUsuario.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Usuario o contraseña incorrectos";
            }
            else if (Persona.password != txtContraseña.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Contraseña incorrecta";
            }
            else if (ListaFiltrada.Count == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Tarjeta inexistente";
            }
            else if (ListaFiltrada[0].numeroDeTarjeta != numeroTarjetaFinal)
            {
                lblError.Visible = true;
                lblError.Text = "Numero de tarjeta incorrecto";
            }
            else if (ListaFiltrada[0].codigoDeSeguridad != txtCodigoSeguridad.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Codigo incorrecto";
            }
            else if (ListaFiltrada[0].activada)
            {
                lblError.Visible = true;
                lblError.Text = "Tarjeta ya activada";
            }
            else
            {
                ControladoraAdmin controlAdmin = new ControladoraAdmin();   
                controlAdmin.TarjetaActivada += controlAdmin.EnvioMailTarjetaActivada;
                bool res = controlAdmin.ActivarTarjeta(Persona, ListaFiltrada);

                if (res)
                {
                    lblActivada.Text = "Tarjeta Activada";
                    lblActivada.Visible = true;
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
