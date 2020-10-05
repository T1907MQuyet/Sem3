namespace Poject_Photo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _09212020_newMG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 30),
                        Email = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Avatar = c.String(),
                        Password = c.String(maxLength: 20),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ListImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ImageLink = c.String(),
                        Created = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Order_ID = c.Int(nullable: false),
                        ListImageID = c.Int(nullable: false),
                        ServiceSizeID = c.Int(nullable: false),
                        SSizePrice = c.Single(nullable: false),
                        ServiceMaterialID = c.Int(nullable: false),
                        SMaterialPrice = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ListImages", t => t.ListImageID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .ForeignKey("dbo.ServiceMaterials", t => t.ServiceMaterialID, cascadeDelete: true)
                .ForeignKey("dbo.ServiceSizes", t => t.ServiceSizeID, cascadeDelete: true)
                .Index(t => t.Order_ID)
                .Index(t => t.ListImageID)
                .Index(t => t.ServiceSizeID)
                .Index(t => t.ServiceMaterialID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        PhoneOrder = c.String(),
                        Address = c.String(),
                        Created = c.DateTime(nullable: false),
                        StatusOrder = c.Int(nullable: false),
                        CityName = c.String(),
                        Note = c.String(maxLength: 300),
                        TotalPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ServiceSizeID", "dbo.ServiceSizes");
            DropForeignKey("dbo.OrderDetails", "ServiceMaterialID", "dbo.ServiceMaterials");
            DropForeignKey("dbo.OrderDetails", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "ListImageID", "dbo.ListImages");
            DropForeignKey("dbo.ListImages", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ServiceMaterialID" });
            DropIndex("dbo.OrderDetails", new[] { "ServiceSizeID" });
            DropIndex("dbo.OrderDetails", new[] { "ListImageID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.ListImages", new[] { "CustomerID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.ListImages");
            DropTable("dbo.Customers");
        }
    }
}
