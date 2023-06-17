using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace BookStore.DBOperations;

public class BookStoreDbContext: DbContext
{
    protected readonly IConfiguration Configuration;

    public BookStoreDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<Book> Books { get; set; }
}