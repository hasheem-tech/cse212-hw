using System;



public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        var ways = CountWaysToClimb(5);
        Console.WriteLine(ways);

        // 1 1 1 1 1, 2 1 1 1 , 1 2 1 1, 1 1 2 1, 1 1 1 2, 2 2 1, 2 1 2, 1 2 2, 
        // 3 1 1, 1 3 1, 1 1 3, 3 2, 2 3

    }
     public static decimal CountWaysToClimb(int s)
    {
        // Base Cases
        if (s < 0) 
            return 0;
        if (s == 0)
            return 0;
        if (s == 1)
            return 1;
        if (s == 2)
            return 2;
        if (s == 3)
            return 4;

        // TODO Start Problem 3

        // Solve using recursion
        decimal ways = CountWaysToClimb(s - 1) + CountWaysToClimb(s - 2) + CountWaysToClimb(s - 3);
        return ways;
    }

    
}

