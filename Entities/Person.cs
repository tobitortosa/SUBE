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

        public Person()
        {
            
        }

        public Person(string nombre, string apellido, string email, string password, string userName) : base(nombre, apellido, email, password, userName)
        {
            ListaSube = new List<Sube>();
        }
        public List<Sube> ListaSube { get => _listaSube; set => _listaSube = value; }
    }
}
