namespace SplidSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Amount = c.Double(nullable: false),
                        FromUser_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ExpenseID)
                .ForeignKey("dbo.Users", t => t.FromUser_UserID)
                .Index(t => t.FromUser_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "FromUser_UserID", "dbo.Users");
            DropIndex("dbo.Payments", new[] { "FromUser_UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Payments");
        }
    }
}
