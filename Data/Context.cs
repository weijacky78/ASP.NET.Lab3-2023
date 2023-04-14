using Microsoft.EntityFrameworkCore;

namespace Assignment0.Models;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {

    }
    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<SiteUser> Users { get; set; } = default!;
}