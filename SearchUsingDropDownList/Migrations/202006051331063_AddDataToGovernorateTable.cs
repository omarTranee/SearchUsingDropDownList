namespace SearchUsingDropDownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToGovernorateTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Governorates(GovNameEN) VALUES  ('Cairo')");
            Sql("INSERT INTO Governorates(GovNameEN) VALUES  ('Giza')");
            Sql("INSERT INTO Governorates(GovNameEN) VALUES  ('Alexandria')");
            Sql("INSERT INTO Governorates(GovNameEN) VALUES  ('Dakahlia')");

            Sql(@"
                INSERT INTO Governorates(GovNameEN) VALUES ('Red Sea')
                INSERT INTO Governorates(GovNameEN) VALUES ('Beheira')
                INSERT INTO Governorates(GovNameEN) VALUES ('Fayoum')
                INSERT INTO Governorates(GovNameEN) VALUES ('Gharbiya')
                INSERT INTO Governorates(GovNameEN) VALUES ('Ismailia')
                INSERT INTO Governorates(GovNameEN) VALUES ('Monofia')
                INSERT INTO Governorates(GovNameEN) VALUES ('Minya')
                INSERT INTO Governorates(GovNameEN) VALUES ('Qaliubiya')
                INSERT INTO Governorates(GovNameEN) VALUES ('New Valley')
                INSERT INTO Governorates(GovNameEN) VALUES ('Suez')
                INSERT INTO Governorates(GovNameEN) VALUES ('Aswan')
                INSERT INTO Governorates(GovNameEN) VALUES ('Assiut')
                INSERT INTO Governorates(GovNameEN) VALUES ('Beni Suef')
                INSERT INTO Governorates(GovNameEN) VALUES ('Port Said')
                INSERT INTO Governorates(GovNameEN) VALUES ('Damietta')
                INSERT INTO Governorates(GovNameEN) VALUES ('Sharkia')
                INSERT INTO Governorates(GovNameEN) VALUES ('South Sinai')
                INSERT INTO Governorates(GovNameEN) VALUES ('Kafr Al sheikh')
                INSERT INTO Governorates(GovNameEN) VALUES ('Matrouh')
                INSERT INTO Governorates(GovNameEN) VALUES ('Luxor')
                INSERT INTO Governorates(GovNameEN) VALUES ('Qena')
                INSERT INTO Governorates(GovNameEN) VALUES ('North Sinai')
                INSERT INTO Governorates(GovNameEN) VALUES ('Sohag')
               ");

        }

        public override void Down()
        {
        }
    }
}
