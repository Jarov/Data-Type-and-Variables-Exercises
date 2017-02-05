using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = bool.Parse(Console.ReadLine());

            if (input)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
