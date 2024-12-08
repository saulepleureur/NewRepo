using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий курс доллара в рублях;");
            decimal exchange = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("{0,10} {1,20}", "Доллары", "Рубли");

            for (int dollars = 10; dollars <= 1000; dollars += 10) 
            {
                decimal rubles = dollars * exchange;
                Console.WriteLine("{0,10} {1,20}", dollars, rubles);
            }
            Console.ReadKey();
        }
    }
}
