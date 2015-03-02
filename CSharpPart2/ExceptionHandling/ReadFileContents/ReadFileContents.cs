namespace ReadFileContents
{
    using System;
    using System.IO;
    using System.Security;
    /*
        Problem 3. Read file contents

        Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
        Find in MSDN how to use System.IO.File.ReadAllText(…).
        Be sure to catch all possible exceptions and print user-friendly error messages.
    */

    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Please enter full path to file name to print (e.g. C:\\WINDOWS\\win.ini): ");
            Console.WriteLine();
            string path = Console.ReadLine();

            try
            {
                //throw new SecurityException();
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You may haven't entered path to file.");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Error message: {0}", ex.Message);
                Console.WriteLine("You might check again the path to the specified file.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified directory can not be found! You might check again the path.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found. You might check if the file is in different directory!");
            }
            catch (IOException)
            {
                Console.WriteLine("An error occured. It may be caused by:");
                Console.WriteLine("1.Part of a file or directory cannot be found.");
                Console.WriteLine("2.Reading is attempted past the end of a stream.");
                Console.WriteLine("3.File does not exist and can't access it.");
                Console.WriteLine("4.A managed assembly is found but cannot be loaded.");
                Console.WriteLine("5.Path or file name is longer than the system-defined maximum length.");
                Console.WriteLine("You might check again the path to the specified file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error occured. It may be caused by:");
                Console.WriteLine("1.The path specified a file that is read-only.");
                Console.WriteLine("2.Reading from the file is not supported on the current platform.");
                Console.WriteLine("3.The path specified a directory (not a file, e.g. C:\\WINDOWS\\win.ini).");
                Console.WriteLine("4.You do not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in an invalid format.");
                Console.WriteLine("It must look like that: C:\\WINDOWS\\win.ini");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
        }
    }
}
