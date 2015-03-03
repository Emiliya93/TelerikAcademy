namespace ExtractTextFromXML
{
    using System;
    using System.IO;

    /*
        Problem 10. Extract text from XML

        Write a program that extracts from given XML file all the text without the tags.
        Example:

        <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
    */

    class ExtractTextFromXML
    {
        static void Main()
        {
            char openTag = '<';
            char closeTag = '>';
            using (StreamReader reader = new StreamReader(@"..\..\Files\input.xml"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt"))
                {
                    string line = reader.ReadLine();
                    bool inTag = false;
                    while (line != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            char currSym = line[i];
                            if (line[i] == openTag)
                            {
                                inTag = true;
                                continue;
                            }
                            else if (line[i] == closeTag)
                            {
                                inTag = false;
                                continue;
                            }
                            if (!inTag)
                            {
                                writer.Write(line[i]);
                            }
                        }
                        line = reader.ReadLine();
                    }   
                }
            }
        }
    }
}
