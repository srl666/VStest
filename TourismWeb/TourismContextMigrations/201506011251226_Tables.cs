namespace TourismWeb.TourismContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Process",
                c => new
                    {
                        ProcessID = c.Int(nullable: false, identity: true),
                        ProcessName = c.String(),
                        Customer_ID = c.Int(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.ProcessID)
                .ForeignKey("dbo.Customer", t => t.Customer_ID)
                .ForeignKey("dbo.Order", t => t.Order_OrderID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Order_OrderID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Process", "Order_OrderID", "dbo.Order");
            DropForeignKey("dbo.Process", "Customer_ID", "dbo.Customer");
            DropIndex("dbo.Process", new[] { "Order_OrderID" });
            DropIndex("dbo.Process", new[] { "Customer_ID" });
            DropTable("dbo.Order");
            DropTable("dbo.Process");
        }
    }
}
