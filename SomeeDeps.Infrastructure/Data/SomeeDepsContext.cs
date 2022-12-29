using Microsoft.EntityFrameworkCore;
using SomeeDeps.Infrastructure.Models;

namespace SomeeDeps.Infrastructure.Data;


public class SomeeDepsContext : DbContext
{
    public SomeeDepsContext(DbContextOptions<SomeeDepsContext> options)  : base(options) {}
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .HasData(new Todo[] 
                {
                    new Todo { Id = 1, Title = "Continue the capstone project on year 2023" },
                    new Todo { Id = 2, Title = "Celebrate Christmas with family.", IsDone = true },
                    new Todo { Id = 3, Title = "Create website tomorrow!" }
                });
        base.OnModelCreating(modelBuilder);
    }    
}