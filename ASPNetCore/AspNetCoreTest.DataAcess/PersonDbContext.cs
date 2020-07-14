using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.Data
{
    public class PersonDbContext : DbContext    // = DB
    {
        public DbSet<Person> People { get; set; }   // = DB Table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
