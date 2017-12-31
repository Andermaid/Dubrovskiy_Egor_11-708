using System;

namespace Rubick_s_Cube_Game
{
    class Game
    {
        public static Cube cube = new Cube();

        static void Main()
        {
            Console.CursorVisible = false;
            Cube.Create(cube);
            Cube.Print(cube);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress S to begin.");
            while (true)
                if (Console.ReadKey(true).Key == ConsoleKey.S) Solving();
        }

        static void Solving()
        {
            ConsoleKey[] availableMoves = new ConsoleKey[] { ConsoleKey.U , ConsoleKey.L, ConsoleKey.F, ConsoleKey.R, ConsoleKey.B,
                ConsoleKey.D, ConsoleKey.X, ConsoleKey.Y, ConsoleKey.Z};
            Scramble(availableMoves);
            Cube.Print(cube);
            int movesCount = 0;
            while (!SolvedCube(cube))
            {
                movesCount++;
                var move = Console.ReadKey(true).Key;
                if (move == ConsoleKey.D2) Move(Console.ReadKey(true).Key, 2);
                else if (move == ConsoleKey.Oem3) Move(Console.ReadKey(true).Key, 3);
                     else Move(move, 1);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Congratulations! You solved Rubick`s Cube for {0} moves.\nPress S to try again.", movesCount);
        }

        static void Move(ConsoleKey move, int n)
        {
            for (int i = 0; i < n; i++)
                switch (move)
                {
                    case ConsoleKey.U:
                        {
                            Cube.TurnUpSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.L:
                        {
                            Cube.TurnLeftSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Cube.TurnFrontSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            Cube.TurnRightSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Cube.TurnBackSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Cube.TurnDownSide(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            Cube.TurnCubeX(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.Y:
                        {
                            Cube.TurnCubeY(cube);
                            Cube.Print(cube);
                            break;
                        }
                    case ConsoleKey.Z:
                        {
                            Cube.TurnCubeZ(cube);
                            Cube.Print(cube);
                            break;
                        }
                }
        }

        static void Scramble(ConsoleKey[] availableMoves)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
                Move(availableMoves[random.Next(6)], random.Next(1, 3));
        }

        static bool SolvedCube(Cube cube)
        {
            return SolvedSide(Cube.Up) && SolvedSide(Cube.Left) && SolvedSide(Cube.Front) && SolvedSide(Cube.Right) && SolvedSide(Cube.Back);
        }

        static bool SolvedSide(char[,] side)
        {
            foreach (char e in side)
                if (e != side[1, 1]) return false;
            return true;
        }
    }
}