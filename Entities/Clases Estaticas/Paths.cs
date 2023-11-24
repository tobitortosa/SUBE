using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Paths
    {
        private static string Ruta;
        public static string Error;
        public static string LogPerson;
        public static string Configuracion;
        public static string InformeViajes;
        public static string SubeDuplicada;
        static Paths()
        {
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            Error = Ruta + @"\error_logs.txt";
            LogPerson = Ruta + @"\logPerson.json";
            Configuracion = Ruta + @"\config.json";
            InformeViajes = Ruta + @"\InformeViajes.xml";
            SubeDuplicada = Ruta + @"\SubeDuplicada.xml";
        }
    }
}
