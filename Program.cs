using System;

namespace NewQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Welcome to the quizz app! Choose from the options below");

            while (true)
	        {
               
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Take a quiz on Domain 1.0 - Hardware");
                Console.WriteLine("2. Take a quiz on Domain 2.0 - Networking");
                Console.WriteLine("3. Take a quiz on Domain 3.0 - Mobile Devices");
                Console.WriteLine("4. Take a quiz on Domain 4.0 - Hardware & Network Troubleshooting");
                var UserInput = Console.ReadLine();
                
            switch (UserInput)
                {
                    case "0":
                        Console.WriteLine("Okay feel free to come back anytime!");
                        return;
                    case "1":
                        //run the quiz engine program for domian 1 questions
                        break;
                    case "2":
                        //run the quiz engine program for domian 2 questions
                        break;
                    case "3":
                        //run the quiz engine program for domian 3 questions
                        break;
                    case "4":
                        //run the quiz engine program for domian 4 questions
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
