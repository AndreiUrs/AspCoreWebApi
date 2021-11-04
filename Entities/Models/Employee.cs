namespace Entities.Models;

public class Employee
{
    public Guid Id { get;}
    public string Name { get;}
    public int Age { get;}
    public string Position { get;}

    public Employee(string name, string position, int age)
    {       
        Id = Guid.NewGuid();
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Position = position ?? throw new ArgumentNullException(nameof(position));
        Age = age;
    }
}
