using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public class CareerEventDbContext : DbContext
{
    public CareerEventDbContext(DbContextOptions<CareerEventDbContext> options)
            : base(options)
    {

    }

    public DbSet<CareerEvent> CareerEvents {get; set;} = default!;
}