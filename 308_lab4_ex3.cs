using System;
using System.Collections.Generic;

public interface IDice{
    int Next();
    int Next(int seed);
}

public class DiceEvaluator{
    static public void Evaluate(IDice d){
        double sum = 0f;
        int[] times = new int[7];
        for (int i = 0; i < 50; i++){
            int roll = d.Next(6);
            times[roll]++;
            sum += roll; 
        }
        for (int i = 1; i < 6; i++){
            for (int j = 0; j < 10; j++){
                int roll = d.Next(i);
                times[roll]++;
                sum += roll; 
            }
        }
        double average = sum / 100;
        Console.WriteLine("Dice roll average of 100 runs: {0}", average);
        Console.WriteLine("Statistics: ");
        for (int i = 1; i <= 6; i++){
            Console.WriteLine("{0} : {1}", i, times[i]);
        }
    }
}

public class RiggedDice : IDice{
    private Random rnd;
    public RiggedDice(int seed){
        rnd = new Random(seed);
    }
    public int Next(int seed2){
        if (seed2 == 6)
        {
            return 6;
        }
        else return seed2;
    }
    public int Next(){
        return rnd.Next(1,6);
    }
}

public class Program{
    public static void Main(){
        DiceEvaluator.Evaluate(new RiggedDice(100));
    }
}