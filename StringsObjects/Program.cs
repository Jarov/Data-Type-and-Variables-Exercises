using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object frase = $"{firstWord} {secondWord}";

            string finalFrase = Convert.ToString(frase);

            Console.WriteLine(finalFrase);
        }
    }
}
