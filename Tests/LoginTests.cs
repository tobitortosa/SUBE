using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using System;

namespace Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Login_CuandoElUsuarioOContraseñaEsIncorrecto_DeberiaRetornarTuplaConLogPersonEnNullYLogStatusEnTrue()
        {
            // Arrange
            string username = "tobitortosa";
            string password = "1234";
            (bool, Person) expected = (true, null);

            // Act
            (bool, Person) actual = Controladora.Login(username, password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login_CuandoElUsuarioNoExiste_DeberiaRetornarTuplaConLogPersonEnNullYLogStatusEnTrue()
        {
            // Arrange
            string username = "usuarioInexistente";
            string password = "contraseñaInexistente";
            (bool, Person) expected = (true, null);

            // Act
            (bool, Person) actual = Controladora.Login(username, password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login_CuandoElUsuarioYContraseñaEsCorrecto_DeberiaRetornarTuplaConLogPersonPersonaYLogStatusEnFalse()
        {
            // Arrange
            string username = "tobitortosa";
            string password = "123";

            PersonCRUD personCRUD = new PersonCRUD();   

            Person persona = personCRUD.GetByPK(username);
            (bool, Person) expected = (false, persona);

            // Act
            (bool, Person) actual = Controladora.Login(username, password);

            // Assert
            ReferenceEquals(expected, actual);
        }
    }
}