using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> list = new List<int>();

        Console.WriteLine("Please input integers: (in one line)");


        string input = Console.ReadLine();
        string[] tokens = input.Split();   // split string into tokens "12 13 10" -> "12" "13" "10"


        foreach (string s in tokens)
        {
            try{
                int success = int.Parse(s);
                list.Add(success);
            }      
            catch{}

        }

        Console.WriteLine("Sorted input:");
        list.Sort();
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Sorted input in reverse:");
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }

    }
}