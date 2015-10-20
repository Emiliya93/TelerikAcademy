using System;
using System.Linq;
using System.Xml.Linq;
namespace ExtractAllSongTitlesWithXDocumentAndLinq
{
    public class XDocumentLinqParser
    {
        public static void Main()
        {
            XDocument doc = XDocument.Load("../../../XmlProcessingInDotNet/catalog.xml");

            var titles =
                from song in doc.Descendants("song")
                select song.Element("title").Value.Trim();

            foreach (var title in titles)
            {

                Console.WriteLine("Song: {0}", title);
            }
        }
    }
}
