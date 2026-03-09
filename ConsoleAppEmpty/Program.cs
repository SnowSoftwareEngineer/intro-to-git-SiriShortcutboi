using System;
using GameEnums;

public class Program
{
    static string userInput = "default-string"; 
    static int difficultyLevel = 1;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Mr. Jensen");
        Console.WriteLine("I wrote another writeline from home/Mac");

        Console.WriteLine("Choose your difficulty!");

        var userInput = Console.ReadLine();
        if (int.TryParse(userInput, out difficultyLevel))
        {
            switch ((GameDifficulty)difficultyLevel)
            {
                case GameDifficulty.Easy:
                    Console.WriteLine("You have selected Easy mode");
                    break;
                case GameDifficulty.Medium:
                    Console.WriteLine("You have selected Medium mode");
                    break;
                case GameDifficulty.Hard:
                    Console.WriteLine("So you have chosen, HARD MODE");
                    break;
            }//make a switch on the weekday Enum and select based on the Int value of 
            // the variable called weekdaying
        }

    }
}

/* public enum GameEnums //remember that calling enum in a foreach loop
{                 // must be uppercase like this Enum
    
}    */