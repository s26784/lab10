using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab10.Entities.Config;

public class StudentGroupEfConfig : IEntityTypeConfiguration<StudentGroup>
{
    public void Configure(EntityTypeBuilder<StudentGroup> builder)
    {
        builder.HasKey(x => new { x.IdGroup, x.IdStudent }).HasName("StudentGroup_pk");
        builder.Property(x => x.CreatedAt).IsRequired().HasDefaultValueSql("GETUTCDATE()");
        builder.HasOne(x => x.Student)
            .WithMany(x => x.StudentGroups)
            .HasForeignKey(x => x.IdGroup)
            .HasConstraintName("StudentGroup_Student")
            .OnDelete(DeleteBehavior.Restrict);
    }
}