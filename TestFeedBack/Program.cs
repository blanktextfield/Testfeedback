using System;

namespace TestFeedBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what was your test result?");
            string grade = Console.ReadLine().ToLower();

            switch (grade)
            { case "a":
                Console.WriteLine("Excellent!");
             break;
             case "b":
             Console.WriteLine("Very Good");
                break;
                case "c":
                Console.WriteLine("Passed");
                break;
                case "d":
                Console.WriteLine("Failed");
                break;
                default:
                Console.WriteLine("Wasted");
                break;

        }    }
    }
}
