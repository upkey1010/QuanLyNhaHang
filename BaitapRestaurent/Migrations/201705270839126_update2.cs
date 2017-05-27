namespace BaitapRestaurent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chitiet_donhang",
                c => new
                    {
                        Donhang_ID = c.String(nullable: false, maxLength: 128),
                        Monan_ID = c.String(nullable: false, maxLength: 128),
                        Soluong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Donhang_ID, t.Monan_ID })
                .ForeignKey("dbo.Donhangs", t => t.Donhang_ID, cascadeDelete: true)
                .ForeignKey("dbo.Monans", t => t.Monan_ID, cascadeDelete: true)
                .Index(t => t.Donhang_ID)
                .Index(t => t.Monan_ID);
            
            CreateTable(
                "dbo.Monans",
                c => new
                    {
                        Monan_ID = c.String(nullable: false, maxLength: 128),
                        TenMonan = c.String(),
                        Giatien = c.Int(nullable: false),
                        LoaiMonan = c.String(),
                        LoaiMonan_LoaiMonan_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Monan_ID)
                .ForeignKey("dbo.LoaiMonans", t => t.LoaiMonan_LoaiMonan_ID)
                .Index(t => t.LoaiMonan_LoaiMonan_ID);
            
            CreateTable(
                "dbo.LoaiMonans",
                c => new
                    {
                        LoaiMonan_ID = c.String(nullable: false, maxLength: 128),
                        TenLoaimonan = c.String(),
                    })
                .PrimaryKey(t => t.LoaiMonan_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monans", "LoaiMonan_LoaiMonan_ID", "dbo.LoaiMonans");
            DropForeignKey("dbo.Chitiet_donhang", "Monan_ID", "dbo.Monans");
            DropForeignKey("dbo.Chitiet_donhang", "Donhang_ID", "dbo.Donhangs");
            DropIndex("dbo.Monans", new[] { "LoaiMonan_LoaiMonan_ID" });
            DropIndex("dbo.Chitiet_donhang", new[] { "Monan_ID" });
            DropIndex("dbo.Chitiet_donhang", new[] { "Donhang_ID" });
            DropTable("dbo.LoaiMonans");
            DropTable("dbo.Monans");
            DropTable("dbo.Chitiet_donhang");
        }
    }
}
