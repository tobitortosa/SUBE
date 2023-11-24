using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class Estacion
    {
        public string nombre { get; set; }
        public string ramal_nombre { get; set; }

        public Estacion()
        {

        }
        public Estacion(string nombre, string ramal_nombre)
        {
            this.nombre = nombre;
            this.ramal_nombre = ramal_nombre;
        }
    }
}
