using Microsoft.EntityFrameworkCore;
using LibraryWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LibraryWebApplication.Data
{
    public class LibraryContext : IdentityDbContext<IdentityUser>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public LibraryContext(DbContextOptions<LibraryContext> dbContextOptions) : base(dbContextOptions)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
