using System;

namespace _507_sDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Structure.SetEnviroment();
            Loops.TextLoop(Scripts.introScript);
            Structure.Title();
            Console.WriteLine("Back at the office");
            Console.ReadLine();
            Loops.TextLoop(Scripts.storyScript);
            Mechanics.CreateFile();
            Mechanics.GoToAddress();
            Loops.cain = true;
            Loops.TextLoop(Scripts.cainScript);
            Loops.QuizLoop(Scripts.quizScript);
            Loops.QuizOutcome();
            Structure.Outro();
            
        }
    }
}

    
           
    

       
    

