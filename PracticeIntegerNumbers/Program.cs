using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            short firstNumber = short.Parse(Console.ReadLine());
            short secondNumber = short.Parse(Console.ReadLine());
            short thirdNumber = short.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            long fifthNumber = long.Parse(Console.ReadLine());
            int sixthNumber = int.Parse(Console.ReadLine());
            long seventhNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} \n{secondNumber} \n{thirdNumber} \n{fourthNumber} \n{fifthNumber} \n{sixthNumber} \n{seventhNumber}");
        }
    }
}
