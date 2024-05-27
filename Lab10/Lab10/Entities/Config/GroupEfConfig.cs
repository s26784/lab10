using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab10.Entities.Config;

public class GroupEfConfig : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(x => x.Id).HasName("Group_pk");
        // builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(e => e.Name).IsRequired().HasMaxLength(5);
        builder.ToTable(nameof(Group));

        Group[] groups =
        {
            new Group { Id = 1, Name = "18c" },
            new Group { Id = 2, Name = "38c" }
        };

        builder.HasData(groups);
    }
    
}