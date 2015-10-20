using System;
using System.Collections.Generic;
using System.Xml;
namespace ExtractArtistsWithXPath
{
    public class XPathParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../XmlProcessingInDotNet/catalog.xml");

            string xPathQuery = "catalog/album/artist";
            XmlNodeList artists = GetArtistsWithXPath(doc, xPathQuery);

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

        private static XmlNodeList GetArtistsWithXPath(XmlDocument doc, string xPathQuery)
        {
            XmlNodeList artists = doc.SelectNodes(xPathQuery);
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