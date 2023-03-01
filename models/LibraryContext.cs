using Microsoft.EntityFrameworkCore;
using prrr.models;

namespace prrr.models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
             : base(options)
        {
        }

        public DbSet<Author> authors { get; set; } = null!;
        public DbSet<Publisher> publishers { get; set; } = null!;
        public DbSet<Book> books { get; set; } = null!;
        public DbSet<BookStatus> bookStatuses { get; set; } = null!;
        public DbSet<Staff> staff { get; set; } = null!;
        public DbSet<prrr.models.User> User { get; set; }
    }
}

