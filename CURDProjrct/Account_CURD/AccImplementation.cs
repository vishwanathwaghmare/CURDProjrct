using CURDProject.Book_CURD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Account_CURD
{
    public class AccImplementation
    {
        Account[] account;
        int count;

        public AccImplementation()
        {
            account = new Account[5];
            count = 0;
        }
        public void AddAccount(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the Account Number");
                int accn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Account type");
                String acctype = Console.ReadLine();
                Console.WriteLine("Entre the Account holder name");
                string acchold = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Balance");
                int blnc = int.Parse(Console.ReadLine());
                account[count] = new Account(accn, acctype, acchold,blnc);
                count++;
            }
        }
        public void ShowAllAccount()
        {
            for (int i = 0; i < count; i++)
            {
                if (account[i] != null)
                {
                    Console.WriteLine(account[i]);
                }
            }
        }
        public void SearchAccByAcNo(int acc_no)
        {
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] != null)
                {
                    if (account[i].Acc_No == acc_no)
                    {
                        Console.WriteLine(account[i]);
                    }
                }
            }
        }
        public void UpadteAccount(int acc_no, int balance)
        {
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] != null)
                {
                    if (account[i].Acc_No == acc_no)
                    {
                        account[i].Balance = balance;
                    }
                }
            }
        }
        public void DeleteAccount(int acc_no)
        {
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] != null)
                {
                    if (account[i].Acc_No == acc_no)
                    {
                        account[i] = null;
                    }
                }
            }
        }
    }
}
