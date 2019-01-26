using System;

namespace NewQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quizz app! Enter 1 if you are ready for a quiz, or 2 if you would like to exit");
            var UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "1":
                    //Run the quizz app
                    break;
                case "2":
                    Console.WriteLine("Okay feel free to come back anytime!");
                    break;
                default:
                    break;
            }
        }
    }
}
