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
        private string _username;
        private double _saldo;
        private bool _activada;

        public Sube()
        {
            
        }

        public Sube(string numeroDeTarjeta, string codigoDeSeguridad)
        {
            NumeroDeTarjeta = numeroDeTarjeta;
            CodigoDeSeguridad = codigoDeSeguridad;
            Activada = false;
            Username = "";
            Saldo = 500;
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

        private static void FileExist(string path)
        {
            List<Sube> listaVacia;
            listaVacia = new List<Sube>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirSubeXML(path, listaVacia);
            }
        }
        public string NumeroDeTarjeta { get => _numeroDeTarjeta; set => _numeroDeTarjeta = value; }
        public string Username { get => _username; set => _username = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string CodigoDeSeguridad { get => _codigoDeSeguridad; set => _codigoDeSeguridad = value; }
        public bool Activada { get => _activada; set => _activada = value; }
    }
}
