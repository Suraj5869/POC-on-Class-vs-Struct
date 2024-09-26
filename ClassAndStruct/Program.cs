using ClassAndStruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //1. Type Classification
            Console.WriteLine("***** Type Classification *****");

            Console.WriteLine("Struct Student");
            StudentStruct student1 = new StudentStruct(1, "Kate");
            Console.WriteLine(student1.ToString());

            Console.WriteLine("Class Employee");
            EmployeeClass employee1 = new EmployeeClass(101, "Ram");
            Console.WriteLine(employee1.PrintDetails());

            //2. Memory Management
            Console.WriteLine("\n***** Memory Management *****");
            StudentStruct student2 = student1; //copy struct student1 to student2
            student2.StudentollNo = 3; //changes the value of student2
            student2.StudentName = "Bob"; //changes the value of student2
            
            Console.WriteLine("Copy the student1 into student2 and change the values of student2\n");
            Console.WriteLine("After Changes");

            //After changing the values of student2 cannot change the values of student1 in struct since the struct is value type
            Console.WriteLine("=== struct student1 ===");
            Console.WriteLine(student1.ToString());

            Console.WriteLine("=== struct student2 ===");
            Console.WriteLine(student2.ToString());

            EmployeeClass employee2 = employee1;//copy the class employee1 to employee2
            employee2.EmployeeId = 103;//changes the value of employee2
            employee2.EmployeeName = "Om";//changes the value of employee2

            Console.WriteLine("Copy the employee1 into employee2 and make changes in employee2\n");
            Console.WriteLine("After Changes");

            //After changing the values of employee2 can change the values of employee1 in class since the classe is refernce type
            Console.WriteLine("=== class Employee1 ===");
            Console.WriteLine(employee1.PrintDetails());

            Console.WriteLine("=== class Employee2 ===");
            Console.WriteLine(employee2.PrintDetails());


            //3. Inheritance
            Console.WriteLine("\n***** Inheritance *****");
            Console.WriteLine("=== Inheritance in Classes ===");

            ManagerClass manager = new ManagerClass(107, "Akash");//ManagerClass inherit the EmployeeClass
            Console.WriteLine(manager.PrintDetails());

            Console.WriteLine("We Cannot perform inheritance in Struct\n");


            //4. Default Constructor
            Console.WriteLine("\n***** Default Constructor *****");

            EmployeeClass defaultclass = new EmployeeClass();
            Console.WriteLine($"Default class values:\n{defaultclass.PrintDetails()}");

            //We cannot define the default constuctor on struct but compiler can automatically define it.
            StudentStruct defaultstruct = new StudentStruct();
            Console.WriteLine($"Default struct values:\n{defaultstruct.ToString()}");

           
           
        }

    
    }
}
