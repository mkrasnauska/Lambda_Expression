using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
           {
               new Employee{Id=007,FirstName="Joe",LastName="Reese"},
               new Employee{Id=22,FirstName="Jacob",LastName="Grimes"},
               new Employee{Id=277,FirstName="Joe",LastName="Dude"},
               new Employee{Id=101,FirstName="Jessica",LastName="Simmons"},
               new Employee{Id=777,FirstName="Joe",LastName="Smith"},
               new Employee{Id=001,FirstName="Chris",LastName="Nolan"},
               new Employee{Id=004,FirstName="Joe",LastName="Rogan"},
               new Employee{Id=854,FirstName="Diana",LastName="Fox"},
               new Employee{Id=423,FirstName="Joe",LastName="Smith"},
               new Employee{Id=117,FirstName="Jolyne",LastName="Reese"},


           };
            int count = employees.Count(x => x.FirstName == "Joe");
            Console.WriteLine("We found " + count + " Joe's in our records");


            int counter = 0;
            foreach (Employee Employee in employees)
            {
                if (Employee.FirstName == "Joe")
                {
                    counter++;
                }

            }
            Console.WriteLine("We found " + counter + " Joe's in our records");



            List<Employee> IdList = employees.Where<Employee>(x => x.Id > 5).ToList();
            Console.WriteLine("The employees with Id greater than 5:");
            foreach (Employee employee in IdList)
            {

                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();

        }
    }
}
