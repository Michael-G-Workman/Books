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

        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Title> Titles { get; set; }
        public DbSet<Models.Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}