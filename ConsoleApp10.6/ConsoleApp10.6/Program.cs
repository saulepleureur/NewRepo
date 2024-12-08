using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число b (b > a)");
            int b = int.Parse(Console.ReadLine());

            for (int number = a; number <= b; number++)
            {
                int sumOfDivisors = 0;

                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }

                sumOfDivisors += number;

                Console.WriteLine($"сумма делителей числа {number}: {sumOfDivisors}");

                Console.ReadKey();
            }
        }
    }
}
