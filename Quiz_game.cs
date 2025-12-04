using System;
using System.Threading;

class Program
{
    public static void Main()
    {
        // Label to restart the game if the user wants to play again
        go:
        bool playagain = true;

        // Array containing all quiz questions
        string[] questions = { 
            "Which of these is the correct file extension for C# file?",  
            "Which keyword is used to create an object?", 
            "Which is the base class for all classes in C#?", 
            "Which access modifier allows access only within same class?", 
            "Which of these is value type?", 
            "Which keyword is used for inheritance?", 
            "Which method is entry point of a C# program?", 
            "Which keyword prevents inheritance?", 
            "Which is used to handle runtime errors?", 
            "Which keyword is used to define interface?" 
        };

        // Array containing all options for the questions, 4 options per question
        string[] options = {
            ".cs", ".csharp", ".c#", ".cpp",
            "create", "init", "new", "make",
            "Main", "System.Object", "System.Base", "Root.Class",
            "public", "protected", "private", "internal",
            "string", "object", "class", "int",
            "inherits", ":", "extends", "->",
            "Run()", "Start()", "Main()", "Begin()",
            "sealed", "stop", "final", "block",
            "do-catch", "try-catch", "catch-catch", "handle-catch",
            "interface", "structure", "blueprint", "proto"
        };

        // Array containing correct option numbers for each question (1-based index)
        int[] correctAnswerOptionNumbers = { 1, 3, 2, 3, 4, 2, 3, 1, 2, 1 };

        // Variables to track current question and option index
        int i = 0;  // question index
        int j = 0;  // option index

        // Start message
        Console.WriteLine("Let's start the game...");
        Thread.Sleep(3000);

        while (playagain)
        {
            // Display current question
            Console.WriteLine("Question {0} on your screen...", i + 1);
            Thread.Sleep(3000);
            Console.WriteLine(questions[i]);
            Thread.Sleep(1000);

            // Display options for the current question
            Console.WriteLine(options[j] + "          " + options[j + 1] + "          " + options[j + 2] + "          " + options[j + 3]);

            // Label for re-entering choice if invalid
            again:

            Console.WriteLine("Enter your choice (1-4): ");
            int selected = Convert.ToInt32(Console.ReadLine());

            // Check if input is valid
            if (selected < 1 || selected > 4)
            {
                Console.WriteLine("Invalid option...");
                goto again;
            }
            // Check if selected answer is correct
            else if (selected == correctAnswerOptionNumbers[i])
            {
                Console.WriteLine("Congratulations! Correct answer");
                Thread.Sleep(3000);

                // Move to next question
                i += 1;
                j += 4;

                // If all questions are answered correctly, user wins
                if (i == 10)
                {
                    Console.WriteLine("Congratulations! You won the game...");
                    playagain = false;
                }
            }
            // If answer is wrong, end the game
            else
            {
                Console.WriteLine("Sorry! Wrong answer. Better luck next time...");
                playagain = false;
            }
        }

        // Ask user if they want to play again
        Console.WriteLine("Do you want to play again? (Y/N): ");
        string wanttoplayagain = Console.ReadLine();

        // If yes, restart the game
        if (wanttoplayagain.ToUpper() == "Y")
        {
            goto go;
        }
    }
}
