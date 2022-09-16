using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni5
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string url;
            Console.WriteLine("Unesite URL da provjerim je li u ispravnom formatu: ");
           url=Console.ReadLine();
            if(url.StartsWith("www.")&&url.EndsWith(".hr"))
            {
                Console.WriteLine("URL je ispravan!");
            }
            else
            { Console.WriteLine("URL je neispravan!"); }
            Console.ReadKey();
        }
    }
}
