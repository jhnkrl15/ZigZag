// AppDbContext.cs
using BookApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
