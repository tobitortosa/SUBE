using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Viaje
    {
        public int id { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public double costo { get; set; }
        public DateTime fecha{ get; set; }
        public double saldoAnterior{ get; set; }
        public string person_username { get; set; }
        public Viaje()
        {

        }
        public Viaje(string origen, string destino, double costo, DateTime fecha, double saldoAnterior, string person_username)
        {
            this.origen = origen;
            this.destino = destino;
            this.costo = costo;
            this.fecha = fecha;
            this.saldoAnterior = saldoAnterior;
            this.person_username = person_username;
        }
    }
}
