using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distance = int.Parse(Console.ReadLine()); //In meters
            byte Hours = byte.Parse(Console.ReadLine());
            byte Minutes = byte.Parse(Console.ReadLine());
            byte Seconds = byte.Parse(Console.ReadLine());

            ushort totalSeconds = (ushort)(Hours * 60 * 60 + Minutes * 60 + Seconds);
            float speedMps = (float)Distance / totalSeconds;
            float speedKph = ((float)Distance / 1000) / ((float)totalSeconds / 3600);
            float speedMph = ((float)Distance / 1609) / ((float)totalSeconds / 3600);

            Console.WriteLine("{0:0.######}", speedMps);
            Console.WriteLine("{0:0.######}", speedKph);
            Console.WriteLine("{0:0.######}", speedMph);
        }
    }
}
