namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolumnfromGovernote : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Governorates", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Governorates", "CityId", c => c.Int(nullable: false));
        }
    }
}
