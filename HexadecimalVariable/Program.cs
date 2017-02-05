using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalVar = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexadecimalVar, 16));
        }
    }
}
