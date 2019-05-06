using System;
using System.Collections.Generic;
public class FibonacciDice
{
    public Random rnd;
    public int seed;
    private int sides; 
    public int Sides
    {
        get { return sides; }
    }
    public FibonacciDice(int pSeed, int pSides)
    {
        seed = pSeed;
        sides = pSides;
        rnd = new Random(seed);
    }
    public int Next()
    {
        int first = 0, second = 1, sum = 0;
        List<int> aimlist = new List<int>();
        aimlist.Add(1);
        for (int i = 2; i <= sides; i++)
        {
            sum = first + second;
            aimlist.Add(sum);
            first = second;
            second = sum;
        }
        int show = aimlist[rnd.Next(aimlist.Count)];
        return show;
    }
}

public class program
{
    public static void Main()
    {
        FibonacciDice d = new FibonacciDice(999,7);
        Console.WriteLine(d.Sides);
        for (int i = 0; i < 100; i++)
            Console.WriteLine(d.Next());
    }
}