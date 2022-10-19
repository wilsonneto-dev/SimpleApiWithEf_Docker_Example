using Microsoft.EntityFrameworkCore;

namespace SimpleApiWithEfInDocker;

public class AppContextDb : DbContext
{
    protected override void OnConfiguring
   (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "ApplicationDb");
    }
    public DbSet<Product> Products { get; set; }
}
