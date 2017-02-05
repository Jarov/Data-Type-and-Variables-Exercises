using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());
            char fourthLine = char.Parse(Console.ReadLine());
            string fifthLine = Console.ReadLine();

            Console.WriteLine($"{firstLine} \n{secondLine} \n{thirdLine} \n{fourthLine} \n{fifthLine}");
        }
    }
}
