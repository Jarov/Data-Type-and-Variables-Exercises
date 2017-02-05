using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int loopNumbers = 2; loopNumbers <= number; loopNumbers++)
            {
                bool prime = true;
                for (int delitel = 2; delitel <= Math.Sqrt(loopNumbers); delitel++)
                {
                    if (loopNumbers % delitel == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{loopNumbers} -> {prime}");
            }
        }
    }
}
