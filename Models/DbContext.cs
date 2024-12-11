using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public class EventDbContext : DbContext
{
    public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
    {

    }

    public DbSet<Event> Events {get; set;}
}