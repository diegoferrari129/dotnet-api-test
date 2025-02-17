using Microsoft.EntityFrameworkCore;

namespace dotnet_api_test;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
