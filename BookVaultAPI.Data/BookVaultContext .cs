using BookVaultAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data
{
    public class BookVaultContext : DbContext
    {
        public BookVaultContext(DbContextOptions<BookVaultContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Share> Shares { get; set; }
    }
}
