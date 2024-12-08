using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите натуральное число n (n > 1000)");
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            int position = 1;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    result += digit * position;
                    position *= 10;
                }
                n /= 10;
            }

            Console.WriteLine($"{result}");

            Console.ReadKey();
        }
    }
}
