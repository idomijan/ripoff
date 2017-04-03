namespace Ripoff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) Values (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) Values (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) Values (4, 'Reggae')");
            Sql("INSERT INTO Genres (Id, Name) Values (5, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) Values (6, 'Folk')");
            Sql("INSERT INTO Genres (Id, Name) Values (7, 'Electronic')");


        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4,5,6,7)");
        }
    }
}
