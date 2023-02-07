namespace SplidSolution.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SplidSolution.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SplidSolution.DB";
        }

        protected override void Seed(SplidSolution.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
