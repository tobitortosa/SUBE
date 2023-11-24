using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ControladoraAdmin
    {   
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
