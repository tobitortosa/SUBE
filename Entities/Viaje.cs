using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Viaje
    {
        private string _origen;
        private string _destino;
        private double _costo;
        private DateTime _fecha;
        private double _saldoAnterior;

        public Viaje()
        {
            
        }
        public Viaje(string origen, string destino, double costo, DateTime fecha, double saldoAnterior)
        {
            _origen = origen;
            _destino = destino;
            _costo = costo;
            _fecha = fecha;
            _saldoAnterior = saldoAnterior;
        }

        public string Origen { get => _origen; set => _origen = value; }
        public string Destino { get => _destino; set => _destino = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public double SaldoAnterior { get => _saldoAnterior; set => _saldoAnterior = value; }
    }
}
