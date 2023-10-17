using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Person : User
    {
        private List<Sube> _listaSube;
        private string _ruta;
        private string _nombreArchivo;
        private string _path;
        private List<Viaje> _listaViajes;


        public Person()
        {
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            NombreArchivo = @"\personas.xml";
            Path = Ruta + NombreArchivo;
        }

        public Person(string nombre, string apellido, string email, string password, string userName) : base(nombre, apellido, email, password, userName)
        {
            ListaSube = new List<Sube>();
        }

        public void EliminarSubeDePersona(Sube sube, Person persona)
        {
            List<Sube> listaFiltrada;
            listaFiltrada = new List<Sube>();

            foreach (Sube s in persona.ListaSube)
            {
                if(s != sube)
                {
                    listaFiltrada.Add(s);
                }
            }

            persona.ListaSube = listaFiltrada;
        }

        public static List<Person> ListaCompleta()
        {
            string ruta= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            string nombreArchivo= @"\personas.xml";
            string path = ruta + nombreArchivo;

            List<Person> lista;
            lista = Serializadora.LeerPersonaXML(path);
            FileExist(path);
            return lista;
        }

        public List<Sube> ListaSube { get => _listaSube; set => _listaSube = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public string NombreArchivo { get => _nombreArchivo; set => _nombreArchivo = value; }
        public string Path { get => _path; set => _path = value; }
        public List<Viaje> ListaViajes { get => _listaViajes; set => _listaViajes = value; }
    }
}
