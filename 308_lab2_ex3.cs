using System;
using System.Collections.Generic;

    class MainClass{

        public static void Main(string[] args){
        
        Console.WriteLine("Generate 10 distinct random numbers ");
        Dictionary<int, int> guess = new Dictionary<int, int>();
        Random rnd = new Random();

        for (int i = 0; i < 10; i++){
            int middle = rnd.Next(1, 20);
            while (guess.ContainsKey(middle)){
                middle = rnd.Next(1, 20);
            }
            guess[middle] = rnd.Next(1, 10000);
        }

        foreach (KeyValuePair<int, int> pair in guess){
            Console.WriteLine("{0}   {1}", pair.Key, pair.Value);
        }

        Console.WriteLine("Please Input 2 distinct numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a == b || a > 20 || b > 20 || a < 0 || b < 0){
            Console.WriteLine("Quit the program");
        }

        int sum = 0;
        if (guess.ContainsKey(a) && guess.ContainsKey(b))
        {
            sum = guess[a] + guess[b];
            Console.WriteLine("You earned {0} in total!", sum);
        }
        else
        {
            if (guess.ContainsKey(a) == false && guess.ContainsKey(b) == false)
            {
                sum = 0;
                Console.WriteLine("You earned {0} in total!", sum);
            }
            else
            {
                if (guess.ContainsKey(a) == false && guess.ContainsKey(b))
                {
                    sum = guess[b];
                    Console.WriteLine("You earned {0} in total!", sum);
                }
                if (guess.ContainsKey(b) == false && guess.ContainsKey(a))
                {
                    sum = guess[a];
                    Console.WriteLine("You earned {0} in total!", sum);
                }
            }
        }
        }
}
