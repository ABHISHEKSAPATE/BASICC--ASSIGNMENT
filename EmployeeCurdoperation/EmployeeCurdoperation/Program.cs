//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmployeeCurdoperation
//{
//    internal class Program
//    {
//        public class Student
//        {
//            public int Eid { get; set; }
//            public string Name { get; set; }
//            public float salary { get; set; }

//            public override string ToString()
//            {
//                return $"EID : {Eid}  NAME:{Name} SALARY:{salary}";
//            }

//            //MANAGE EMPLOYEE
//            public class EmployeeCURD
//            {
//                List<Student> Employes;

//                //constructor
//                public EmployeeCURD()
//                {
//                    Employes = new List<Student>();//list is empty
//                }

//                //ADD METHOD
//                public void AddEmployee(Student emp)
//                {
//                    Employes.Add(emp);
//                }

//                //MODIFY METHOD
//                public void ModifyEmployee(Student emp)
//                {  //1.iterate over collection, find that product object & replace the values
//                    for (int i=0;i<Employes.Count;i++)
//                    {
//                        if (Employes[i].Eid==emp.Eid)
//                        {
//                            Employes[i].Name = emp.Name;
//                            Employes[i].salary = emp.salary;
//                            break;
//                        }

//                    }
//                }
//                //MODIFY METHOD
//                public void DeleteEmployee(int eid)
//                {  
//                    for (int i = 0; i < Employes.Count; i++)
//                    {
//                        if (Employes[i].Eid == eid)
//                        {
//                            Employes.RemoveAt(i);
//                            break;
//                        }

//                    }
//                }

//                //GETEMPLOYEEBYEID
//                public Student GetEmployeeById (int eid)
//                {
//                    Student e = new Student();
//                    foreach (var item in Employes)
//                    {
//                        if(item.Eid== eid)
//                        {
//                            e.Eid = item.Eid;
//                            e.Name = item.Name;
//                            e.salary = item.salary;
//                            break;
//                        }

//                    }
//                    return e;
//                }

//                //DISPLAY EMPLOYEE
//                public List<Student>EmployeeList()
//                {
//                    return Employes;
//                }


//            }
          
           
//        }
//    }
//}
