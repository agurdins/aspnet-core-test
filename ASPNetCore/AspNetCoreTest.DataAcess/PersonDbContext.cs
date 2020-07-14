using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.DataAcess
{
    public class PersonDbContext : DbContext    // = DB
    {
        public DbSet<Person> People { get; set; }   // = DB Table
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
