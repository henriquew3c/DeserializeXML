using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DeserializeXML.Common.Helpers
{
    public static class XMLHelper
    {
        public static XmlDocument StringToXml(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            var xmlDocument = new XmlDocument();

            xmlDocument.LoadXml(value.Trim().Replace("&lt;", "<").Replace("&gt;", ">"));

            return xmlDocument;
        }

        public static T XmlToObject<T>(this string xml, string tagRoot) where T : class
        {
            var xmlDocument = xml.StringToXml();

            if (xmlDocument is null)
                return null;

           var @object = DeserializeXml<T>(xmlDocument, tagRoot, string.Empty);

            return @object;
        }

        public static T DeserializeXml<T>(this XmlDocument xmlDocument, string tagParent, string nameSpace) where T : class
        {
            var index = xmlDocument.GetElementsByTagName(tagParent).Count - 1;

            if (index < 0)
                return null;

            using var stringReader = new StringReader(xmlDocument.InnerXml);
            var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(tagParent) { Namespace = nameSpace });
            var @object = (T)serializer.Deserialize(stringReader);
            return @object;
        }
    }
}
