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
    }
}
