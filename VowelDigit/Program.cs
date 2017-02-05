using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowelOrDigit = Console.ReadLine().ToLower();

            if (vowelOrDigit == "0" || vowelOrDigit == "1" || vowelOrDigit == "2" || vowelOrDigit == "3" || vowelOrDigit == "4" || vowelOrDigit == "5" || vowelOrDigit == "6" || vowelOrDigit == "7" || vowelOrDigit == "8" || vowelOrDigit == "9")
            {
                Console.WriteLine("digit");
            }
            else if (vowelOrDigit == "a" || vowelOrDigit == "e" || vowelOrDigit == "i" || vowelOrDigit == "o" || vowelOrDigit == "u")
            {
                Console.WriteLine("vowel");
            }
            else
                Console.WriteLine("other");
        }
    }
}
