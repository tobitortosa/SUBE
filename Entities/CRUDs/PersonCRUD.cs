using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;
using Entities.Interfaces;

namespace Entities.CRUDs
{
    public class PersonCRUD : IGetByFK<Person>, IGetByPK<Person>, IInsert<Person>, IUpdate<Person>
    {
        public List<Person> GetByFK(string username)
        {
            List<Person> list = Select<Person>.SelectAll("person");

            foreach (Person person in list)
            {
                if (person.username == username)
                {
                    list.Clear();
                    list.Add(person);
                }
            }
            return list;
        }

        public Person GetByPK(string username)
        {
            List<Person> list = Select<Person>.SelectAll("person");
            Person persona = new Person();

            foreach (Person person in list)
            {
                if (person.username == username)
                {
                    persona = person;
                }
            }
            return persona;
        }
        public bool Insert(Person person2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"INSERT INTO person (username, nombre, apellido, email, password, ban, ban_text, admin) VALUES (@username, @nombre, @apellido, @email, @password, @ban, @ban_text, @admin)";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@username", person2.username);
                DBConnection.commandMySql.Parameters.AddWithValue("@nombre", person2.nombre);
                DBConnection.commandMySql.Parameters.AddWithValue("@apellido", person2.apellido);
                DBConnection.commandMySql.Parameters.AddWithValue("@email", person2.email);
                DBConnection.commandMySql.Parameters.AddWithValue("@password", person2.password);
                DBConnection.commandMySql.Parameters.AddWithValue("@ban", person2.ban);
                DBConnection.commandMySql.Parameters.AddWithValue("@ban_text", person2.ban_text);
                DBConnection.commandMySql.Parameters.AddWithValue("@admin", person2.admin);

                DBConnection.commandMySql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
                return true;
            }
            finally
            {
                DBConnection.connectionMySql.Close();
            }
        }

        public void Update(Person person2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"UPDATE person SET nombre=@nombre, apellido=@apellido, email=@email, password=@password, ban=@ban, ban_text=@ban_text, admin=@admin WHERE username=@username";


                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@nombre", person2.nombre);
                DBConnection.commandMySql.Parameters.AddWithValue("@apellido", person2.apellido);
                DBConnection.commandMySql.Parameters.AddWithValue("@email", person2.email);
                DBConnection.commandMySql.Parameters.AddWithValue("@password", person2.password);
                DBConnection.commandMySql.Parameters.AddWithValue("@ban", person2.ban);
                DBConnection.commandMySql.Parameters.AddWithValue("@ban_text", person2.ban_text);
                DBConnection.commandMySql.Parameters.AddWithValue("@admin", person2.admin);
                DBConnection.commandMySql.Parameters.AddWithValue("@username", person2.username);

                DBConnection.commandMySql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
            finally
            {
                DBConnection.connectionMySql.Close();
            }
        }
    }
}
