using Entities.Entidades;
using Entities.Interfaces;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CRUDs
{
    public class SubeCRUD : IInsert<Sube>, IUpdate<Sube>, IGetByFK<Sube>, IDelete
    {
        public bool Insert(Sube sube2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"INSERT INTO sube (numeroDeTarjeta, codigoDeSeguridad, creator_username, saldo, activada, person_username, diaCreada) VALUES (@numeroDeTarjeta, @codigoDeSeguridad, @creator_username, @saldo, @activada, @person_username, @diaCreada)";
                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@numeroDeTarjeta", sube2.numeroDeTarjeta);
                DBConnection.commandMySql.Parameters.AddWithValue("@codigoDeSeguridad", sube2.codigoDeSeguridad);
                DBConnection.commandMySql.Parameters.AddWithValue("@creator_username", sube2.creator_username);
                DBConnection.commandMySql.Parameters.AddWithValue("@saldo", sube2.saldo);
                DBConnection.commandMySql.Parameters.AddWithValue("@activada", sube2.activada);
                DBConnection.commandMySql.Parameters.AddWithValue("@person_username", sube2.person_username);
                DBConnection.commandMySql.Parameters.AddWithValue("@diaCreada", sube2.diaCreada);

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


        public void Update(Sube sube2)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = $"UPDATE sube SET saldo=@saldo, activada=@activada, person_username=@person_username, diaCreada=@diaCreada WHERE numeroDeTarjeta=@numeroDeTarjeta";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@saldo", sube2.saldo);
                DBConnection.commandMySql.Parameters.AddWithValue("@activada", sube2.activada);
                DBConnection.commandMySql.Parameters.AddWithValue("@person_username", sube2.person_username);
                DBConnection.commandMySql.Parameters.AddWithValue("@diaCreada", sube2.diaCreada);
                DBConnection.commandMySql.Parameters.AddWithValue("@numeroDeTarjeta", sube2.numeroDeTarjeta);

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

        public List<Sube> GetByFK(string username)
        {
            List<Sube> allSubes;
            allSubes = Select<Sube>.SelectAll("sube");

            List<Sube> listaFiltrada;
            listaFiltrada = new List<Sube>();

            foreach (Sube sube in allSubes)
            {
                if (sube.person_username == username)
                {

                    listaFiltrada.Add(sube);
                }
            }

            return listaFiltrada;
        }

        public void Delete(string numeroDeTarjeta)
        {
            try
            {
                DBConnection.connectionMySql.Open();
                DBConnection.commandMySql.Parameters.Clear();

                var query = "DELETE FROM sube WHERE numeroDeTarjeta=@numeroDeTarjeta";

                DBConnection.commandMySql.CommandText = query;

                DBConnection.commandMySql.Parameters.AddWithValue("@numeroDeTarjeta", numeroDeTarjeta);

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
