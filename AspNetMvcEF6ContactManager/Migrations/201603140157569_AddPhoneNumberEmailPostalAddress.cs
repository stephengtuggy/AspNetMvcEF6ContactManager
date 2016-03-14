namespace AspNetMvcEF6ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumberEmailPostalAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        EmailAddress = c.String(),
                        Contact_ContactId = c.Int(),
                    })
                .PrimaryKey(t => t.EmailId)
                .ForeignKey("dbo.Contacts", t => t.Contact_ContactId)
                .Index(t => t.Contact_ContactId);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Number = c.String(),
                        Contact_ContactId = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneNumberId)
                .ForeignKey("dbo.Contacts", t => t.Contact_ContactId)
                .Index(t => t.Contact_ContactId);
            
            CreateTable(
                "dbo.PostalAddresses",
                c => new
                    {
                        PostalAddressId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        City = c.String(),
                        StateOrProvince = c.String(),
                        ZipOrPostalCode = c.String(),
                        Country = c.String(),
                        Contact_ContactId = c.Int(),
                    })
                .PrimaryKey(t => t.PostalAddressId)
                .ForeignKey("dbo.Contacts", t => t.Contact_ContactId)
                .Index(t => t.Contact_ContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostalAddresses", "Contact_ContactId", "dbo.Contacts");
            DropForeignKey("dbo.PhoneNumbers", "Contact_ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Emails", "Contact_ContactId", "dbo.Contacts");
            DropIndex("dbo.PostalAddresses", new[] { "Contact_ContactId" });
            DropIndex("dbo.PhoneNumbers", new[] { "Contact_ContactId" });
            DropIndex("dbo.Emails", new[] { "Contact_ContactId" });
            DropTable("dbo.PostalAddresses");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Emails");
        }
    }
}
