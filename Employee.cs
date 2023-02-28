using System;

public class Employee
{
    public string   FirstName { get; set; }
    public string   LastName { get; set; }
    public string   Title { get; set; }
    public DateTime StartDate { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} works as {Title} since {StartDate}";
    }
}

