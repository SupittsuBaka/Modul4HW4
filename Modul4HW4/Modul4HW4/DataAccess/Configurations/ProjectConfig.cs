using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Services;
using Modul4HW4.Entities;

namespace Modul4HW4.DataAccess.Configurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        private EntityProvider _entityProvider = new EntityProvider();
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Budget).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.ClientId).IsRequired();
            builder.HasOne(t => t.Client).WithMany(h => h.Projects).HasForeignKey(p => p.ClientId);
            builder.HasData(_entityProvider.GetProjects());
        }
    }
}
