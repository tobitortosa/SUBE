using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _password;
        private string _username;
        private bool _isAdmin;

        public User()
        {

        }

        public User(string nombre, string apellido, string email, string password, string username)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Password = password;
            this.Username = username;
            this.IsAdmin = false;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} Apellido: {this.Apellido} Username: {this.Username} IsAdmin: {this.IsAdmin}";
        }

        public static bool AddPerson(Person user)
        {
            List<Person> listaCompleta;
            string ruta;
            string path;
            bool res;
            string nombreArchivo;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\personas.xml";
            path = ruta + nombreArchivo;
            res = false;

            FileExist(path);
            listaCompleta = Serializadora.LeerPersonaXML(path);

            foreach (Person persona in listaCompleta)
            {
                if (persona.Username == user.Username)
                {
                    res = true;
                }
            }

            if (!res)
            {
                listaCompleta.Add(user);
                Serializadora.EscribirPersonaXML(path, listaCompleta);
            }

            return res;
        }

        public static (bool, Person) Login(string username, string password)
        {
            List<Person> listaCompleta;
            bool logStatus;
            Person logPerson;
            string nombreArchivo;
            string ruta;
            string path;

            logPerson = null;
            logStatus = true;
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\personas.xml";
            path = ruta + nombreArchivo;

            FileExist(path);

            listaCompleta = Serializadora.LeerPersonaXML(path);

            foreach (Person persona in listaCompleta)
            {
                if (persona.Password == password && persona.Username == username)
                {
                    logStatus = false;
                    logPerson = persona;
                }
            }

            return (logStatus, logPerson);
        }

        public static void FileExist(string path)
        {
            List<Person> listaVacia;
            listaVacia = new List<Person>();

            if (!File.Exists(path))
            {
                Serializadora.EscribirPersonaXML(path, listaVacia);
            }
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Username { get => _username; set => _username = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
    }
}
