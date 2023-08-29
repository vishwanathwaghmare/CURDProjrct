using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Employee_CURD
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department{ get; set; }
    }

    public class EmployeeCURD
    {
        private List<Employee> employeelist;
        public EmployeeCURD()
        {
            employeelist = new List<Employee>()
            {
                new Employee{Id=101,Name="Vishwanath",Salary=50000,Department="Development"},
                new Employee{Id=102,Name="Akash",Salary=30000,Department="HR"}

            };

        }
        public List<Employee> GetEmployee() 
        {
            return employeelist;
        }

        public Employee GetEmpById(int id)
        {
            Employee employee = new Employee();
            foreach(Employee e in employeelist) 
            { 
                if(e.Id == id)
                {
                    employee=e;
                    break;
                }

            
            }
            return employee;
        }

        public void AddEmployee(Employee e)
        {
            employeelist.Add(e);
        }

        public void UpdateEmployee(Employee e)
        {
            foreach(Employee item in employeelist)
            {
                if(item.Id == e.Id) 
                {
                    item.Name = e.Name;
                    item.Salary = e.Salary;
                    item.Department = e.Department;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach(Employee item in employeelist)
            {
                if(item.Id == id)
                {
                    employeelist.Remove(item);
                    break;
                }
            }
        }
    }
}
