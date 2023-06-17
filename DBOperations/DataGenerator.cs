/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BookStore.DBOperations;

public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context =
            new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>());
        if (context.Books.Any())
        {
            return;
        }
        context.Books.AddRange(
            new Book
            {
                Id = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                GenreId = 1,
                PageCount = 224,
                PublishDate = new DateTime(1979, 10, 12)
            },
            new Book
            {
                Id = 2,
                Title = "Herland",
                GenreId = 2,
                PageCount = 250,
                PublishDate = new DateTime(2010, 5, 23)
            },
            new Book
            {
                Id = 3,
                Title = "Dune",
                GenreId = 2,
                PageCount = 540,
                PublishDate = new DateTime(2001, 10, 12)
            }
        );
        context.SaveChanges();
    }
}*/