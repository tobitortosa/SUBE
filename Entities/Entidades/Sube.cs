using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Sube
    {
        public string numeroDeTarjeta {  get; set; }
        public string codigoDeSeguridad { get; set; }
        public string creator_username { get; set; }
        public double saldo { get; set; }
        public bool activada { get; set; }
        public string person_username { get; set; }
        public DateTime diaCreada { get; set; }

        public Sube()
        {
            
        }
        public Sube(string numeroDeTarjeta, string codigoDeSeguridad, string creator_username, double saldo, bool activada, string person_username, DateTime diaCreada)
        {
            this.numeroDeTarjeta = numeroDeTarjeta;
            this.codigoDeSeguridad = codigoDeSeguridad;
            this.creator_username = creator_username;
            this.saldo = saldo;
            this.activada = activada;
            this.person_username = person_username;
            this.diaCreada = diaCreada;
        }
    }
}