namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (1, 'White Chicks', '2004-06-23', '2021-03-09', 25, 2)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (2, 'Ford vs Ferrari', '2019-08-30', '2021-03-09', 25, 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (3, '365 Days', '2020-02-07', '2021-03-09', 25, 3)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (4, 'The Conjouring', '2013-07-19', '2021-03-09', 25, 6)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (5, 'Death Note', '2017-08-24', '2021-03-09', 25, 4)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (6, 'Mortal Kombat', '2021-04-16', '2021-03-09', 25, 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (7, 'The Pursuit of Happyness', '2006-12-16', '2021-03-09', 25, 7)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (8, 'Back To The Future', '1985-07-03', '2021-03-09', 25, 8)");
        }
        
        public override void Down()
        {
        }
    }
}
