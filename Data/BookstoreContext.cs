using System;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Data;

namespace Fisher.Bookstore.Api.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
            // delete consumer code that seeded our data
        }

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}