namespace TourismWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Processes", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropIndex("dbo.Processes", new[] { "Order_OrderID" });
            RenameColumn(table: "dbo.Orders", name: "Customer_ID", newName: "CustomerID");
            RenameColumn(table: "dbo.Processes", name: "Order_OrderID", newName: "OrderID");
            AlterColumn("dbo.Orders", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Processes", "OrderID", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "CustomerID");
            CreateIndex("dbo.Processes", "OrderID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Processes", "OrderID", "dbo.Orders", "OrderID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processes", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Processes", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            AlterColumn("dbo.Processes", "OrderID", c => c.Int());
            AlterColumn("dbo.Orders", "CustomerID", c => c.Int());
            RenameColumn(table: "dbo.Processes", name: "OrderID", newName: "Order_OrderID");
            RenameColumn(table: "dbo.Orders", name: "CustomerID", newName: "Customer_ID");
            CreateIndex("dbo.Processes", "Order_OrderID");
            CreateIndex("dbo.Orders", "Customer_ID");
            AddForeignKey("dbo.Processes", "Order_OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers", "ID");
        }
    }
}
