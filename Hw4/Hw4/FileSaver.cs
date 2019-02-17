using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Hw4
{
    class FileSaver<T>
    {
        // Binary serialization
        public static object ReadBinary(string filePath)
        {
            var f = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            var fmt = new BinaryFormatter();
            T obj = (T)fmt.Deserialize(f);
            f.Close();
            return obj;
        }

        public static void WriteBinary(T obj, string filePath)
        {
            var f = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            var serializer = new BinaryFormatter();
            serializer.Serialize(f, obj);
            f.Flush();
            f.Close();
        }

        // XML serialization
        public static T ReadXML(string filePath)
        {
            var f = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            var serializer = new XmlSerializer(typeof(T));
            T obj = (T)serializer.Deserialize(f);
            f.Close();
            return obj;
        }

        public static void WriteXML(T obj, string filePath)
        {
            var f = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(f, obj);
            f.Flush();
            f.Close();
        }

        // JSON serialization
        public static T ReadJSON(string filePath)
        {
            string contents = File.ReadAllText(filePath);
            T obj = JsonConvert.DeserializeObject<T>(contents);
            return obj;
        }

        public static void WriteJSON(T obj, string filePath)
        {
            var f = new JsonTextWriter(new StreamWriter(filePath));
            var serializer = new JsonSerializer();
            serializer.Serialize(f, obj);
            f.Flush();
            f.Close();
        }
    }
}
