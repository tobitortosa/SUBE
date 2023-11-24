using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;
using Entities.Interfaces;

namespace Entities.CRUDs
{
    public class RamalCRUD : IInsert<Ramal>
    {
        public RamalCRUD()
        {

        }

        public bool Insert(Ramal ramal2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"INSERT INTO ramal (ramal) VALUES (@ramal)";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@ramal", ramal2.ramal);

                DBConnection.commandMySql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
                return false;
            }
            finally
            {
                DBConnection.connectionMySql.Close();
            }
        }
    }
}
