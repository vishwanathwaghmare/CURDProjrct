using CURDProject.Product_CURD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Students_CURD
{
    public class Program1
    {
        static void Main(string[] args)
        {
            int n = 0;
            StudentCURD curd = new StudentCURD();
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Student List");
                Console.WriteLine("2. Get Student By RollNO");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Select your option");
                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        List<Student> list = curd.GetStudents();
                        Console.WriteLine("RollNo \t Name \t   Grade \t   Department");
                        foreach (Student student in list)
                        {
                            Console.WriteLine($"{student.RollNo} \t{student.Name} \t{student.Grade} \t{student.Department}");
                        }
                        break;
                        Console.WriteLine("---------------------------------");
                    case 2:
                        Console.WriteLine("Enter the Students RollNo");
                        int rollNo = Convert.ToInt32(Console.ReadLine());
                        Student s = curd.GetStudentByRollNO(rollNo);
                        Console.WriteLine("RollNo\t  Name\t    Grade\t    Department");
                        Console.WriteLine($"{s.RollNo} \t{s.Name} \t{s.Grade} \t{s.Department}");
                        break;
                    case 3:
                        Student s1= new Student();
                        Console.WriteLine("Enter student Roll no");
                        s1.RollNo=Convert.ToInt32(Console.ReadLine()) ;
                        Console.WriteLine("Enter name of student");
                        s1.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Grade of student");
                        s1.Grade=Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Enter Department of Student");
                        s1.Department = Convert.ToString(Console.ReadLine());
                        curd.AddStudent(s1);
                        break;
                    case 4:
                        Student s2= new Student();
                        Console.WriteLine("Enter Roll no of student");
                        s2.RollNo=Convert.ToInt32(Console.ReadLine()) ;
                        Console.WriteLine("Enter name of student");
                        s2.Name=Convert.ToString(Console.ReadLine()) ;
                        Console.WriteLine("Enter Grade of Student");
                        s2.Grade=Convert.ToChar(Console.ReadLine()) ;
                        Console.WriteLine("Enter Department of student");
                        s2.Department=Convert.ToString(Console.ReadLine() );    
                        curd.UpdateStudent(s2);
                        break;
                    case 5:
                        Console.WriteLine("Enter student roll no");
                        int rollno=Convert.ToInt32(Console.ReadLine()) ;
                        curd.DeleteStudent(rollno);
                        break;



                }
                Console.WriteLine("Press 1 for contine");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n == 1);
        }
    }
}
