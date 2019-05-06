using System;

public class program
{

    static int counter(array){
       Dictionary<int, int> countOfItems = new Dictionary<int, int>();
       foreach (int eachNumber in array){
        if (countOfItems.ContainsKey(eachNumber)){
            countOfItems[eachNumber]++;
        }
        else
            countOfItems[eachNumver]++;
       }
       return countOfItems;
    }

    static int maxcount(){

    }

    public static void Main()
    {
        int[] a = {4,8,6,7,8};   
        counter(a);
        maxcount(a);

        Console.WriteLine(counter());
    }

}