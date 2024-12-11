using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var numbers = new double[n];
            var rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.NextDouble() * 20 - 10;

            PrintArray(numbers);

            NormalizeArray(numbers);
            Console.WriteLine("Массив после замены");
            
            PrintArray(numbers);

            double sqrt = GetSumOfProducts(numbers);
            Console.WriteLine($"Квадратный корень из суммы квадратов элементов массива: {sqrt:F3}");

            Console.WriteLine("Введите значение k");
            int k;
            if (!int.TryParse(Console.ReadLine(), out k))
                {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var sin = GetSin(numbers, k);
            Console.WriteLine("Значения sin(kx):");
            PrintArray(sin);

            Console.ReadKey();
        }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element:F3} ");

            Console.WriteLine();
        }

        static void NormalizeArray(double[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                if (i % 2 == 0)
                    array[i] = Math.Abs(array[i]);
            }
        }

        static double GetSumOfProducts(double[] array)
        {
            double sum = 0;
            foreach (var number in array)
            {
                sum += Math.Pow(number, 2);
            }
            return Math.Sqrt(sum);
        }

        static double[] GetSin(double[] array, int k)
        {
            var sin = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                sin[i] = Math.Sin(k * array[i]);
            }
            return sin;
        } 
    }
    }
