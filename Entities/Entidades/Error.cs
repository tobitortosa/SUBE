using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Error
    {
        private DateTime _fecha;
        private string _descripcion;
        private string _clase;
        private string _metodo;

        public Error(string descripcion, string clase, string metodo)
        {
            Fecha = DateTime.Now;
            Descripcion = descripcion;
            Clase = clase;  
            Metodo = metodo;
        }

        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Clase { get => _clase; set => _clase = value; }
        public string Metodo { get => _metodo; set => _metodo = value; }
    }
}
