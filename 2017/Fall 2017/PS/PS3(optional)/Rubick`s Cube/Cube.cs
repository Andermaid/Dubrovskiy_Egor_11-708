using System;

namespace Rubick_s_Cube_Game
{
    public class Cube
    {
        public static char[,] Up;
        public static char[,] Left;
        public static char[,] Front;
        public static char[,] Right;
        public static char[,] Back;
        public static char[,] Down;

        public static void Create(Cube cube)
        {
            Up = CreateSide('W');
            Left = CreateSide('O');
            Front = CreateSide('G');
            Right = CreateSide('R');
            Back = CreateSide('B');
            Down = CreateSide('Y');
        }

        static char[,] CreateSide(char n)
        {
            char[,] side = new char[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    side[i, j] = n;
            return side;
        }

        public static void Print(Cube cube)
        {
            Console.Clear();
            PrintUpDownSide(Up);
            for (int i = 0; i < 3; i++)
            {
                PrintSideLayerI(i);
            }
            PrintUpDownSide(Down);
            Console.ForegroundColor = ConsoleColor.White;
            WriteNotation();
        }

        public static void WriteNotation()
        {
            Console.WriteLine("Именования граней:\nUp - U (изначально белая), Right - R (изначально красная),\n" +
                              "Left - L (изначально бардовая), Front - F (изначально зелёная),\n" +
                              "Back - B (изначально синяя), Down - D (изначально жёлтая).\n" +
                              "Язык вращений:\nU, R, L, F, B, D - поворот соответствующей грани по часовой стрелке.\n" +
                              "X, Y, Z - перехват куба по часовой стрелке вдоль соответствующей оси.\n" +
                              "2K - поворот грани K или перехват по оси K 2 раза,\n" +
                              "`K - поворот грани K или перехват по оси K против часовой стрелки");
        }

        public static void DrawElement(char caseOfColor)
        {
            switch (caseOfColor)
            {
                case 'W':
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 'O':
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case 'G':
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case 'R':
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case 'B':
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case 'Y':
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
            }
            Console.Write("@ ");
        }

        public static void PrintUpDownSide(char[,] side)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("      ");
                for (int j = 0; j < 3; j++)
                {
                    DrawElement(side[i, j]);
                }
                Console.Write("\n");
            }
        }

        static void PrintSideLayerI(int i)
        {
            PrintPartOfLayerI(Left, i);
            PrintPartOfLayerI(Front, i);
            PrintPartOfLayerI(Right, i);
            PrintPartOfLayerI(Back, i);
            Console.Write("\n");
        }

        static void PrintPartOfLayerI(char[,] side, int i)
        {
            for (int j = 0; j < 3; j++)
            {
                DrawElement(side[i, j]);
            }
        }

        public static void TurnUpSide(Cube cube)
        {
            TurnSideOnly(Up);
            for (int i = 0; i < 3; i++)
            {
                char buffer = Front[0, i];
                Front[0, i] = Right[0, i];
                Right[0, i] = Back[0, i];
                Back[0, i] = Left[0, i];
                Left[0, i] = buffer;
            }
        }

        public static void TurnCubeX(Cube cube)
        {
            char[,] buffer = Front;
            Front = Down;
            Down = Back;
            Back = Up;
            Up = buffer;
            for (int i = 0; i < 2; i++)
            {
                TurnSideOnly(Back);
                TurnSideOnly(Down);
            }
            TurnSideOnly(Right);
            for (int i = 0; i < 3; i++)
            {
                TurnSideOnly(Left);
            }
        }

        public static void TurnCubeY(Cube cube)
        {
            char[,] buffer = Front;
            Front = Right;
            Right = Back;
            Back = Left;
            Left = buffer;
            TurnSideOnly(Up);
            for (int i = 0; i < 3; i++)
                TurnSideOnly(Down);
        }

        public static void TurnCubeZ(Cube cube)
        {
            char[,] buffer = Up;
            Up = Left;
            Left = Down;
            Down = Right;
            Right = buffer;
            for (int i = 0; i < 3; i++)
            {
                TurnSideOnly(Back);
            }
            TurnSideOnly(Front);
            TurnSideOnly(Up);
            TurnSideOnly(Down);
            TurnSideOnly(Left);
            TurnSideOnly(Right);
        }

        static void TurnSideOnly(char[,] side)
        {
            char buffer = side[0, 0];
            side[0, 0] = side[2, 0];
            side[2, 0] = side[2, 2];
            side[2, 2] = side[0, 2];
            side[0, 2] = buffer;
            buffer = side[0, 1];
            side[0, 1] = side[1, 0];
            side[1, 0] = side[2, 1];
            side[2, 1] = side[1, 2];
            side[1, 2] = buffer;
        }

        public static void TurnRightSide(Cube cube)
        {
            for (int i = 0; i < 3; i++)
                TurnCubeZ(cube);
            TurnUpSide(cube);
            TurnCubeZ(cube);
        }

        public static void TurnLeftSide(Cube cube)
        {
            TurnCubeZ(cube);
            TurnUpSide(cube);
            for (int i = 0; i < 3; i++)
                TurnCubeZ(cube);
        }

        public static void TurnFrontSide(Cube cube)
        {
            TurnCubeX(cube);
            TurnUpSide(cube);
            for (int i = 0; i < 3; i++)
                TurnCubeX(cube);
        }

        public static void TurnBackSide(Cube cube)
        {
            for (int i = 0; i < 3; i++)
                TurnCubeX(cube);
            TurnUpSide(cube);
            TurnCubeX(cube);
        }

        public static void TurnDownSide(Cube cube)
        {
            for (int i = 0; i < 2; i++)
                TurnCubeZ(cube);
            TurnUpSide(cube);
            for (int i = 0; i < 2; i++)
                TurnCubeZ(cube);
        }
    }
}