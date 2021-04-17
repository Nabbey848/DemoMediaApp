namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES (1, 'John Smith', 0, 1)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES (2, 'Reuben Espinoza', 1, 2)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES (3, 'Harold Jones', 0, 3)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES (4, 'Kurosaki Ichigo', 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
