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
            AnagramContainer container = new AnagramContainer();

            try
            {  
                using (StreamReader streamReader = new StreamReader("Words.txt", Encoding.GetEncoding("iso-8859-1")))
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
            Console.ReadKey();
        }
    }
}
