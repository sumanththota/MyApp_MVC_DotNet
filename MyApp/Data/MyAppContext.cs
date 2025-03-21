using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data;
// Dbcontext class acts as bridge that connects the project to the database.
public class MyAppContext : DbContext
{
    //initializing the constructor
    public MyAppContext(DbContextOptions<MyAppContext> options) //enables the configurations for the context
        : base(options)
    {
    }
    public DbSet<Item> Items { get; set; } = default!; //DbSet is a collection of entities that can be queried from the database
    
}