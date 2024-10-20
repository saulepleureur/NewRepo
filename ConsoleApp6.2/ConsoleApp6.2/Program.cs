using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "клоун";
            Console.WriteLine($"Из слова \"{s}\" получили:");

            var word1 = s
                .Remove(3, 1)
                .Insert(1, "у");

            Console.WriteLine(word1);

            var word2 = s
                .Remove(2, 1)
                .Insert(1, "о");

            Console.WriteLine(word2);

            Console.ReadKey();
        }
        static string ReverseString( string s )
            {
            return new string (s.Reverse().ToArray());
        }
    }
}
