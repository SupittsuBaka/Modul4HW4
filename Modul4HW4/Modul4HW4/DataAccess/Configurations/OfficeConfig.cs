using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Location).IsRequired().HasMaxLength(100);
            builder.HasData(_entityProvider.GetOffices());
        }
    }
}
