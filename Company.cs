using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public Company( string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees  { get; set; }

        public void ListEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}