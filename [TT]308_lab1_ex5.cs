using System;
public class Program{

    public static void Main(){
        
        int a = 3;
        int b = 5;
        int large, small;
        if (a > b){
            large = a;
            small = b;
        }
        else{
            large = b;
            small = a;
        }
        for (int y = 1; y <= large; y++){ // correct
            if (a != b){
                if (large == b){  // Extra "." printing
                    if (y <= (b - a)){
                        for (int x = 0; x < ((2 * a) - 1); x++){
                            Console.Write(".");
                        }
                    }
                    else{  // Print Small tree
                        for (int x = (large - y); x > 0; x--){
                            Console.Write(".");
                        }
                        for (int x = 1; x <= ((2 * (y - (b - a)) - 1)); x++){
                            Console.Write("*");
                        }
                        for (int x = (large - y); x > 0; x--){
                            Console.Write(".");
                        }
                    }
                    // Big tree
                    for (int x = (b - y); x > 0; x--){
                        Console.Write(".");
                    }
                    for (int x = 1; x <= (2 * y - 1); x++){
                        Console.Write("*");
                    }
                    for (int x = (b - y); x > 0; x--){
                        Console.Write(".");
                    }
                }
                if (large == a){  //Big Tree
                    for (int x = (a - y); x > 0; x--){
                        Console.Write(".");
                    }
                    for (int x = 1; x <= (2 * y - 1); x++){
                        Console.Write("*");
                    }
                    for (int x = (a - y); x > 0; x--){
                        Console.Write(".");
                    }
                    // Extra "." printing
                    if (y <= (a - b)){
                        for (int x = 0; x < ((2 * b) - 1); x++){
                            Console.Write(".");
                        }
                    }
                    // Print Small tree
                    else{// Print Small tree
                        for (int x = (large - y); x > 0; x--){
                            Console.Write(".");
                        }
                        for (int x = 1; x <= ((2 * (y - (a - b)) - 1)); x++){
                            Console.Write("*");
                        }
                        for (int x = (large - y); x > 0; x--){
                            Console.Write(".");
                        }
                    }
                }
            }
            if (a == b){
                for (int x = (a - y); x > 0; x--){
                    Console.Write(".");
                }
                for (int x = 1; x <= (2 * y - 1); x++){
                    Console.Write("*");
                }
                for (int x = (a - y); x > 0; x--){
                    Console.Write(".");
                }
                for (int x = (a - y); x > 0; x--){
                    Console.Write(".");
                }
                for (int x = 1; x <= (2 * y - 1); x++){
                    Console.Write("*");
                }
                for (int x = (a - y); x > 0; x--){
                    Console.Write(".");
                }
            }
            Console.Write("\n");
        }
    }
}