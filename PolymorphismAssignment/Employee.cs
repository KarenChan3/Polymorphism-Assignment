using System;

public class Employee : IQuittable
{
    // employee ID.
    public int Id { get; set; }

    // employee's first name.
    public string FirstName { get; set; }

    // employee's last name.
    public string LastName { get; set; }

    // overload the == operator to compare two Employee objects by their ID.
    public static bool operator ==(Employee e1, Employee e2)
    {
        if (ReferenceEquals(e1, e2))
            return true;

        if (e1 is null || e2 is null)
            return false;

        return e1.Id == e2.Id;
    }

    // overload the != operator.
    public static bool operator !=(Employee e1, Employee e2)
    {
        return !(e1 == e2);
    }

    // override Equals to use the custom == operator for comparison.
    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return this == employee;
        }
        return false;
    }

    // override GetHashCode to be consistent with Equals.
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    // implement the Quit method from the IQuittable interface.
    public void Quit()
    {
        // print a message indicating the employee is quitting.
        Console.WriteLine($"{FirstName} {LastName} is quitting.");
    }
}
