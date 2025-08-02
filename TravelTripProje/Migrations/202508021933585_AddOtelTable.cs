namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOtelTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        OtelId = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        FotoUrl = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OtelId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Otels", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Otels", new[] { "BlogId" });
            DropTable("dbo.Otels");
        }
    }
}
