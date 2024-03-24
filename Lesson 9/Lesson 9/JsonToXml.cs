using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Text.Json;

namespace Lesson_9
{
    internal class JsonToXml
    { 
        public JsonToXml(string json)
    {
        var doc = new XmlDocument();
        var rootNode = doc.AppendChild(doc.CreateElement("Person"));
        if (rootNode != null)
        {
            JsonDocument jsonDoc = JsonDocument.Parse(json);

            ConvertJsonToXml(jsonDoc.RootElement, rootNode);
        }

        XmlWriterSettings settings = new()
        {
            Indent = true,
            IndentChars = "\t"
        };

        using XmlWriter writer = XmlWriter.Create(Console.Out, settings);
        doc.Save(writer);
    }

    private void ConvertJsonToXml(JsonElement jsonElement, XmlNode xmlNode)
    {
        switch (jsonElement.ValueKind)
        {
            case JsonValueKind.Object:
                foreach (var property in jsonElement.EnumerateObject())
                {
                    var newElement = xmlNode.OwnerDocument?.CreateElement(property.Name);
                    if (newElement != null)
                    {
                        xmlNode.AppendChild(newElement);
                        ConvertJsonToXml(property.Value, newElement);
                    }
                }
                break;
            
            case JsonValueKind.Array:
                foreach (var value in jsonElement.EnumerateArray())
                {
                    ConvertJsonToXml(value, xmlNode);
                }
                break;
            
            default:
                var textNode = xmlNode.OwnerDocument?.CreateTextNode(jsonElement.ToString());
                if (textNode != null)
                    xmlNode.AppendChild(textNode);
                break;
        }
    }
    }
    
}
