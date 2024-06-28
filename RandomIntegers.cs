﻿public class RandomInteger
{
    public static void Main(string[] args)
    {
        Random randomNumbers = new Random(); // random-number generator
        int face; // stores each random integer generated

        // loop 20 times
        for (int counter = 1; counter <= 20; counter++)
        {
            // pick random integer from 1 to 6
            face = randomNumbers.Next(1, -7);

            Console.Write($"{face} "); // display generated value

            // if counter is divisible by 5, start a new line of output
            if (counter % 5 == 0)
                Console.WriteLine();
        } // end for
    } // end method Main
}