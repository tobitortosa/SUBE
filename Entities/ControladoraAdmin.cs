using Entities.CRUDs;
using Entities.Entidades;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TarjetaEventArgs : EventArgs
    {
        public Sube Sube { get; set; }
        public Person Persona { get; set; }
    }

    public class ControladoraAdmin
    {
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
        public void HandleCreateConfig(Person persona)
        {
            HandleConfigExist();
            List<Config> lista;
            List<Config> listaFiltrada;

            lista = Serializadora<List<Config>>.LeerJson(Paths.Configuracion);
            listaFiltrada = new List<Config>();

            Config config = new Config(ConfigDefault.BackDefaultColor, ConfigDefault.FontDefaultColor, persona.username);

            foreach (Config con in lista)
            {
                if (con.Username == persona.username)
                {
                    listaFiltrada.Add(con);
                }
            }

            if (listaFiltrada.Count == 0)
            {
                lista.Add(config);
            }

            Serializadora<List<Config>>.EscribirJson(lista, Paths.Configuracion);
        }


        public delegate void ActivarTarjetaEventHandler(object sender, TarjetaEventArgs e);
        public event ActivarTarjetaEventHandler TarjetaActivada;
        public bool ActivarTarjeta(Person persona, List<Sube> listaFiltrada)
        {
            SubeCRUD subeCRUD = new SubeCRUD();
            List<Sube> listaSubes = subeCRUD.GetByFK(persona.username);

            if (listaSubes.Count <= 4)
            {
                listaFiltrada[0].activada = true;
                listaFiltrada[0].person_username = persona.username;

                subeCRUD.Update(listaFiltrada[0]);
                OnTarjetaActivada(listaFiltrada[0], persona);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual void OnTarjetaActivada(Sube sube, Person persona)
        {
            Task task = new Task(() =>
            {
                if (TarjetaActivada != null)
                {
                    TarjetaEventArgs args = new TarjetaEventArgs() { Sube = sube, Persona = persona };
                    TarjetaActivada(this, args);
                }
            });
        }

        public async void EnvioMailTarjetaActivada(object source, TarjetaEventArgs args)
        {
            try
            {
                const string usuario = "proyectosube.ps@gmail.com";
                const string password = "rasz wqyj tmhn oguf";

                Console.WriteLine(args.Persona.email);

                StringBuilder mensaje = new StringBuilder();

                mensaje.Append(string.Format($"Hola {args.Persona.nombre} {args.Persona.apellido}"));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format($"Le queriamos informar que la activacion de su sube con el numero {args.Sube.numeroDeTarjeta} fue realizada con exito."));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format($"Le recordamos que el saldo inicial predeterminado de nuestras tarjetas al activarlas es de $500 pesos."));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(Environment.NewLine);
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format($"Muchas gracias"));

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("proyectosube.ps@gmail.com");
                mail.To.Add(args.Persona.email);
                mail.Subject = "Exitosa Activacion de Tarjeta SUBE";
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;

                await Task.Delay(3000); // Delay de 3 segundos
                await Task.Run(() =>
                {
                    smtp.Send(mail);
                });
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        public static async Task<bool> EnviarCorreoAsync(StringBuilder mensaje, DateTime FechaEnvio, string deEmail, string paraEmail, string asunto, Person persona)
        {
            try
            {
                const string usuario = "proyectosube.ps@gmail.com";
                const string password = "rasz wqyj tmhn oguf";
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("\nEste correo ha sido enviado el día {0:dd:/MM/yyyy} a las {0:HH:mm:ss} hs.\n", FechaEnvio));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format($"Usuario:\nNombre:{persona.nombre} {persona.apellido}, Email: {deEmail}"));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(deEmail);
                mail.To.Add(paraEmail);
                mail.Subject = asunto;
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;

                await Task.Delay(3000); // Delay de 3 segundos
                await Task.Run(() =>
                {
                    smtp.Send(mail);
                });

                return true;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
                return false;
            }
        }
        public static string CrearCodigoTarjeta()
        {
            string codigo;

            Random rnd = new Random();


            string primerosNumeros;
            string segundosNumeros;
            string tercerosNumeros;
            string cuartosNumeros;

            primerosNumeros = "";
            segundosNumeros = "";
            tercerosNumeros = "";
            cuartosNumeros = "";

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                primerosNumeros += numero.ToString();
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                segundosNumeros += numero.ToString();
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                tercerosNumeros += numero.ToString();
            }

            for (int j = 0; j < 4; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                cuartosNumeros += numero.ToString();
            }

            codigo = $"{primerosNumeros} {segundosNumeros} {tercerosNumeros} {cuartosNumeros}";

            return codigo;
        }
        public static string CrearCodigoSeguridad()
        {
            string codigoSeguridad;
            string codigo;
            Random rnd;

            codigo = "";

            rnd = new Random();
            for (int j = 0; j < 8; j++)
            {
                int numero;
                numero = rnd.Next(1, 9);
                codigo += numero.ToString();
            }

            return codigo;
        }

    }
}
