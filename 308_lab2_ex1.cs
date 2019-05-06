using System;
using System.Collections.Generic;
    class MainClass{
    public static void RemoveLastTwo(List<int> rnlist){
        for (int i = 1; i <= 2; i++){
            rnlist.RemoveAt(rnlist.Count - 1);
        }
    }
        public static void Main(string[] args){
        Console.WriteLine("Create 8 distinct random numbers ");
            List<int> rnlist = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 8; i++){
            rnlist.Add(rnd.Next(1, 10));
            }
        Console.WriteLine("printing out the random number list: ");
            foreach(int i in rnlist){
                Console.Write(i);
                Console.Write(" ");
            }
        Console.Write("\n");
        Console.WriteLine("remove the last 2 numbers: ");
        RemoveLastTwo(rnlist);
        foreach (int i in rnlist){
            Console.Write(i);
            Console.Write(" ");
        }
        }
}