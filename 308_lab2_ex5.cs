using System;
using System.Collections.Generic;
using System.Linq; 

class MainClass{
    public static void Main(string[] args){
        // Declar the dictionary named: "guess"
        Dictionary<int, int> guess = new Dictionary<int, int>();
        Random rnd = new Random();

        // Generate 20 distintic random number && random price 
        for (int i = 0; i < 10; i++){
            int middle = rnd.Next(1, 20);
            while (guess.ContainsKey(middle)){
                middle = rnd.Next(1, 20);
            }
            guess[middle] = rnd.Next(1, 10000);
        }

        // Problem 5B.) Get the numbers of Key that are not in the dictionary
        List<int> record = new List<int>();
        for (int i = 1; i < 21; i++){
            if (guess.ContainsKey(i) == false){
                record.Add(i);
            }
        }

        // Problem 5A.) Get Key by Value
        int maxKey = 0;
        foreach (KeyValuePair<int, int> pair in guess){
            int max = guess.Values.Max();
            if (pair.Value == max){
                maxKey = pair.Key;
            }
        }

        // Print out the dictionary for checking
        foreach (KeyValuePair<int, int> pair in guess){
            Console.WriteLine("{0}   {1}", pair.Key, pair.Value);
        }
         
        //Input values of A and B by users
        Console.WriteLine("Please Input 2 distinct numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        // Compare Value A and B
        // Program is quitted
        if (a == b || a > 20 || b > 20 || a < 0 || b < 0){
            Console.WriteLine("Quit the program");
        }
        int sum = 0;
        // Sum up  A & B price, NON - 0
        if (guess.ContainsKey(a) && guess.ContainsKey(b)){
            sum = guess[a] + guess[b];
            Console.Write("You are so lucky! You could have 0 money if you have guessed ");
            foreach(int i in record){
                Console.Write(i);
                Console.Write(" ");
            }
        }
        else{
            // Both A & B are not in the dictionary
            if (guess.ContainsKey(a) == false && guess.ContainsKey(b) == false){
                Console.WriteLine("You are unlucky! If you guessed {0}, you would have won the most money!", maxKey);
            }
            else{
                // Either a || b is in the dictionary, NON - 0
                if (guess.ContainsKey(a) == false && guess.ContainsKey(b)){
                    sum = guess[b];
                    Console.Write("You are so lucky! You could have 0 money if you have guessed ");
                    foreach (int i in record)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
                // NON - 0
                if (guess.ContainsKey(b) == false && guess.ContainsKey(a)){
                    sum = guess[a];
                    Console.Write("You are so lucky! You could have 0 money if you have guessed ");
                    foreach (int i in record)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
