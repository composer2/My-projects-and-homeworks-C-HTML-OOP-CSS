using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            var CompanyName = Console.ReadLine();
            var CompanyAddress = Console.ReadLine();
            var PhoneNumber = Console.ReadLine();
            var FaxNumber =Console.ReadLine();
            var WebSite = Console.ReadLine();
            var ManagerFirstName = Console.ReadLine();
            var ManagerLastName = Console.ReadLine();
            var ManagerAge = int.Parse(Console.ReadLine());
            var ManagerPhone = Console.ReadLine();

            Console.WriteLine(CompanyName);
            Console.WriteLine("Address: {0}",CompanyAddress);
            Console.WriteLine("Tel. {0}",PhoneNumber);
            if (FaxNumber=="")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}",FaxNumber);
            }

            Console.WriteLine("Web site: {0}",WebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",ManagerFirstName,ManagerLastName,ManagerAge,ManagerPhone);
        }
    }
}
