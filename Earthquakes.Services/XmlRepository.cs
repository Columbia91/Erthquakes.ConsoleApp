using Earthquakes.Services.Abstract;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Earthquakes.Services
{
    public class XmlRepository<T> : IRepository<T>
    {
        private readonly ILogger logger;
        private readonly XmlSerializer serializer;

        public XmlRepository(ILogger logger)
        {
            this.logger = logger;

            serializer = new XmlSerializer(typeof(List<T>));
        }

        public void Add(T item)
        {
            logger.LogMessage($"Происходит добавление данных {typeof(T).Name}");

            var data = GetAll();
            data.Add(item);

            using(var stream = File.Open("earthquakes.xml", FileMode.Truncate))
            {
                serializer.Serialize(stream, data);
            }            
        }

        public List<T> GetAll()
        {
            logger.LogMessage($"Происходит получение списка данных {typeof(T).Name}");
           
            using(var stream = File.Open("earthquakes.xml", FileMode.OpenOrCreate))
            {
                if (stream.Length == 0) return new List<T>();
                return serializer.Deserialize(stream) as List<T>;
            }
        }
    }
}
