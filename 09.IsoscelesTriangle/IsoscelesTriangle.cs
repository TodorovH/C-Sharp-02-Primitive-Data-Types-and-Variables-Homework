using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
        Console.WriteLine();
        Console.WriteLine("This program will print isosceles triangle!");
        Console.WriteLine();
        Console.Write("Enter number for the base a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int b = a + a + 1;
        int n = 0;
        int c = a + 1;
        char emptySpace = ' ';
        char symbol = '©';
        for (int y = 0; y <= (a - 2); y++, c++)
        {
            for (n = a - 1; n >= 0; n--)
            {
                if ((y < (n + 1)) || (y > (n + 1)))
                {
                    Console.Write(emptySpace);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            for (int e = a + 1; e <= b; e++)
            {
                if ((c < e) || (c > e))
                {
                    Console.Write(emptySpace);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
            for (int x = 1; x <= b; x++)         // base of the triangle
            {
                if (x % 2 == 0)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(emptySpace);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
    }
}