using Microsoft.EntityFrameworkCore;
using ProductProvider.Data.Entities;

namespace ProductProvider.Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseEntity>()
            .ToContainer("Courses")
            .HasPartitionKey(x => x.PartitionKey);
    }
}
