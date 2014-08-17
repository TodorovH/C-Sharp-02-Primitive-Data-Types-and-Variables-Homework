using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.BufferHeight = 300;
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine(symbol);
        }
    }
}