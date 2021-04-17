namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Non-Member', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 15, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly', 40, 3, 20)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Yearly', 100, 12, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
