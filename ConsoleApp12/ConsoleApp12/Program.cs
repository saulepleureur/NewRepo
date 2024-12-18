using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите число n от 5 до 20");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= n, n <= 20");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            Console.WriteLine();

            PrintMatrix(matrix);

            Console.WriteLine();

            var hasZero = HasZeroElement(matrix);
            if (hasZero.Item1)
                Console.WriteLine($"0 найден в строке {hasZero.Item2} столбце {hasZero.Item3}");
            else
                Console.WriteLine("0 не найден");

            Console.WriteLine();

            var diffs = GetSum(matrix);

            foreach (var diff in diffs)
                Console.WriteLine($"строка {diff.Item1}: разность сумм = {diff.Item2}");

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],2}");
                }

                Console.WriteLine();
            }
        }
        static (bool, int, int) HasZeroElement(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                        return (true, i, j);
                }
            }
            return (false, -1, -1);
        }
        static (int row, int diff)[] GetSum(int[,] matrix)
        {
            var result = new (int row, int diff)[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; (j < matrix.GetLength(0)); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        evenSum += matrix[i, j];
                    else
                        oddSum += matrix[i, j];
                }
                result[i] = (i, evenSum - oddSum);
            }
            return result;
        }
    }
}
