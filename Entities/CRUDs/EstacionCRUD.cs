using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;
using Entities.Interfaces;

namespace Entities.CRUDs
{
    public class EstacionCRUD : IGetByFK<Estacion>, IInsert<Estacion>
    {
        public List<Estacion> GetByFK(string ramal)
        {
            List<Estacion> list = Select<Estacion>.SelectAll("estacion");
            List<Estacion> listaFinal = new List<Estacion>();

            foreach (Estacion estacion in list)
            {
                if (estacion.ramal_nombre == ramal)
                {
                    listaFinal.Add(estacion);
                }
            }
            return listaFinal;
        }

        public bool Insert(Estacion estacion2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"INSERT INTO estacion (nombre, ramal_nombre) VALUES (@nombre, @ramal_nombre)";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@nombre", estacion2.nombre);
                DBConnection.commandMySql.Parameters.AddWithValue("@ramal_nombre", estacion2.ramal_nombre);

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
    }
}
