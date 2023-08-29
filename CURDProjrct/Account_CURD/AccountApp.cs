using CURDProject.Book_CURD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Account_CURD
{
    public class AccountApp
    {
        static void Main(string[] args)
        {
            int no = 0;
            AccImplementation acc = new AccImplementation();

            do
            {

                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Show account details");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. Delete Account");
                Console.WriteLine("5. Search Account");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Select your option");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Add Account ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        acc.AddAccount(n);
                        break;
                    case 2:
                        Console.WriteLine("Show the Account Details");
                        acc.ShowAllAccount();
                        break;
                    case 3:
                        Console.WriteLine("enter the acc_no for update");
                        int accn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the balance");
                        int balance = int.Parse(Console.ReadLine());
                        acc.UpadteAccount(accn, balance);
                        break;
                    case 4:
                        Console.WriteLine("Enter the acc_no for delete");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        acc.DeleteAccount(accno);
                        break;
                    case 5:
                        Console.WriteLine("Enter acc_no for search");
                        int accn1 = int.Parse(Console.ReadLine());
                        acc.SearchAccByAcNo(accn1);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                no = Convert.ToInt32(Console.ReadLine());


            }
            while (no == 1);
            {

            }

        }
    }
}
