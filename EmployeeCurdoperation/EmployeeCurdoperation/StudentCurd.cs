using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCurdoperation
{
    internal class Program1
    {
        public class Student
        {
            public int rollno { get; set; }
            public string Name { get; set; }
            public char section { get; set; }

            public override string ToString()
            {
                return $"{rollno} , {Name} ,{section}";
            }

            //MANAGE Student
            public class StudentCURD
            {
                List<Student>Students;

                //constructor
                public StudentCURD()
                {
                    Students = new List<Student>();//list is empty
                }

                //ADD METHOD
                public void AddStudent(Student stu)
                {
                    Students.Add(stu);
                }

                //MODIFY METHOD
                public void ModifyStudent(Student stu)
                {  //1.iterate over collection, find that product object & replace the values
                    for (int i = 0; i < Students.Count; i++)
                    {
                        if (Students[i].rollno == stu.rollno)
                        {
                            Students[i].Name = stu.Name;
                            Students[i].section = stu.section;
                            break;
                        }

                    }
                }
                //MODIFY METHOD
                public void DeleteStudent(int rollno)
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        if (Students[i].rollno ==rollno )
                        {
                            Students.RemoveAt(i);
                            break;
                        }

                    }
                }

                //GETSTUDENTSBYID
                public Student GetStudentByrollno(int rollno)
                {
                    Student s = new Student();
                    foreach (var item in Students)
                    {
                        if (item.rollno == rollno)
                        {
                            s.rollno = item.rollno;
                            s.Name = item.Name;
                            s.section = item.section;
                            break;
                        }

                    }
                    return s;
                }

                //DISPLAY EMPLOYEE
                public List<Student> StudentsList()
                {
                    return Students;
                }


            }


        }
    }
}

