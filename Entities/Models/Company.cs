namespace Entities.Models;

public class Company
{
    public Guid Id { get;}
    public string Name { get;}
    public string Address { get;}
    public string Country { get;}
    public ICollection<Employee> Employees { get; set; }

    public Company(string name, string address, string country)
    {
        Id = Guid.NewGuid();
        Country = country ?? throw new ArgumentNullException(nameof(country));
        Address = address ?? throw new ArgumentNullException(nameof(address));       
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
}
