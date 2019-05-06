using System;
using System.Collections;
using System.Collections.Generic;

public class QuadraticEq
{
    public int a, b, c;
    public string readstring;
    public QuadraticEq(int va, int vb, int vc)
    {
        a = va;
        b = vb;
        c = vc;
    }
    public override string ToString()
    {
        return a + "x^2+" + b + "x+" + c;
    }

}

class MainClass
{
    public static void Main()
    {
        QuadraticEq q = new QuadraticEq(2, 4, 2);
        Console.WriteLine("Equation is {0}", q);
    }

}