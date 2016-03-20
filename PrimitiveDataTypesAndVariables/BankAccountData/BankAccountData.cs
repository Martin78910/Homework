using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Petrov";
            string lastName = "Ivanov";
            decimal balance = 51235412235123445678934567.89M;
            string bankName = "UniCredit Bulbank";
            string iban = "BG62UNCR56321478964135";
            ulong creditCard1 = 5846987521648;
            ulong creditCard2 = 8974586132457;
            ulong creditCard3 = 7845965413259;
            Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Available ammount of:{0} BGN in {1}", balance, bankName);
            Console.WriteLine("Personal Account Information\nIBAN:{0}", iban);
            Console.WriteLine("Credit Card(s) Number:\n{0}\n{1}\n{2}", creditCard1, creditCard2, creditCard3);
        }
    }
}
