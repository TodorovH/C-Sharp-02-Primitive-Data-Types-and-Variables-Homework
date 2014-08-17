using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine();
        Console.Write("Enter the value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double eps = 0.000001d;
        double absAB = Math.Abs(a - b);
        bool compare = absAB >= eps;
        Console.WriteLine(!compare);
    }
}
