using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public class CareerEventDbContext : DbContext
{
    public CareerEventDbContext(DbContextOptions<CareerEventDbContext> options)
            : base(options)
    {

    }

    // Needed for Many-to-Many association entity
    // StudentRegistration entity has 2 attributes as the primary key.
    // This code tells EF Core that StudentID and CareerEventID combine for the primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentRegistration>()
            .HasKey(e => new {e.StudentID, e.CareerEventID});
    }

    public DbSet<Student> Students {get; set;} = default!;
    public DbSet<CareerEvent> CareerEvents {get; set;} = default!;
    public DbSet<StudentRegistration> StudentRegistrations {get; set;} = default!;
}
