using Entities.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Controladora
    {
        public static Config GetConfig(Person persona)
        {
            Config config;
            config = HandleLeerConfig(persona);
            return config;
        }

        public static void HandleEscribirConfig(Color color, Person persona, bool isBackColor)
        {
            try
            {
                List<Config> lista;
                lista = Serializadora<List<Config>>.LeerJson(Paths.Configuracion);

                foreach (Config configuracion in lista)
                {
                    if (configuracion.Username == persona.username)
                    {
                        if (isBackColor)
                        {
                            configuracion.BackgroundColor = color;
                        } 
                        else
                        {
                            configuracion.FontColor = color;
                        }
                    } 
                }

                Serializadora<List<Config>>.EscribirJson(lista, Paths.Configuracion);
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        public static void HandleCreateConfig(Person persona)
        {
            HandleConfigExist();
            List<Config> lista;
            List<Config> listaFiltrada;

            lista = Serializadora<List<Config>>.LeerJson(Paths.Configuracion);
            listaFiltrada = new List<Config>();

            Config config = new Config(ConfigDefault.BackDefaultColor, ConfigDefault.FontDefaultColor, persona.username);

            foreach (Config con in lista)
            {
                if(con.Username == persona.username)
                {
                    listaFiltrada.Add(con);
                }
            }

            if(listaFiltrada.Count == 0)
            {
                lista.Add(config);
            }

            Serializadora<List<Config>>.EscribirJson(lista, Paths.Configuracion);
        }

        public static void HandleConfigExist()
        {
            if (!File.Exists(Paths.Configuracion))
            {
                List<Config> config = new List<Config>();
                Serializadora<List<Config>>.EscribirJson(config, Paths.Configuracion);
            }
        }

        public static Config HandleLeerConfig(Person persona)
        {

            Config config;
            List<Config> lista;
            config = null;

            lista = Serializadora<List<Config>>.LeerJson(Paths.Configuracion);

            foreach (Config configuracion in lista)
            {
                if (configuracion.Username == persona.username)
                {
                    config = configuracion;
                }
            }

            return config; 
        }

        public static void HandleException(Exception ex)
        {
            Console.WriteLine(ex.Message);
            StackTrace trace = new StackTrace(ex, true);

            var metodo = trace.GetFrame(0).GetMethod().Name;
            var clase = trace.GetFrame(0).GetMethod().ReflectedType.FullName;

            Error error = new Error(ex.Message, clase, metodo);
            EscribirTxtError(Paths.Error, error);
        }

        public static void EscribirTxtError(string path, Error error)
        {
            StreamWriter agregar = File.AppendText(path);
            agregar.WriteLine($"Fecha: {error.Fecha} | Descripcion: {error.Descripcion} | Clase: {error.Clase} | Metodo: {error.Metodo}");

            agregar.Close();
        }
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
        }
    }
}
