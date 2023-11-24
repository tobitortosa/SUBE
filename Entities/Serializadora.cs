using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entities.Entidades;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    [XmlInclude(typeof(Sube))]
    public static class Serializadora<T>
    {
        public static void EscribirXML(string path, List<T> lista)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                ser.Serialize(sw, lista);
            }
        }

        public static List<T> LeerXML(string path)
        {
            List<T> lista = null;

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<T>));
                lista = (List<T>)des.Deserialize(sr);
            }

            return lista;
        }
        public static void EscribirJson(T obj, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static T LeerJson(string path)
        {
            T obj;
            obj = default(T);
            try
            {
                string json = File.ReadAllText(path);
                obj = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return obj;
        }
    }
}
