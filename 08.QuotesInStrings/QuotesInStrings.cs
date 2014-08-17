using System;

class QuotesInStrings
{
    static void Main()
    {
        string withQuotations = "The \"use\" of quotations causes difficulties.";
        string withoutQuotations = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(withQuotations);
        Console.WriteLine(withoutQuotations);
    }
}