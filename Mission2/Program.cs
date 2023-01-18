using System;
using System.Linq;
//Alex Merrifield
class Program
{
    static void Main(string[] args)
    {
        //Set an array that has space for all possible roll totals
        int[] counts = new int[13];
        int numRolls;
        Console.Write("Welcome to the dice throwing simulator!" + "\n");
        Console.Write("How many dice rolls would you like to simulate?" + "\n");

        numRolls = int.Parse(Console.ReadLine());

        //Roll two dice for a random value between 1-6. Add them together to put in the counts array
        Random rand = new Random();
        for (int i = 0; i < numRolls; i++)
        {
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int rollTotal = roll1 + roll2;
            counts[rollTotal]++;            
        }

        Console.Write("DICE ROLLING SIMULATION RESULTS" + "\n");
        Console.Write("Each \"*\" represents 1% of the total number of rolls." + "\n");
        Console.Write("Total number of rolls = " + numRolls + "." + "\n");


        //Creates the Histogram structure

        Console.WriteLine("\nHistogram:" + "\n");
        for (int i = 2; i <= 12; i++)
        {
            //This will find the percentage of the counts 
            double percentage = (double)counts[i] / numRolls * 100;
            Console.Write(i + ": ");

            //This loop will crate an "*" for every increment within 100% and if that i counter should get another asterisk
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.Write("\n" + "Thank you for using the dice throwing simulator. Goodbye!");

        Console.ReadLine();
    }
}
