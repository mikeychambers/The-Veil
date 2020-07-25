using System;


namespace _507_sDungeon
{
    class Loops
    {
       public static bool cain = false;
       public static int score = 0;

        public static void TextLoop(string[] x)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (cain == false)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                }
                
                Console.WriteLine(x[i]);
                Console.ReadLine();
                Console.Clear();
            }
            Console.ResetColor();
        }

        public static void QuizLoop(string[,] x)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.CursorVisible = true;

            int j = 0;
            for (int i = 0; i < x.Length / 2; i++)
            {
                Console.Clear();
                Console.WriteLine(x[j, 0]);
                string answer = Console.ReadLine().ToLower();
                if (answer == x[j, 1])
                {
                    score++;
                }
                j++;
            }

            
        }

        public static void QuizOutcome()
        {
            if (score == 3)
            {
                Console.Clear();
                Console.WriteLine("Prehaps you are more use than you seem. With you by my side the cattle shall know there place.");
                Console.ReadLine();
            }

            else
            {
                Mechanics.ScreenColor();
                Console.WriteLine("Get outside, the most useful thing about your afterlife will be its end.");
                Console.ReadLine();
            }
        }

    }
}
