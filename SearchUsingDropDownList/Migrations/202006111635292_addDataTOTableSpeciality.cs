namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataTOTableSpeciality : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                 INSERT INTO Specialities (Name) VALUES (' Gastroenterology and Endoscopy')   
                 INSERT INTO Specialities (Name) VALUES ('General Practice')   
                 INSERT INTO Specialities (Name) VALUES ('General Surgery')   
                 INSERT INTO Specialities (Name) VALUES ('Geriatrics (Old People Health)')   
                 INSERT INTO Specialities (Name) VALUES ('Hepatology (Liver Doctor)')   
                 INSERT INTO Specialities (Name) VALUES ('Hematologys')   
                 INSERT INTO Specialities (Name) VALUES ('Hepatology (Liver Doctor)')   
                 INSERT INTO Specialities (Name) VALUES ('Internal Medicine')   
                 INSERT INTO Specialities (Name) VALUES ('IVF and Infertility')   
                 INSERT INTO Specialities (Name) VALUES ('Laboratories')   
                 INSERT INTO Specialities (Name) VALUES ('Nephrology')   
                 INSERT INTO Specialities (Name) VALUES ('Andrology and Male Infertility')   
                 INSERT INTO Specialities (Name) VALUES ('Audiology')   
                 INSERT INTO Specialities (Name) VALUES ('Cardiology and Thoracic Surgery (Heart & Chest)')   
                 INSERT INTO Specialities (Name) VALUES ('Chest and Respiratory')   
                 INSERT INTO Specialities (Name) VALUES ('Diabetes and Endocrinology')   
                 INSERT INTO Specialities (Name) VALUES ('Diagnostic Radiology (Scan Centers)')   
                ");
        }
        
        public override void Down()
        {
        }
    }
}
