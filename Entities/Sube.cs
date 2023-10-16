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
        private DateTime _diaCreada;

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
        }

        public static void CrearSube(Sube sube)
        {
            List<Sube> listaCompleta;
            string ruta;
            string path;
            string nombreArchivo;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\subes.xml";
            path = ruta + nombreArchivo;

            FileExist(path);

            listaCompleta = Serializadora.LeerSubeXML(path);

            listaCompleta.Add(sube);
            Serializadora.EscribirSubeXML(path, listaCompleta);
        }

        public static bool ActivarSube(Sube sube)
        {
            List<Sube> listaCompleta;

            string ruta;
            string path;
            bool res;
            string nombreArchivo;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\subes.xml";
            path = ruta + nombreArchivo;
            res = false;

            FileExist(path);

            listaCompleta = Serializadora.LeerSubeXML(path);

            foreach (Sube s in listaCompleta)
            {
                if (sube.NumeroDeTarjeta == s.NumeroDeTarjeta && sube.CodigoDeSeguridad == s.CodigoDeSeguridad)
                {
                    s.Activada = true;
                    res = false;
                }
            }

            /*if (!res)
            {
                listaCompleta.Add(sube);
                Serializadora.EscribirSubeXML(path, listaCompleta);

            }*/

            return res;
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
    }
}
