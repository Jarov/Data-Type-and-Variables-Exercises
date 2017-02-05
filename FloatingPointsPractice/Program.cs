using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} \n{secondNumber} \n{thirdNumber}");
        }
    }
}
