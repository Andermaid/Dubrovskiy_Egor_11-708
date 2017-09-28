//Cond1. Дана начальная и конечная клетки на шахматной доске. Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            TestMove(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }
        static void TestMove(string coord1, string coord2, string type)
        {
            Console.WriteLine("Move is "+CheckMoveCorrectness(coord1, coord2, type));
            Console.ReadLine();
        }
        static bool CheckMoveCorrectness(string coord1, string coord2, string type)
        {
            int dx = Math.Abs(coord2[0] - coord1[0]);
            int dy = Math.Abs(coord2[1] - coord1[1]);
            if (type == "rook" && (dx == 0 || dy == 0) && dx != dy) return true;
            else if (type == "knight" && ((dx == 2 && dy == 1) || (dx == 1 && dy == 2))) return true;
            else if (type == "bishop" && dx == dy && dx != 0) return true;
            else if (type == "quenn" && (((dx == 0 || dy == 0) && dx != dy) || (dx == dy && dx != 0))) return true;
            else if (type == "king" && (dx == 1 || dy == 1)) return true;
            else return false;
        }
    }
}
