using System;
using System.Xml;
namespace DeleteWithDomParser
{
    public class DomDeleter
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../XmlProcessingInDotNet/catalog.xml");

            XmlElement rootNode = doc.DocumentElement;

            foreach (XmlElement album in rootNode.SelectNodes("album"))
            {
                var price = double.Parse(album["price"].InnerText);

                if (price > 20)
                {
                    Console.WriteLine("Removing item: ->{0}<-", album.InnerXml);
                    rootNode.RemoveChild(album);
                }
            }

            doc.Save("../../../XmlProcessingInDotNet/catalogWithDeletedAlbums.xml");
        }
    }
}
