namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEtkinlikTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Etkinliks",
                c => new
                    {
                        EtkinlikId = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false),
                        Aciklama = c.String(),
                        Lokasyon = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        FotoUrl = c.String(),
                        BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.EtkinlikId)
                .ForeignKey("dbo.Blogs", t => t.BlogId)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etkinliks", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Etkinliks", new[] { "BlogId" });
            DropTable("dbo.Etkinliks");
        }
    }
}
