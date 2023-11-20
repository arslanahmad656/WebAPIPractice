using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(new Employee
            {
                Id = Guid.Parse("ce74a83e-c248-4389-9491-18a41c4cca1d"),
                Name = "Sam Raiden",
                Age = 26,
                Position = "Software Developer",
                CompanyId = Guid.Parse("021037b0-877f-11ee-b9d1-0242ac120002")
            },
            new Employee
            {
                Id = Guid.Parse("ac770f98-648e-4bf0-aaa2-ba8c0a7d262e"),
                Name = "Jana McLeaf",
                Age = 30,
                Position = "Software Developer",
                CompanyId = Guid.Parse("021037b0-877f-11ee-b9d1-0242ac120002")
            },
            new Employee
            {
                Id = Guid.Parse("756e30ab-0355-4a82-b2bf-899db1d60174"),
                Name = "Jana McLeaf",
                Age = 30,
                Position = "Software Developer",
                CompanyId = Guid.Parse("02103f94-877f-11ee-b9d1-0242ac120002")
            });
        }
    }
}
