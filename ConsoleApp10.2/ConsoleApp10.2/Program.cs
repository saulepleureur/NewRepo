using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество административных единиц:");
            int n = int.Parse(Console.ReadLine());

            double totalArea = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите количество жителей для административной единицы {i}");
                double population = double.Parse(Console.ReadLine());

                Console.WriteLine($"Введите плотность населения для административной единицы {i}");
                double density = double.Parse(Console.ReadLine());

                double area = population / density;
                totalArea += area;
            }
            Console.WriteLine($"Общая площадь страны: {totalArea}");
            Console.ReadKey();
        }
    }
}
