using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите натуральное число n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число k (1 <= k <= 8):");
            int k = int.Parse(Console.ReadLine());

            int product = 1;
            bool found = false;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit > k)
                {
                    product *= digit;
                    found = true;
                }
                n /= 10;
            }

            if (!found)
            {
                product = 1;
            }

            Console.WriteLine($"произведение цифр, больших {k}: {product}");

            Console.ReadKey();
        }
    }
    }
