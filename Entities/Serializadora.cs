using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    [XmlInclude(typeof(Person))]
    public class Serializadora
    {
        public static void EscribirPersonaXML(string path, List<Person> listaEmpleados)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
                ser.Serialize(sw, listaEmpleados);
            }
        }

        public static List<Person> LeerPersonaXML(string path)
        {
            List<Person> lista = null;

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Person>));
                lista = (List<Person>)des.Deserialize(sr);
            }

            return lista;
        }

        public static void EscribirSubeXML(string path, List<Sube> listaSubes)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Sube>));
                ser.Serialize(sw, listaSubes);
            }
        }

        public static List<Sube> LeerSubeXML(string path)
        {
            List<Sube> lista = null;

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Sube>));
                lista = (List<Sube>)des.Deserialize(sr);
            }

            return lista;
        }

    }
}
