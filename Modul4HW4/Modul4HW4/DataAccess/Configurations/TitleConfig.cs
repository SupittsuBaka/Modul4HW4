using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class TitleConfig : IEntityTypeConfiguration<Title>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.HasData(_entityProvider.GetTitles());
        }
    }
}
