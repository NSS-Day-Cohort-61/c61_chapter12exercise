using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            var taco = new Company("Phony's", DateTime.Now);
            // Create three employees
            var employee1 = new Employee
            {
                FirstName = "Phony",
                LastName = "McPhony",
                Title = "CEO",
                StartDate = DateTime.Now
            };

            var employee2 = new Employee
            {
                FirstName = "Employee",
                LastName = "McEmployee",
                Title = "Employee",
                StartDate = DateTime.Now
            };

            var employee3 = new Employee
            {
                FirstName = "Employee2",
                LastName = "McEmployee2",
                Title = "Employee2",
                StartDate = DateTime.Now
            };



            // Assign the employees to the company
            taco.Employees.Add(employee1);
            taco.Employees.Add(employee2);
            taco.Employees.Add(employee3);
            

            Console.WriteLine($"{taco.Employees[0].ToString()}");
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            taco.ListEmployees();

        }
    }
}