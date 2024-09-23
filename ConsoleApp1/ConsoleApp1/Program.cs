using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Пушкин");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Унылая пора! Очей очарованье!");
            Console.WriteLine("Приятна мне твоя прощальная краса —");
            Console.WriteLine("Люблю я пышное природы увяданье");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
