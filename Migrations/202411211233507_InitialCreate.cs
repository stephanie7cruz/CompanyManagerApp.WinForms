namespace CompanyManagerApp.WinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        Department = c.String(),
                        Country = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
