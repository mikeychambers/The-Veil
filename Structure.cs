using System;


namespace _507_sDungeon
{
    class Structure
    {
        public static void SetEnviroment()
        {
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
        }
        public static void Title()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(49, 15);
            Console.WriteLine("The Veil");
            Console.SetCursorPosition(45, 16);
            Console.WriteLine("By Mike Chambers");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Outro()
        {
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition(49, 15);
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}
