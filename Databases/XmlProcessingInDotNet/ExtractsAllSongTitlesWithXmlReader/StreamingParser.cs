using System;
using System.Xml;
namespace ExtractsAllSongTitlesWithXmlReader
{
    public class StreamingParser
    {
        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../XmlProcessingInDotNet/catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine("Song: {0}", reader.ReadElementString().Trim());
                        
                    }
                }
            }
        }
    }
}
