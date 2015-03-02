namespace DownloadFile
{
    using System;
    using System.Net;
    using System.Windows.Forms;

    /*
        Problem 4. Download file

        Write a program that downloads a file from Internet (e.g. Ninja image -> http://telerikacademy.com/Content/Images/news-img01.png) and stores it the current directory.
        Find in Google how to download files in C#.
        Be sure to catch all exceptions and to free any used resources in the finally block.
    */

    class DownloadFile
    {
        static void Main()
        {

            WebClient webClient = new WebClient();
            string resource = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = "news-img01.png";
            webClient.DownloadFile(resource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, resource);
            Console.WriteLine("File saved in:");
            Console.WriteLine(Application.StartupPath);
        }
    }
}
