using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public delegate bool DelegadoCriterio<T>(T elemento);

    public static class DelegadoFiltrar
    {
        public static List<T> Filtrar<T>(this List<T> lista, DelegadoCriterio<T> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();  
            foreach(T elem in lista)
            {
                if(criterioDeFiltrado(elem))
                {
                    listaFiltrada.Add(elem);
                }
            }

            return listaFiltrada;
        }
    }
}
