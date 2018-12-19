using Books.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Books.DAL
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("BooksContext")
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}