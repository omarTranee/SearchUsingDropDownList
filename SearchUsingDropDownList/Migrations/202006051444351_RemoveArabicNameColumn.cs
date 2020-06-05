namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveArabicNameColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cities", "CityNameAR");
            DropColumn("dbo.Governorates", "GovNameAR");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Governorates", "GovNameAR", c => c.String());
            AddColumn("dbo.Cities", "CityNameAR", c => c.String());
        }
    }
}
