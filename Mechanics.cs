using System;
using System.IO;
using System.Threading;

namespace _507_sDungeon
{
    class Mechanics
    {
        public static string username = Environment.UserName;
        public static void CreateFile()
        {
            string path = String.Format(@"C:\Users\{0}\Desktop\Hello {0}.txt", username);
            string message = "It seems we wish for the same thing. Come see me. Alone.\n148 Ambras Street";
            File.WriteAllText(path, message);
        }

        public static void GoToAddress()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("You feel a presence on the top of your desk");
            Console.WriteLine("Where should you go? ");
            string address = Console.ReadLine().ToLower();
            if (address == "148 ambras street")
            {
                Console.WriteLine("You arrive at the location");
                Console.ReadLine();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("There is no one here");
                Console.ReadLine();
                GoToAddress();

            }
        }

        public static void ScreenColor()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(50);

            }
        }
    }
}

