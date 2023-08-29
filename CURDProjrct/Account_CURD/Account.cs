using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Account_CURD
{
    public class Account
    {
        int acc_no;
        string acc_type;
        string holder_name;
        int balance;

        public Account(int acc_no, string acc_type, string holder_name, int balance)
        {
            this.Acc_No = acc_no;
            this.Acc_Type = acc_type;
            this.Holder_Name = holder_name;
            this.Balance = balance;
        }
        public override string ToString()
        {
            return acc_no + " " + acc_type + " " + holder_name + " " + balance;
        }
        public int Acc_No { get => acc_no; set => acc_no = value; }
        public string Acc_Type { get => acc_type; set => acc_type = value; }
        public string Holder_Name { get => holder_name; set => holder_name = value; }
        public int Balance { get => balance; set => balance = value; }
    }
}
