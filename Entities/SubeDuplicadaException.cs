using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;

namespace Entities
{
    public class SubeDuplicadaException : Exception
    {
        public SubeDuplicadaException(string mensaje, Sube sube) : base(mensaje)
        {
            try
            {
                if (!File.Exists(Paths.SubeDuplicada)) {
                    List<Sube> subeList = new List<Sube>();
                    Serializadora<Sube>.EscribirXML(Paths.SubeDuplicada, subeList);
                }

                List<Sube> subes = Serializadora<Sube>.LeerXML(Paths.SubeDuplicada);
                subes.Add(sube);
                Serializadora<Sube>.EscribirXML(Paths.SubeDuplicada, subes);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }    
        }
    }
}
