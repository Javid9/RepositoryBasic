using ClassLibrary1.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category>? Categories { get; set; }
}
