namespace TourismWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        ProcessID = c.Int(nullable: false),
                        ProcessName = c.String(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.ProcessID)
                .ForeignKey("dbo.Customers", t => t.ProcessID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.ProcessID)
                .Index(t => t.Order_OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processes", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Processes", "ProcessID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Processes", new[] { "Order_OrderID" });
            DropIndex("dbo.Processes", new[] { "ProcessID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropTable("dbo.Processes");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
