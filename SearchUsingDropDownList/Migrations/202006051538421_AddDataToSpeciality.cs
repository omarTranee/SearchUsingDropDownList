namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToSpeciality : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Specialities (Name) VALUES ('Dermatology (Skin)')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Psychiatry (Mental, Emotional or Behavioral Disorders)')");

            Sql("INSERT INTO Specialities (Name) VALUES ('Pediatrics and New Born (Child)')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Neurology (Brain & Nerves)')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Orthopedics (Bones)')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Gynaecology and Infertility')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Ear, Nose and Throat')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Cardiology and Vascular Disease (Heart)')");
            Sql("INSERT INTO Specialities (Name) VALUES ('Allergy and Immunology (Sensitivity and Immunity)')");
           
        }
        
        public override void Down()
        {
        }
    }
}
