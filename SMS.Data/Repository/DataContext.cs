using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SMS.Data.Entities;

namespace SMS.Data.Repository;

// changed visibility from public to internal to ensure the DataContext is not accessible outside the Data project.
internal class DataContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseSqlite("Filename=data.db");
        //.LogTo(Console.WriteLine, LogLevel.Information);
    }

    // custom method used in development to keep database in sync with models
    public void Initialise() 
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
}

