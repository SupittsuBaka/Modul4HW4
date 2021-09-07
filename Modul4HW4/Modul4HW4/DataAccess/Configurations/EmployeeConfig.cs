using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.HiredDate).IsRequired().HasMaxLength(10);
            builder.Property(a => a.OfficeId).IsRequired();
            builder.Property(a => a.TitleId).IsRequired();
            builder.HasData(_entityProvider.GetEmployees());
        }
    }
}
