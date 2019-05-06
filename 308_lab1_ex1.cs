using System;

public class Program
{
    static bool isPrime(int x)
    {
        // bool is a boolean type that has value of true/false
        // please implement this method

        if (x == 0 || x == 1){
            return false;
        }
        for (int i = 2; i < x; i++){
            if (x % i == 0){
                return false;
            }
        }
        return true;
    }

    public static void Main()
    {
        
        int x = 12;
        isPrime(x);
        // please implement this program

        if (isPrime(x) == true){
            Console.WriteLine("{0} is a prime Number", x);
        }
        else{
            Console.WriteLine("{0} is not a prime Number", x);
        }

    }
}