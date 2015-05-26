namespace Tourism.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Customers_Id", "dbo.Customers");
            DropForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "Customers_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "UserProfileInfo_Id" });
            DropColumn("dbo.AspNetUsers", "Customers_Id");
            DropColumn("dbo.AspNetUsers", "UserProfileInfo_Id");

        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfileInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserProfileInfo_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Customers_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "UserProfileInfo_Id");
            CreateIndex("dbo.AspNetUsers", "Customers_Id");
            AddForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes", "Id");
            AddForeignKey("dbo.AspNetUsers", "Customers_Id", "dbo.Customers", "Id");
        }
    }
}
