using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object concatenation = firstWord + " " + secondWord;
        string full = (string)concatenation;
        Console.WriteLine(full);
    }
}