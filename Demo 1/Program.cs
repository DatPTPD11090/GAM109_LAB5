using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 4, 6, 9, 10, 12 };

            int product = numbers.Where(x => x % 2 == 0).Aggregate(1, (acc, x) => acc * x);
            Console.WriteLine("Tich cac so chia het cho hai la: " + product);


        }
    }
}
