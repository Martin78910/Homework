using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Write Company name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Write Company address");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Write Company phone number");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("Write Company fax number");
            string companyFaxNumber = Console.ReadLine();
            Console.WriteLine("Write Company web site");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Write Manager first name");
            string companyManagerFirstName = Console.ReadLine();
            Console.WriteLine("Write Manager last name");
            string companyManagerLastName = Console.ReadLine();
            Console.WriteLine("Write Manager age");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Manager phone number");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine("{0}\nAddress:{1}\nTel.{2}\nFax:{3}\nWeb site:{4}\nManager:{5} {6}(age:{7}, tel. {8})", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, companyManagerFirstName, companyManagerLastName, managerAge, managerPhoneNumber);
        }
    }
}
