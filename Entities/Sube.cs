using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Sube
    {
       // private DateOnly _createdDate;
        private string _numeroDeTarjeta;
        private string _codigoDeSeguridad;
        private string _usernameAdminCreador;
        private double _saldo;
        private bool _activada;
        private string _nombreCompletoPropietario;
        private string _usernamePropietario;
        private DateTime _diaCreada;
        private string _ruta;
        private string _nombreArchivo;
        private string _path;

        public Sube()
        {
           
        }

        public Sube(string numeroDeTarjeta, string codigoDeSeguridad, string adminCreador)
        {
            NumeroDeTarjeta = numeroDeTarjeta;
            CodigoDeSeguridad = codigoDeSeguridad;
            Activada = false;
            UsernameAdminCreador = adminCreador;
            Saldo = 500;
            DiaCreada = DateTime.Now;
            NombreCompletoPropietario = "";
            UsernamePropietario = "";
        }
        public static List<Sube> ListaCompleta()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            string nombreArchivo = @"\subes.xml";
            string path = ruta + nombreArchivo;

            List<Sube> lista;
            lista = Serializadora.LeerSubeXML(path);
            FileExist(path);
            return lista;
        }

        public static void CrearSube(Sube sube)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            string nombreArchivo = @"\subes.xml";
            string path = ruta + nombreArchivo;

            List<Sube> listaCompleta;
            listaCompleta = ListaCompleta();
            listaCompleta.Add(sube);
            Serializadora.EscribirSubeXML(path, listaCompleta);
        }

        public static void FileExist(string path)
        {
            List<Sube> listaVacia;
            listaVacia = new List<Sube>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirSubeXML(path, listaVacia);
            }
        }

        public string NumeroDeTarjeta { get => _numeroDeTarjeta; set => _numeroDeTarjeta = value; }
        public string UsernameAdminCreador { get => _usernameAdminCreador; set => _usernameAdminCreador = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string CodigoDeSeguridad { get => _codigoDeSeguridad; set => _codigoDeSeguridad = value; }
        public bool Activada { get => _activada; set => _activada = value; }
        public DateTime DiaCreada { get => _diaCreada; set => _diaCreada = value; }
        public string NombreCompletoPropietario { get => _nombreCompletoPropietario; set => _nombreCompletoPropietario = value; }
        public string UsernamePropietario { get => _usernamePropietario; set => _usernamePropietario = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public string NombreArchivo { get => _nombreArchivo; set => _nombreArchivo = value; }
        public string Path { get => _path; set => _path = value; }
    }
}
