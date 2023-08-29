using CURDProject.Students_CURD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Employee_CURD
{
    public class Program3
    {
        static void Main(string[] args)
        {
            int n = 0;
            EmployeeCURD curd = new EmployeeCURD();

            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Employee List");
                Console.WriteLine("2. Get Employee By ID");
                Console.WriteLine("3. Add Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Select your option");
                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        List<Employee> list = curd.GetEmployee();
                        Console.WriteLine("Id \t Name \t   Salary \t   Department");
                        foreach (Employee emp in list)
                        {
                            Console.WriteLine($"{emp.Id} \t{emp.Name} \t{emp.Salary} \t{emp.Department}");
                        }
                        break;
                        Console.WriteLine("---------------------------------");
                    case 2:
                        Console.WriteLine("Enter the Employee ID");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee e = curd.GetEmpById(id);
                        Console.WriteLine("Id\t  Name\t    Salary\t    Department");
                        Console.WriteLine($"{e.Id} \t{e.Name} \t{e.Salary} \t{e.Department}");
                        break;
                    case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of Employee");
                        e1.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Salary of Employee");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department of Employee");
                        e1.Department = Convert.ToString(Console.ReadLine());
                        curd.AddEmployee(e1);
                        break;
                    case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of Employee");
                        e2.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Salary of Employee");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department of Employee");
                        e2.Department = Convert.ToString(Console.ReadLine());
                        curd.UpdateEmployee(e2);
                        break;
                    case 5:
                        Console.WriteLine("Enter Employee Id");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        curd.DeleteEmployee(eid);
                        break;


                }
                Console.WriteLine("Press 1 for contine");
                n = Convert.ToInt32(Console.ReadLine());

            }
            while (n == 1);
            {

            }
            
        }

    }
}
