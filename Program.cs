using System;

namespace NewQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
	        {
                Console.WriteLine("Welcome to the quizz app! Enter 0 if you are ready for a quiz, or 1 if you would like to exit");
                var UserInput = Console.ReadLine();
                switch (UserInput)
                {
                    case "0":
                        //Run the quizz app
                        break;
                    case "1":
                        Console.WriteLine("Okay feel free to come back anytime!");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
