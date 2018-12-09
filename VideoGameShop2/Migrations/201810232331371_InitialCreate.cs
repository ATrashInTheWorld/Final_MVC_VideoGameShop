namespace VideoGameShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productISBN = c.Int(nullable: false, identity: true),
                        productTitle = c.String(nullable: false, maxLength: 100),
                        productDescription = c.String(nullable: false, maxLength: 1500),
                        availableConsole1 = c.Int(nullable: false),
                        availableConsole2 = c.Int(nullable: false),
                        availableConsole3 = c.Int(nullable: false),
                        gametype1 = c.Int(nullable: false),
                        gametype2 = c.Int(nullable: false),
                        gametype3 = c.Int(nullable: false),
                        esrbRating = c.Int(nullable: false),
                        preview = c.String(),
                        releasedDate = c.DateTime(nullable: false),
                        imagePath = c.String(),
                        enteredDate = c.DateTime(nullable: false),
                        User_userID = c.Int(),
                    })
                .PrimaryKey(t => t.productISBN)
                .ForeignKey("dbo.Users", t => t.User_userID)
                .Index(t => t.User_userID);
            
            CreateTable(
                "dbo.SellerLists",
                c => new
                    {
                        sellerListID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.sellerListID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        sellerID = c.Int(nullable: false, identity: true),
                        sellerName = c.String(nullable: false, maxLength: 100),
                        sellerHomePage = c.String(nullable: false),
                        sellerSearchURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.sellerID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        userFirstName = c.String(maxLength: 50),
                        userLastName = c.String(maxLength: 50),
                        dateOfBirth = c.DateTime(nullable: false),
                        username = c.String(nullable: false, maxLength: 20),
                        password = c.String(nullable: false, maxLength: 20),
                        rePassword = c.String(nullable: false, maxLength: 20),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "User_userID", "dbo.Users");
            DropIndex("dbo.Products", new[] { "User_userID" });
            DropTable("dbo.Users");
            DropTable("dbo.Sellers");
            DropTable("dbo.SellerLists");
            DropTable("dbo.Products");
        }
    }
}
