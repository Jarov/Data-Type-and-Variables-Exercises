using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int finalChar = int.Parse(Console.ReadLine());

            for (int loop = startChar; startChar <= finalChar; startChar++)
            {
                Console.Write($"{Convert.ToChar(startChar)} ");
            }
            Console.WriteLine();
        }
    }
}
