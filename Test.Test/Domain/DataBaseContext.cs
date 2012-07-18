using System.Data.Entity;

namespace Test.Test.Domain
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}