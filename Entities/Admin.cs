using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin : User
    {

        public Admin(string nombre, string apellido, string email, string password, string userName) : base(nombre, apellido, email, password, userName)
        {
        }


        public void EliminarPersona(Person person)
        {
            List<Person> list;
            List<Person> listFiltrada;

            listFiltrada = new List<Person>();

            Person p = new Person();

            list = Person.ListaCompleta();

            foreach (Person persona in list)
            {
                if (persona != person)
                {
                    listFiltrada.Add(persona);
                }
            }

            Serializadora.EscribirPersonaXML(person.Path, listFiltrada);
        }
    }
}
