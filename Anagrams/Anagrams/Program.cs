using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "Words.txt";
            const string SORTED_WORDS_FILE_NAME = "WordsSorted.txt";
            const string STANDARD_FOR_TEXT_FILE_ENCODING = "iso-8859-1";
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
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            string message = container.ToString();

            Console.WriteLine(message);

            File.WriteAllText(SORTED_WORDS_FILE_NAME, message);

            Console.ReadKey();
        }
    }
}
