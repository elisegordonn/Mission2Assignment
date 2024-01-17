// Elise Gordon, Section 2
// Mission 2 Assignment: Dice rolling simulator

using Mission2Assignment;
public class Program
{
    private static void Main()
    {
        // write intro to the console
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("\nHow many dice rolls would you like to simulate?");

        // set numThrows variable as the user's input
        int numThrows = int.Parse(System.Console.ReadLine());

        // set diceRoller with the Stuff class
        // create a results array 
        Stuff diceRoller = new Stuff();
        int[] results = diceRoller.SimulateDiceRolls(numThrows);

        // insert results and numThrows into the PrintHistogram method
        PrintHistogram(results, numThrows);
    }

    static void PrintHistogram(int[] results, int numThrows)
    {
        // write to console the results intro
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numThrows + ".");


        // for loop working through all of the throws
        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numThrows;
            System.Console.Write($"{i}: {new string('*', percentage)}\n");
        }

        // conclude
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}

// 2: 1+1
// 3: 1+2, 2+1
// 4: 2+2, 1+3, 3+1
// 5: 1+4, 4+1, 2+3, 3+2
// 6: 3+3, 1+5, 5+1, 2+4, 4+2
// 7: 1+6, 6+1, 2+5, 5+2, 3+4, 4+3
// 8: 4+4, 2+6, 6+2, 3+5, 5+3
// 9: 3+6, 6+3, 4+5, 5+4
// 10: 5+5, 6+4, 4+6
// 11: 6+5, 5+6
// 12: 6+6