using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string secondName = "Ivanov";
            string lastName = "Ivanov";
            object fullName = firstName + " " + secondName + " " + lastName;
            decimal balance = 3000000.00m;
            string bankName = "DSKBank";
            string iban = "BG31BNBG96611000030007";
            long firstCardNumber = 12345678912345L;
            long secondCardNumber = 98765432101234L;
            long thirdCardNumber = 52491000599314L;
            Console.WriteLine("Holder name: {0} \nBalance: {1} \nBank: {2} \nIBAN: {3} \nVisa: {4} \nMastercard: {5} \nAmericanExpress: {6}",
                fullName, balance, bankName, iban, firstCardNumber, secondCardNumber, thirdCardNumber);
        }
    }
}
