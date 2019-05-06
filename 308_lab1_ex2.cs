using System;

public class program
{

    static int rndGenerate()
    {
        Random random = new Random();
        int dice = random.Next(1, 7);
        return dice;
    }

    public static void Main()
    {
        Console.WriteLine(rndGenerate());

    }

}