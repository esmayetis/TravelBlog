namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBaslikToHakkimizda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hakkimizdas", "Baslik", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hakkimizdas", "Baslik");
        }
    }
}
