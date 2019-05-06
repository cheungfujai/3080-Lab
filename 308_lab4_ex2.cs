using System;
using System.Collections.Generic;

public interface IDice
{
    int Next();
}

public class Dice
{
    protected Random rnd;

    public Dice(int seed)
    {
        rnd = new Random(seed);
    }

    public virtual int Next()
    {
        return rnd.Next(1, 7);
    }
}


public class FairRandom : IDice
{
    private Random rnd;
    private int lastNumber = 3;
    public FairRandom(int test)
    {
        rnd = new Random(test);
    }
    public int Next()
    {
        int num;
        if (lastNumber == 6)
        {
            num = rnd.Next(1, 3);
        }
        else if (lastNumber == 1)
        {
            num = rnd.Next(5, 7);
        }
        else
        {
            num = rnd.Next(1, 7);
        }
        lastNumber = num;
        return num;
    }
}

public class Program
{
    public static void Main()
    {
        FairRandom test = new FairRandom(6);

        for (int i = 0; i < 100; i++)
            Console.WriteLine(test.Next());

    }
}