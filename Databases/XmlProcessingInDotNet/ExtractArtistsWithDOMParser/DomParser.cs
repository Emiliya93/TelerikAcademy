using System;
using System.Collections.Generic;
using System.Xml;
namespace ExtractArtistsWithDOMParser
{
    public class DomParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../XmlProcessingInDotNet/catalog.xml");

            XmlElement rootNode = doc.DocumentElement;

            XmlNodeList artists = GetArtistsWithDomParser(rootNode);

            IDictionary<string, int> artistsWithAlbums = GetArtistsWithAlbumsCount(artists);

            PrintArtistsWithAlbums(artistsWithAlbums);
        }

        private static void PrintArtistsWithAlbums(IDictionary<string, int> artistsWithAlbums)
        {
            Console.WriteLine("All artists from catalog: ");

            foreach (KeyValuePair<string, int> keyValuePair in artistsWithAlbums)
            {
                Console.Write("{0} -> ", keyValuePair.Key);
                if (keyValuePair.Value == 1)
                {
                    Console.WriteLine("{0} album", keyValuePair.Value);
                }
                else
                {
                    Console.WriteLine("{0} albums", keyValuePair.Value);
                }
            }
        }

        private static XmlNodeList GetArtistsWithDomParser(XmlElement rootNode)
        {
            XmlNodeList artists = rootNode.GetElementsByTagName("artist");
            

            return artists;
        }

        private static IDictionary<string, int> GetArtistsWithAlbumsCount(XmlNodeList artists)
        {
            Dictionary<string, int> artistsWithAlbums = new Dictionary<string, int>();

            foreach (XmlNode artist in artists)
            {
                string artistName = artist.InnerText.Trim();
                if (!artistsWithAlbums.ContainsKey(artistName))
                {
                    artistsWithAlbums.Add(artistName, 0);
                }

                artistsWithAlbums[artistName]++;
            }

            return artistsWithAlbums;
        }
    }
}
