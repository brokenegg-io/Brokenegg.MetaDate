using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Brokenegg.MetaDate.Helpers
{
    public class ArchiveHelper
    {
        public static List<T> ReadXmlResource<T>(string name, string rootAttribute)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var teste = new Brokenegg.MetaDate.ULocale().GetType().GetTypeInfo().Assembly.GetManifestResourceNames();


            string resourcePath = teste.Single(str => str.Equals($"Brokenegg.MetaDate.{name}"));

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var content = reader.ReadToEnd();
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(rootAttribute));
                    return (List<T>)deserializer.Deserialize(reader);
                }
            }
        }
    }
}
