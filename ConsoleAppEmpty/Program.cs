using System;
using GameEnums;

public class Program
{
    static int difficultyLevel = 1;    //global variable
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Mr. Jensen");
        Console.WriteLine("I wrote another writeline from home/Mac");

        Console.WriteLine("Choose your difficulty!");
        //this is me typing to appease my little nephew because he loves to watch me type on the computer 
        //more typing 
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

/* public enum GameEnums //remember that calling enum in a foreach loop
{                 // must be uppercase like this Enum
    
}    */