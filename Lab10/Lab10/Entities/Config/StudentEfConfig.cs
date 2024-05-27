using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab10.Entities.Config;

public class StudentEfConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.Id).HasName("Student_pk");
        builder.Property(x => x.Id).ValueGeneratedNever();

        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.IndexNumber).IsRequired().HasMaxLength(15);
        
        builder.has
        
        

    }
    
}