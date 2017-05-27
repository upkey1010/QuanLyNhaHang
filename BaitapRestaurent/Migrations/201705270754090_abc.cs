namespace BaitapRestaurent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donhangs",
                c => new
                    {
                        Donhang_ID = c.String(nullable: false, maxLength: 128),
                        NV_ID = c.String(maxLength: 128),
                        Banan_ID = c.String(maxLength: 128),
                        ThoigianTaodon = c.DateTime(nullable: false),
                        Tinhtrang = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Donhang_ID)
                .ForeignKey("dbo.Banans", t => t.Banan_ID)
                .ForeignKey("dbo.Nhanviens", t => t.NV_ID)
                .Index(t => t.NV_ID)
                .Index(t => t.Banan_ID);
            
            CreateTable(
                "dbo.Banans",
                c => new
                    {
                        Banan_ID = c.String(nullable: false, maxLength: 128),
                        TenBanan = c.String(),
                        Tinhtrang = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Banan_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donhangs", "NV_ID", "dbo.Nhanviens");
            DropForeignKey("dbo.Donhangs", "Banan_ID", "dbo.Banans");
            DropIndex("dbo.Donhangs", new[] { "Banan_ID" });
            DropIndex("dbo.Donhangs", new[] { "NV_ID" });
            DropTable("dbo.Banans");
            DropTable("dbo.Donhangs");
        }
    }
}
