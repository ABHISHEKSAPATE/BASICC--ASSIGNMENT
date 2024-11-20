//using System;
//using System.Collections.Generic;
//using static EmployeeCurdoperation.Program;
//using static EmployeeCurdoperation.Program.Student;


//namespace EmployeeCurdoperation
//{
//    public class Class1
//    {
//        //static void Main(string[] args)
//        //{
//        //    try
//        //    {
//        //        EmployeeCURD curd = new EmployeeCURD();
//        //        int a = 1;
//        //        do
//        //        {


//        //            Console.WriteLine("1.Employee List");
//        //            Console.WriteLine("2.Add Employee");
//        //            Console.WriteLine("3.Modify Employee");
//        //            Console.WriteLine("4.Delete Employee");
//        //            Console.WriteLine("5.Get Employee By Id");
//        //            Console.WriteLine("Select option from above");
//        //            int op = Convert.ToInt32(Console.ReadLine());

//        //            switch (op)
//        //            {
//        //                case 1:
//        //                    List<Employee> employes = curd.EmployeeList();
//        //                    Console.WriteLine("EId    Name    Salary");
//        //                    foreach (var item in employes)
//        //                    {
//        //                        Console.WriteLine(item);
//        //                    }
//        //                    break;
//        //                case 2:
//        //                    Employee p1 = new Employee();
//        //                    Console.WriteLine("Enter EId");
//        //                    p1.Eid = Convert.ToInt32(Console.ReadLine());
//        //                    Console.WriteLine("Enter Name");
//        //                    p1.Name = Console.ReadLine();
//        //                    Console.WriteLine("Enter Salary");
//        //                    p1.salary = Convert.ToInt32(Console.ReadLine());
//        //                    curd.AddEmployee(p1);
//        //                    Console.WriteLine("Added the Employee");
//        //                    break;
//        //                case 3:
//        //                    Employee p2 = new Employee();
//        //                    Console.WriteLine("Enter existing Id");
//        //                    p2.Eid = Convert.ToInt32(Console.ReadLine());
//        //                    Console.WriteLine("Enter new Name");
//        //                    p2.Name = Console.ReadLine();
//        //                    Console.WriteLine("Enter new Price");
//        //                    p2.salary = Convert.ToInt32(Console.ReadLine());
//        //                    curd.ModifyEmployee(p2);
//        //                    Console.WriteLine("updated the employee");
//        //                    break;
//        //                case 4:
//        //                    Console.WriteLine("Enter existing Id to delete");
//        //                    int id = Convert.ToInt32(Console.ReadLine());
//        //                    curd.DeleteEmployee(id);
//        //                    Console.WriteLine("Deleted the product");
//        //                    break;
//        //                case 5:
//        //                    Console.WriteLine("Enter existing Id");
//        //                    int id2 = Convert.ToInt32(Console.ReadLine());
//        //                    Employee p = curd.GetEmployeeById(id2);
//        //                    Console.WriteLine(p);
//        //                    break;
//        //            }
//        //            Console.WriteLine("Press 1 for continue or 0 to exit");
//        //            a = Convert.ToInt32(Console.ReadLine());


//        //        }
//        //        while (a == 1);

//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        Console.WriteLine(ex.Message);
//        //    }


//        //}
//    }
//}
