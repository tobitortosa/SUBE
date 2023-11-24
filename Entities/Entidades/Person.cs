using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class Person
    {
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool ban { get; set; }
        public string ban_text { get; set; }
        public bool admin { get; set; }

        public Person()
        {

        }

        public Person(string username, string nombre, string apellido, string email, string password, bool ban, string banText, bool admin)
        {
            this.username = username;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.password = password;
            this.ban = ban;
            ban_text = banText;
            this.admin = admin;
        }
    }
}
