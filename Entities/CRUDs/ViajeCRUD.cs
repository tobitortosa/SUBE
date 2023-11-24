using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;
using Entities.Interfaces;

namespace Entities.CRUDs
{
    public class ViajeCRUD : IInsert<Viaje>, IGetByFK<Viaje>
    {
        public bool Insert(Viaje viaje2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = "INSERT INTO viaje (origen, destino, costo, fecha, saldoAnterior, person_username) VALUES (@origen, @destino, @costo, @fecha, @saldoAnterior, @person_username)";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@origen", viaje2.origen);
                DBConnection.commandMySql.Parameters.AddWithValue("@destino", viaje2.destino);
                DBConnection.commandMySql.Parameters.AddWithValue("@costo", viaje2.costo);
                DBConnection.commandMySql.Parameters.AddWithValue("@fecha", viaje2.fecha);
                DBConnection.commandMySql.Parameters.AddWithValue("@saldoAnterior", viaje2.saldoAnterior);
                DBConnection.commandMySql.Parameters.AddWithValue("@person_username", viaje2.person_username);

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

        public List<Viaje> GetByFK(string username)
        {
            List<Viaje> allViajes;
            allViajes = Select<Viaje>.SelectAll("viaje");

            List<Viaje> listaFiltrada;
            listaFiltrada = new List<Viaje>();

            foreach (Viaje viaje in allViajes)
            {
                if (viaje.person_username == username)
                {

                    listaFiltrada.Add(viaje);
                }
            }

            return listaFiltrada;
        }
    }
}
