namespace SplidSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSimplePaymentID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "FromUser_UserID", "dbo.Users");
            DropIndex("dbo.Payments", new[] { "FromUser_UserID" });
            CreateTable(
                "dbo.SimplePayments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            DropTable("dbo.Payments");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ExpenseID);
            
            DropTable("dbo.SimplePayments");
            CreateIndex("dbo.Payments", "FromUser_UserID");
            AddForeignKey("dbo.Payments", "FromUser_UserID", "dbo.Users", "UserID");
        }
    }
}
