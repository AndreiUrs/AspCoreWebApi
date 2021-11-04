using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities;


public class CompanyConfig : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {      
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
        builder.Property(x => x.Address).IsRequired().HasMaxLength(60);
        builder.Property(x=>x.Country).IsRequired().HasMaxLength(60);
    }
}

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(30).IsRequired();
        builder.Property(x => x.Position).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Age).IsRequired();

        builder.HasOne<Company>()
            .WithMany(x=>x.Employees)
            .IsRequired();

    }
}
