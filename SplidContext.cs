using System.Data.Entity;

namespace SplidSolution
{
    public class SplidContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SimplePayment>? Payments { get; set; }
    }
}
