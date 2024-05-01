using Microsoft.EntityFrameworkCore;
using ProiectVladHeghedus.Models;

public class SchoolDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
    {
        
    }
}
