using Lab10.Entities.Config;
using Microsoft.EntityFrameworkCore;

namespace Lab10.Entities;

public class UniversityDBContext : DbContext
{
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Group> Groups { get; set; }

    public UniversityDBContext()
    {
        
    }

    public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupEfConfig).Assembly);
    }
    
}