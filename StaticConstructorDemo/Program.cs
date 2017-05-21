using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorDemo
{

    public class Employee
    {
        public static int empNum;
        int empID;
        public int Salary;

        static Employee()
        {
            empNum = 1000;
        }
        /// <summary> 
        /// Constructor to initialize annual salary 
        /// </summary> ///
        /// <param name="annualSalary">
        /// Annual salary to initialize </param> ///

        public Employee()
        {
            empID = empNum++;
        }

        public Employee(int annualSalary)
        {
            Salary = annualSalary;
            // Salary = 0;

        }
        /// <summary> Constructor to initialize salary for few weeks /// </summary> /// <param name="weeklySalary">The salary per week </param> /// <param name="numberOfWeeks">The no. of Weeks for which salary has to be calculated </param> 
        /// 
        public Employee(int weeklySalary, int numberOfWeeks)
        {
            Salary = weeklySalary * numberOfWeeks;
        }
        /// Step 4: Write a method DisplayID() in the 
        /// Employee class to print the ID of the Employee object.

        public void DisplayID()
        {
            
            Console.WriteLine("This is the example " + " " + empID);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            /// Objective: To understand the static members of a class and learn static constructor.
            /// Background: A static constructor is used to initialize the static fields of the class.
            /// A static constructor is called only once in the lifetime of the program.
            /// Problem Description: Initialize employeeId to 1000, so that the Employee objects get successive employeeId.
            /// 
            /// Step 1: Open the project created in the previous assignment.
            /// Add two data members in Employee class,
            /// empNum and empID, as follows:
            /// Step 2: Write the following static 
            /// constructor that initializes the static field count to 1000.
            /// Step 3: Add the following line to the other 
            /// Employee constructor as follows:
            // Creating objects of Employee Class 

            Employee empObj1 = new Employee(30000);
            Employee empObj2 = new Employee(500, 52);
            Employee empObj3 = new Employee(40000);
            Employee empObj4 = new Employee();





            // Printing the salaries of the employees 
            Console.WriteLine("First employee - Salary {0}", empObj1.Salary);
            Console.WriteLine("Second employee - Salary {0}", empObj2.Salary);


            Console.WriteLine("Third employee - Salary {0}", empObj3.Salary);

            /// Step 5: Create an Employee object and display its 
            /// ID by calling the DisplayID() method.empObj1.DisplayID();
            empObj1.DisplayID();
            /// Step 6: Repeat Step 5 for at least 3 Employee objects.
            empObj2.DisplayID();
            empObj3.DisplayID();
            empObj4.DisplayID();





            Console.ReadLine();



            

            
            /// Step 7: Compile the program.Note your observation.
            /// Summary of this exercise:
            /// You have just learned to How to write a static constructor.
        }
    }
}
