namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.tbl_ev",
                c => new
                    {
                        evID = c.Int(nullable: false, identity: true),
                        il = c.String(maxLength: 50),
                        ilce = c.String(maxLength: 50),
                        ilanTarih = c.DateTime(),
                        brütm2 = c.String(maxLength: 50),
                        netm2 = c.String(maxLength: 50),
                        odasayisi = c.String(maxLength: 50),
                        binayas = c.String(maxLength: 50),
                        bulundugukat = c.String(maxLength: 50),
                        binadakitoplamkat = c.String(maxLength: 50),
                        isitma = c.String(maxLength: 50),
                        banyosayisi = c.Int(),
                        Aidat = c.Int(),
                        balkondurum = c.Boolean(),
                        esyadurum = c.Boolean(),
                        siteicidurum = c.Boolean(),
                        krediyeuygunlukdurum = c.Boolean(),
                        tapucesidi = c.Boolean(),
                        takasdurum = c.String(maxLength: 50),
                        satilikdurum = c.Boolean(),
                    })
                .PrimaryKey(t => t.evID);
            
            CreateTable(
                "dbo.tbl_evfoto",
                c => new
                    {
                        evFotoID = c.Int(nullable: false, identity: true),
                        evID = c.Int(),
                        url = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.evFotoID)
                .ForeignKey("dbo.tbl_ev", t => t.evID)
                .Index(t => t.evID);
            
            CreateTable(
                "dbo.tbl_evtip",
                c => new
                    {
                        evTipID = c.Int(nullable: false, identity: true),
                        evID = c.Int(),
                        TipAdi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.evTipID)
                .ForeignKey("dbo.tbl_ev", t => t.evID)
                .Index(t => t.evID);
            
            CreateTable(
                "dbo.tbl_ilan",
                c => new
                    {
                        ilanID = c.Int(nullable: false, identity: true),
                        musteriID = c.Int(),
                        evID = c.Int(),
                        Baslik = c.String(),
                    })
                .PrimaryKey(t => t.ilanID)
                .ForeignKey("dbo.tbl_ev", t => t.evID)
                .ForeignKey("dbo.tbl_musteri", t => t.musteriID)
                .Index(t => t.musteriID)
                .Index(t => t.evID);
            
            CreateTable(
                "dbo.tbl_musteri",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(maxLength: 50),
                        MusteriSoyad = c.String(maxLength: 50),
                        MusteriTel = c.String(maxLength: 50),
                        MusteriTC = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_ilan", "musteriID", "dbo.tbl_musteri");
            DropForeignKey("dbo.tbl_ilan", "evID", "dbo.tbl_ev");
            DropForeignKey("dbo.tbl_evtip", "evID", "dbo.tbl_ev");
            DropForeignKey("dbo.tbl_evfoto", "evID", "dbo.tbl_ev");
            DropIndex("dbo.tbl_ilan", new[] { "evID" });
            DropIndex("dbo.tbl_ilan", new[] { "musteriID" });
            DropIndex("dbo.tbl_evtip", new[] { "evID" });
            DropIndex("dbo.tbl_evfoto", new[] { "evID" });
            DropTable("dbo.tbl_musteri");
            DropTable("dbo.tbl_ilan");
            DropTable("dbo.tbl_evtip");
            DropTable("dbo.tbl_evfoto");
            DropTable("dbo.tbl_ev");
            DropTable("dbo.sysdiagrams");
        }
    }
}
