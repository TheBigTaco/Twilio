using System;
using Microsoft.EntityFrameworkCore;

namespace Texter.Models
{
    public class TexterDbContext: DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public TexterDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=texter;uid=root;pwd=root;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
