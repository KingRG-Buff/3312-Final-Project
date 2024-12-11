using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
    {

    }

    public DbSet<Student> Students {get; set;}
}