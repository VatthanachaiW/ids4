using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Connections
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}