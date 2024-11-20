using System;
using System.Collections.Generic;
using static EmployeeCurdoperation.Program1;
using static EmployeeCurdoperation.Program1.Student;




namespace EmployeeCurdoperation
{
    internal class Studentcurdclass
    {
        static void Main(string[] args)
        {
            try
            {
                StudentCURD curd = new StudentCURD();
                int a = 1;
                do
                {


                    Console.WriteLine("1.Student List");
                    Console.WriteLine("2.Add Student");
                    Console.WriteLine("3.Modify Student");
                    Console.WriteLine("4.Delete Student");
                    Console.WriteLine("5.Get Student By Rollno");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Student> students = curd.StudentsList();
                            Console.WriteLine("ROLLNO    NAME   SECTION");
                            foreach (var item in students)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            Student s2 = new Student();
                            Console.WriteLine("Enter Rollno");
                            s2.rollno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            s2.Name = Console.ReadLine();
                            Console.WriteLine("Enter Section");
                            s2.section = Convert.ToChar(Console.ReadLine());
                            curd.AddStudent(s2);
                            Console.WriteLine("Added the Student");
                            break;
                        case 3:
                            Student s3 = new Student();
                            Console.WriteLine("Enter existing rollno");
                            s3.rollno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            s3.Name = Console.ReadLine();
                            Console.WriteLine("Enter new Section");
                            s3.section = Convert.ToChar(Console.ReadLine());
                            curd.ModifyStudent(s3);
                            Console.WriteLine("updated the student");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing rollno to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            curd.DeleteStudent(id);
                            Console.WriteLine("Deleted the student");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing rollno");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Student p = curd.GetStudentByrollno(id2);
                            Console.WriteLine(p);
                            break;
                    }
                    Console.WriteLine("Press 1 for continue or 0 to exit");
                    a = Convert.ToInt32(Console.ReadLine());


                }
                while (a == 1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
