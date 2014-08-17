using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? d = null;
        Console.WriteLine(a);
        Console.WriteLine(d);
        a = a + null;
        d = d + null;
        Console.WriteLine(a);
        Console.WriteLine(d);
        a = a + 5;
        d = d + 10;
        Console.WriteLine(a);
        Console.WriteLine(d);
    }
}