using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите позицию белой ладьи:");
            var whiteRookPosition = Console.ReadLine();
            int whiteRookRow, whiteRookColumn;
            DecodePosition(whiteRookPosition, out whiteRookRow, out whiteRookColumn);

            Console.WriteLine("введите позицию черного короля:");
            var blackKingPosition = Console.ReadLine();
            int blackKingRow, blackKingColumn;
            DecodePosition(blackKingPosition, out blackKingRow, out blackKingColumn);

            if (whiteRookRow == blackKingRow && whiteRookColumn == blackKingColumn)
            {
                Console.WriteLine("позиции белой ладьи и черного короля совпадают");
                return;
            }

            Console.WriteLine("введите предполагаемую позицию хода белой ладьи:");
            var movePosition = Console.ReadLine();
            int moveRow, moveColumn;
            DecodePosition(movePosition, out moveRow, out moveColumn);

            if (CanWhiteRookMove(whiteRookRow, whiteRookColumn, moveRow, moveColumn) &&
                !IsUnderAttackByBlackKing(moveRow, moveColumn, blackKingRow, blackKingColumn))
            {
                Console.WriteLine("ход возможен и не попадает под бой черного короля");
            }
            else
            {
                Console.WriteLine("ход невозможен или попадает под бой черного короля");
            }

            Console.ReadKey();
        }

        static void DecodePosition(string position, out int row, out int column)
        {
            row = int.Parse(position[1].ToString());
            column = position[0] - 'a' + 1;
        }

        static bool CanWhiteRookMove(int rookRow, int rookColumn, int moveRow, int moveColumn)
        {
            return rookRow == moveRow || rookColumn == moveColumn;
        }

        static bool IsUnderAttackByBlackKing(int moveRow, int moveColumn, int kingRow, int kingColumn)
        {
            return Math.Abs(moveRow - kingRow) <= 1 && Math.Abs(moveColumn - kingColumn) <= 1;
        }
    }
}
