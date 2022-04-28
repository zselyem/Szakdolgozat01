namespace Szakdolgozat01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tesztadatokfeltoltese : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Foglalasok VALUES('Kiss','Dóri', 'kiss.dori@gmail.com','06-20/432-6452','2022-04-27 11:00:00','4')");
            Sql("INSERT INTO Foglalasok VALUES('Nagy','Ferenc', 'nagy.ferenc@gmail.com','06-20/422-6431','2022-04-27 13:00:00','4')");
            Sql("INSERT INTO Foglalasok VALUES('Kovács','Kálmán', 'kovacs.kalman@gmail.com','06-30/541-2471','2022-04-27 15:00:00','2')");
            Sql("INSERT INTO Foglalasok VALUES('Tóth','Emese', 'toth.emese@gmail.com','06-30/764-0101','2022-04-27 11:00:00','2')");
            Sql("INSERT INTO Foglalasok VALUES('Szabó','Balázs', 'szabo.balazs@gmail.com','06-70/001-6762','2022-04-27 11:00:00','2')");
            Sql("INSERT INTO Foglalasok VALUES('Kerekes','Vica', 'kerekes.vica@gmail.com','06-70/542-1132','2022-04-27 15:00:00','4')");
            Sql("INSERT INTO Foglalasok VALUES('Papp','Antal', 'papp.antal@gmail.com','06-20/232-8997','2022-04-27 15:00:00','3')");
            Sql("INSERT INTO Foglalasok VALUES('Rapport','Richárd', 'rapport.richard@gmail.com','06-30/654-6111','2022-04-27 13:00:00','4')");
            Sql("INSERT INTO Foglalasok VALUES('Istenes','Bence', 'istenes.bence@gmail.com','06-70/122-3352','2022-04-27 13:00:00','2')");
            Sql("INSERT INTO Foglalasok VALUES('Lévai','Anikó', 'levai.aniko@gmail.com','06-30/876-6452','2022-04-27 17:00:00','3')");
            Sql("INSERT INTO Foglalasok VALUES('Török','Basa', 'torok.basa@gmail.com','06-30/764-6452','2022-04-27 17:00:00','6')");
            Sql("INSERT INTO Foglalasok VALUES('Eszes','Elemér', 'eszes.elemer@gmail.com','06-20/652-6452','2022-04-27 17:00:00','4')");
            Sql("INSERT INTO Foglalasok VALUES('Sas','Tamás', 'sas.tamas@gmail.com','06-70/123-7652','2022-04-27 17:00:00','2')");
            Sql("INSERT INTO Foglalasok VALUES('Szekeres','Eszter', 'szekeres.eszter@gmail.com','06-70/772-6552','2022-04-27 19:00:00','5')");
            Sql("INSERT INTO Foglalasok VALUES('Vass','Aladár', 'vass.aladar@gmail.com','06-20/434-6762','2022-04-27 19:00:00','4')");
        }
        
        public override void Down()
        {
        }
    }
}
