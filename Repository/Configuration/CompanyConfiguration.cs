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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company
            {
                Id = Guid.Parse("021037b0-877f-11ee-b9d1-0242ac120002"),
                Name = "IT_Solutions Ltd",
                Address = "583 Wall Dr. Gwyn Oak, MD 21207",
                Country = "USA"
            }, new Company
            {
                Id = Guid.Parse("02103f94-877f-11ee-b9d1-0242ac120002"),
                Name = "Admin_Solutions Ltd",
                Address = "312 Forest Avenue, BF 923",
                Country = "USA"
            });
        }
    }
}
