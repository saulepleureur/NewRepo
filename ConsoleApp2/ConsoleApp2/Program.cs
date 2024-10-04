using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ 
    internal class Program { }

class Triangle
    {
        public static void Main(string[] args)
        {
            double x1 = 0, y1 = 0;
            double x2 = 3, y2 = 0;
            double x3 = 0, y3 = 4;
            double a = Distance(x1, y1, x2, y2);
            double b = Distance(x2, y2, x3, y3);
            double c = Distance(x3, y3, x1, y1);
            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.WriteLine($"Площадь треугольника: {area}");
            Console.ReadKey();
        }
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    } }

