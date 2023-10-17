using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Admin
{
    public partial class AdminCreateSube : Form
    {
        private string _numeroTarjeta;
        private string _codigoDeSeguridad;
        private string _adminCreador;

        public AdminCreateSube(Person admin)
        {
            InitializeComponent();

            string ruta;
            string path;
            string nombreArchivo;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\subes.xml";
            path = ruta + nombreArchivo;

            List<Sube> listaCompleta;

            Sube.FileExist(path);

            listaCompleta = Serializadora.LeerSubeXML(path);


            NumeroTarjeta = CrearCodigoTarjeta(listaCompleta);
            lblNumeroSube.Text = NumeroTarjeta;

            CodigoDeSeguridad = CrearCodigoSeguridad(listaCompleta);
            lblCodigoDeSeguridad.Text = CodigoDeSeguridad;

            AdminCreador = admin.Username;
            lblUsernameAdmin.Text = AdminCreador;

            DateTime dateTime = DateTime.Now;

            lblFechaDeCreacion.Text = dateTime.ToString();
        }

        private void btnCrearSube_Click(object sender, EventArgs e)
        {
            Sube nuevaSube;
            nuevaSube = new Sube(NumeroTarjeta, CodigoDeSeguridad, AdminCreador);

            Sube.CrearSube(nuevaSube);
            DialogResult = DialogResult.OK;
        }

        private string CrearCodigoTarjeta(List<Sube> listaCompleta)
        {
            string codigo;

            Random rnd = new Random();


            string primerosNumeros;
            string segundosNumeros;
            string tercerosNumeros;
            string cuartosNumeros;

            primerosNumeros = "";
            segundosNumeros = "";
            tercerosNumeros = "";
            cuartosNumeros = "";

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                primerosNumeros += numero.ToString(); 
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                segundosNumeros += numero.ToString();
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                tercerosNumeros += numero.ToString();
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                cuartosNumeros += numero.ToString();
            }

            codigo = $"{primerosNumeros} {segundosNumeros} {tercerosNumeros} {cuartosNumeros}";
            
            foreach (Sube sube in listaCompleta)
            {
                if (sube.NumeroDeTarjeta == codigo)
                {
                    CrearCodigoTarjeta(listaCompleta);
                }
            }

            return codigo;
        }

        private string CrearCodigoSeguridad(List<Sube> listaCompleta)
        {
            string codigoSeguridad;
            string codigo;
            Random rnd;

            codigo = "";
            
            rnd = new Random();
            for (int j = 0; j < 8; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                codigo += numero.ToString();
            }


            foreach (Sube sube in listaCompleta)
            {
                if (sube.CodigoDeSeguridad == codigo)
                {
                    CrearCodigoSeguridad(listaCompleta);
                }
            }

            return codigo;
        }


        public string NumeroTarjeta { get => _numeroTarjeta; set => _numeroTarjeta = value; }
        public string CodigoDeSeguridad { get => _codigoDeSeguridad; set => _codigoDeSeguridad = value; }
        public string AdminCreador { get => _adminCreador; set => _adminCreador = value; }
    }
}
