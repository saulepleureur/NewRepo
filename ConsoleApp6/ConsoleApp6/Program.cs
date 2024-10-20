using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст на русском");

            var text = Console.ReadLine();

            Console.WriteLine("текст на транслите:");
            Console.WriteLine(Translate(text));

            Console.ReadKey();

        }
        static string Translate(string s)
        {
            return s
                .Replace("А", "A")
                .Replace("Б", "B")
                .Replace("В", "V")
                .Replace("Г", "G")
                .Replace("Д", "D")
                .Replace("Е", "E")
                .Replace("Ё", "E")
                .Replace("Ж", "ZH")
                .Replace("З", "Z")
                .Replace("И", "I")
                .Replace("Й", "I")
                .Replace("К", "K")
                .Replace("Л", "L")
                .Replace("М", "M")
                .Replace("Н", "N")
                .Replace("О", "O")
                .Replace("П", "P")
                .Replace("Р", "R")
                .Replace("С", "S")
                .Replace("Т", "T")
                .Replace("У", "U")
                .Replace("Ф", "F")
                .Replace("Х", "KH")
                .Replace("Ц", "TS")
                .Replace("Ч", "CH")
                .Replace("Ш", "SH")
                .Replace("Щ", "SHCH")
                .Replace("Ъ", "IE")
                .Replace("Ы", "Y")
                .Replace("Ь", "")
                .Replace("Э", "E")
                .Replace("Ю", "IU")
                .Replace("Я", "IA")
                .Replace("а", "a")
                .Replace("б", "b")
                .Replace("в", "v")
                .Replace("г", "g")
                .Replace("д", "d")
                .Replace("е", "e")
                .Replace("ё", "e")
                .Replace("ж", "zh")
                .Replace("з", "z")
                .Replace("и", "i")
                .Replace("й", "i")
                .Replace("к", "k")
                .Replace("л", "l")
                .Replace("м", "m")
                .Replace("н", "n")
                .Replace("о", "o")
                .Replace("п", "p")
                .Replace("р", "r")
                .Replace("с", "s")
                .Replace("т", "t")
                .Replace("у", "u")
                .Replace("ф", "f")
                .Replace("х", "kh")
                .Replace("ц", "ts")
                .Replace("ч", "ch")
                .Replace("ш", "sh")
                .Replace("щ", "shch")
                .Replace("ъ", "ie")
                .Replace("ы", "y")
                .Replace("ь", "")
                .Replace("э", "e")
                .Replace("ю", "iu")
                .Replace("я", "ia");
        }
    }
}
