using System;

class Program
{
    static void Main()
    {
        // create an Employee object.
        Employee employee = new Employee
        {
            Id = 1,
            FirstName = "Patrick",
            LastName = "Chan"
        };

        // create an IQuittable reference and assign it the Employee object.
        IQuittable quittableEmployee = employee;

        // call the Quit method on the IQuittable reference.
        quittableEmployee.Quit();

        // display the employee details.
        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, ID: {employee.Id}");

        // keep the console window open until a key is pressed.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
