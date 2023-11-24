using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Select<T>
    {
        public static List<T> SelectAll(string table)
        {
            List<T> list = new List<T>();
            
            try
            {
                DBConnection.connectionMySql.Open();
                var query = $"SELECT * FROM {table}";
                DBConnection.commandMySql.CommandText = query;

                T obj = default(T);

                using (var reader = DBConnection.commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obj = Activator.CreateInstance<T>();
                        foreach (PropertyInfo prop in obj.GetType().GetProperties())
                        {
                            if (!Equals(reader[prop.Name], DBNull.Value))
                            {
                                prop.SetValue(obj, reader[prop.Name], null);
                            }
                        }
                        list.Add(obj);
                    }
                }

            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
                Console.WriteLine(ex);
            }
            finally
            {
                DBConnection.connectionMySql.Close();
            }   
            return list;
        }
    }
}
