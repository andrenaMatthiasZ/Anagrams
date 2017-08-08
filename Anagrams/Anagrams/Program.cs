using System;
using System.IO;
using System.Text;

namespace Anagrams
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const string FILE_NAME = "Words.txt";
            const string SORTED_WORDS_FILE_NAME = "WordsSorted.txt";
            const string STANDARD_FOR_TEXT_FILE_ENCODING = "iso-8859-1";
            const string ERROR_MESSAGE = "The file could not be read:";

        AnagramContainer container = new AnagramContainer();

            try
            {
                using (StreamReader streamReader = new StreamReader(FILE_NAME, Encoding.GetEncoding(STANDARD_FOR_TEXT_FILE_ENCODING)))
                {
                    string line;
                    while((line= streamReader.ReadLine())!=null)
                    {
                        container.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.WriteLine(e.Message);
            }

            string message = container.ToString();

            File.WriteAllText(SORTED_WORDS_FILE_NAME, message);
        }
    }
}
