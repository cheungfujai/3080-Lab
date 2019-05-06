using System;

public class Program{
    
    static void PrintArray(int[] a){

        for (int i = 0; i < a.Length; i++){
            Console.WriteLine("{0}", a[i]);

            if (i == a.Length - 1){
                return;
            }
                if (a[i] == 0 && a[i + 1] == 0){
                    return;
                }

            if (a[i] == -1){
                return;
            }
        }
        return;
    }

    public static void Main(){
        int[] a = { 4, 5, 6, 7, 8, -1, 5, 4, 3, 2 };   // terminate at -1
        int[] b = { 4, 5, 0, 7, 0, 0, 5, 4, 3, 2 };    // terminate at third 0
        int[] c = { 4, 5, 0, 7, 8, 0, 5, 4, 3, 2 };    // terminate at the end
        PrintArray(a);

    }

}
