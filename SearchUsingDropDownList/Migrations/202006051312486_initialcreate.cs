namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityNameAR = c.String(),
                        CityNameEn = c.String(),
                        GovernorateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Governorates", t => t.GovernorateID, cascadeDelete: true)
                .Index(t => t.GovernorateID);
            
            CreateTable(
                "dbo.Governorates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GovNameAR = c.String(),
                        GovNameEN = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "GovernorateID", "dbo.Governorates");
            DropIndex("dbo.Cities", new[] { "GovernorateID" });
            DropTable("dbo.Governorates");
            DropTable("dbo.Cities");
        }
    }
}
