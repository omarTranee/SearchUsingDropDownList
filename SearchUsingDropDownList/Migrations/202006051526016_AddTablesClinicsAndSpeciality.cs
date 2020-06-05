namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesClinicsAndSpeciality : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Speciality_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Specialities", t => t.Speciality_Id)
                .Index(t => t.Speciality_Id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "Speciality_Id", "dbo.Specialities");
            DropIndex("dbo.Clinics", new[] { "Speciality_Id" });
            DropTable("dbo.Specialities");
            DropTable("dbo.Clinics");
        }
    }
}
