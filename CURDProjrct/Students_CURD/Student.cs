using CURDProject.Product_CURD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Students_CURD
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public char Grade { get; set; }
        public string Department { get; set; }
    }
    public class StudentCURD
    {
        private List<Student> studentlist;
        public StudentCURD()
        {
            studentlist = new List<Student>()

            {
                new Student { RollNo = 1, Name = "Vishwanath", Grade = 'A', Department = "Computer Science" },
                new Student { RollNo = 2, Name = "Sagar", Grade = 'B', Department = "English" }
            };
        }

        public List<Student> GetStudents()
        {
            return studentlist;
        }

        public Student GetStudentByRollNO(int rollNo)
        {
            //search for roll no in collection
            Student student = new Student();
            foreach(Student s in studentlist)
            {
                if(s.RollNo == rollNo)//search roll no
                {
                    student=s; 
                    break;
                }
                
            }
            return student;

        }
        public void AddStudent(Student s)
        {
            studentlist.Add(s);

        }
        public void UpdateStudent(Student s)
        {
            foreach(Student item in studentlist)
            {
                if (item.RollNo ==s.RollNo)
                {
                    item.Name = s.Name;
                    item.Grade = s.Grade;
                    item.Department = s.Department;
                    break;
                }
            }
        }
        public void DeleteStudent(int RollNo)
        {
            foreach(Student item in studentlist)
            {
                if(item.RollNo == RollNo)
                {
                    studentlist.Remove(item);
                    break;
                }
            }
        }
    }
}
