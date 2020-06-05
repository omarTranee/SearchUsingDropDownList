namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClinicData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr yahia',1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr shory' ,1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Edrees' ,1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Ahmed' ,1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Tebo',1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Abdo',1,2)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Mohamed',1,3)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,3)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,3)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,3)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,3)");
            Sql(@"INSERT INTO Clinics (Name,Speciality_Id,CityId) VALUES ('Dr Omar',1,3)");
        }
        
        public override void Down()
        {
        }
    }
}
