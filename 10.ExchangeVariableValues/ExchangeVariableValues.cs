using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchanging the value of a is {0} and the value of b is {1}!", a, b);
        Console.WriteLine();
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After the exchanging the value of a is {0} and the value of b is {1}!", a, b);
        Console.WriteLine();
    }
}