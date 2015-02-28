namespace ParseURL
{
    using System;
    using System.Web;

    /*
        Problem 12. Parse URL

        Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
        Example:

        URL	Information
        http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
        [server] = telerikacademy.com 
        [resource] = /Courses/Courses/Details/212
    */

    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Uri url = new Uri(input);

            Console.Write("Protocol: ");
            Console.WriteLine(url.Scheme);
            Console.Write("Server: ");
            Console.WriteLine(url.Host);
            Console.Write("Resource: ");
            Console.WriteLine(url.LocalPath);
        }
    }
}
