namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelateClinicWithCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clinics", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clinics", "CityId");
            AddForeignKey("dbo.Clinics", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "CityId", "dbo.Cities");
            DropIndex("dbo.Clinics", new[] { "CityId" });
            DropColumn("dbo.Clinics", "CityId");
        }
    }
}
