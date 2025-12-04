using System;
using System.Threading;

class Program
{
    public static void Main()
    {
        go:
        bool playagain = true;
        string[] questions = { "Which of these is the correct file extension for C# file?",  "Which keyword is used to create an object?", "Which is the base class for all classes in C#?", "Which access modifier allows access only within same class?", "Which of these is value type?", "Which keyword is used for inheritance?", "Which method is entry point of a C# program?", "Which keyword prevents inheritance?", "Which is used to handle runtime errors?", "Which keyword is used to define interface?" };
        string[] options = {".cs", ".csharp", ".c#", ".cpp","create", "init", "new", "make","Main", "System.Object", "System.Base", "Root.Class","public", "protected", "private", "internal","string", "object", "class", "int","inherits", ":", "extends", "->","Run()", "Start()", "Main()", "Begin()","sealed", "stop", "final", "block","do-catch", "try-catch", "catch-catch", "handle-catch","interface", "structure", "blueprint", "proto"};
        int[] correctAnswerOptionNumbers = { 1, 3, 2, 3, 4, 2, 3, 1, 2, 1 };
        int i = 0;
        int j = 0;

        System.Console.WriteLine("lets start the game...");
        Thread.Sleep(3000);

        while (playagain)
        {
            System.Console.WriteLine("Question {0} on your screen...",i+1);
            Thread.Sleep(3000);
            System.Console.WriteLine(questions[i]);
            Thread.Sleep(1000);
            System.Console.WriteLine(options[j] + "          " + options[j+1]+ "          " + options[j+2] + "          " + options[j+3]);

            again:

            System.Console.WriteLine("enter you choice:- ");
            int selected = Convert.ToInt32(Console.ReadLine());

            if(selected<1 || selected > 4)
            {
                System.Console.WriteLine("Invalid option...");
                goto again;                
            }
            else if(selected == correctAnswerOptionNumbers[i])
            {
                System.Console.WriteLine("Congratulations! Correct answer");
                Thread.Sleep(3000);
                i+=1;
                j+=4;
                if(i==10)
                {
                    System.Console.WriteLine("Congratulations! You won the game...");
                    playagain = false;
                }
            }
            else
            {
                System.Console.WriteLine("Sorry! Wrong answer. Better luck next time...");
                playagain = false;
            }
        }
        System.Console.WriteLine("Do you want to play again? (Y/N): ");
        string wanttoplayagain = Console.ReadLine();

        if(wanttoplayagain.ToUpper() == "Y")
        {
            goto go;
        }
    }
}