using System;
using System.IO;
using System.Xml.Serialization;

namespace Yopon.Serializer
{
    public class XmlSerializer<T> where T : class, new()
    {
        public void Serialize(string fullPath, T obj)
        {
            using (var stream = File.Create(fullPath))
            {
                try
                {
                    (new XmlSerializer(typeof(T))).Serialize(stream, obj);
                }
                catch (Exception)
                {
                }
            }
        }

        public T Deserialize(string fullPath)
        {
            T obj = null;

            try
            {
                using (var stream = File.Open(fullPath, FileMode.Open))
                {
                    obj = (T)(new XmlSerializer(typeof(T))).Deserialize(stream);
                }
            }
            catch (Exception)
            {
                obj = null;
            }

            return obj;
        }
    }
}