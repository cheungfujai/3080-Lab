using System;
using System.Collections;
using System.Collections.Generic;

public class Equation{
    protected int a, b, c;
    public Equation(int a, int b, int c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Equation(int b, int c){
        this.a = 0;
        this.b = b;
        this.c = c;
    }

    public Equation(int c){
        this.a = 0;
        this.b = 0;
        this.c = c;
    }

    public override string ToString(){
        return a + "x^2+" + b + "x+" + c;
    }
}

public class QuadraticEquation : Equation{
    public double[] Solve(){
        double discriminant;
        discriminant = (b * b) - (4 * a * c);
        double r1, r2;
        if (discriminant.Equals(0.0)){
            r1 = -b / (2.0 * a);
            r2 = r1;
            double[] rootlist = new double[] { r1 };
            return rootlist;
        }
        else if (discriminant > 0){
            r1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            r2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double[] rootlist = new double[] { r1, r2 };
            return rootlist;
        }
        else{
            double[] rootlist = new double[] { };
            return rootlist;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Equation e = new Equation(4, 5);
        Console.WriteLine("My equation: {0}", e);
    }
}
