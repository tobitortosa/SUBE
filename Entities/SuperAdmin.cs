using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class SuperAdmin : Admin
    {
        public SuperAdmin(string nombre, string apellido, string email, string password, string userName) : base(nombre, apellido, email, password, userName)
        {

        }


        public static void HandleAdminState(Person user, bool estado)
        {
            List<Person> listaCompleta;
            string ruta;
            string path;
            string nombreArchivo;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\personas.xml";
            path = ruta + nombreArchivo;

            FileExist(path);

            listaCompleta = Serializadora.LeerPersonaXML(path);

            foreach (Person persona in listaCompleta)
            {
                if (persona.Username == user.Username)
                {
                    persona.IsAdmin = estado;
                }
            }
        }

        private static void FileExist(string path)
        {
            List<Person> listaVacia;
            listaVacia = new List<Person>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirPersonaXML(path, listaVacia);
            }
        }
    }
}
