using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.Property(a => a.Rate).IsRequired();
            builder.Property(a => a.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(a => a.EmployeeId).IsRequired();
            builder.Property(a => a.ProjectId).IsRequired();
            builder.HasData(_entityProvider.GetEmployeeProject());
        }
    }
}
