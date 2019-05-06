using System;
using System.Collections;
using System.Collections.Generic;

public class QuadraticEq
{
    public int a, b, c;
    private double discriminant;
    public double Discriminant
    {
        get { return discriminant; }
    }
    public QuadraticEq(int va, int vb, int vc)
    {
        a = va;
        b = vb;
        c = vc;
        discriminant = (b * b) - (4 * a * c);
    }
    public double[] GetRealRoots()
    {
        double r1, r2;

        if (discriminant.Equals(0.0))
        {
            r1 = -b / (2.0 * a);
            r2 = r1;
            double[] rootlist = new double[] { r1 };
            return rootlist;
        }
        else if (discriminant > 0)
        {
            r1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            r2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double[] rootlist = new double[] { r1, r2 };
            return rootlist;
        }
        else
        {
            double[] rootlist = new double[] { };
            return rootlist;
        }
    }
}
public class program
{
    public static void Main()
    {
        QuadraticEq q = new QuadraticEq(1, 5, 6);
        Console.WriteLine("d = {0}", q.Discriminant);
        double[] results = q.GetRealRoots();
        foreach (double x in results)
            Console.WriteLine(x);

    }
}
