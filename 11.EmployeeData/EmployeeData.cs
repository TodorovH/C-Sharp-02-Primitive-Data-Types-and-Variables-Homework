using System;
using System.Text;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter your first name: ");                 // Ivan
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");                  // Ivanov
        string lastName = Console.ReadLine();
        object fullName = firstName + " " + lastName;
        Console.Write("Enter your age: ");                        // 0...100
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.Write("Enter your gender (m or f): ");            // m or f
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Enter personal ID number: ");              // 8306112507
        long personalID = long.Parse(Console.ReadLine());
        Console.Write("Enter Unique Employee number: ");          // 27560000…27569999
        int uniqueEmpNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Employee name: {0} \nAge: {1} \nGender: {2} \nPersonal ID number: {3} \nUnique Employee number: {4}",
            fullName, age, gender, personalID, uniqueEmpNumber);
        Console.WriteLine();
    }
}