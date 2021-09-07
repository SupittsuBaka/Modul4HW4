using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.DateOfBirth).HasMaxLength(7);
            builder.Property(t => t.Revenue).IsRequired();
            builder.HasData(_entityProvider.GetClients());
        }
    }
}