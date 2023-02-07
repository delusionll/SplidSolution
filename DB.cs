using System.Data.Entity;


namespace SplidSolution
{
    public class DB : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<SimplePayment>? Payments { get; set; }
    }
}
