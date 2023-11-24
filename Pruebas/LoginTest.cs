using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Login_CuandoElUsuarioNoExiste_DeberiaRetornarTuplaConFalse() 
        {
            //Arrange
            bool status;


            Tuple.Create(false); 

        }
    }
}

/*
public static (bool, Person) Login(string username, string password)
{
    List<Person> listaCompleta;
    bool logStatus;
    Person logPerson;

    logPerson = null;
    logStatus = true;

    listaCompleta = Select<Person>.SelectAll("person");

    foreach (Person persona in listaCompleta)
    {
        if (persona.password == password && persona.username == username)
        {
            logStatus = false;
            logPerson = persona;
        }
    }

    return (logStatus, logPerson);
}*/