namespace BaitapRestaurent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_KhoaphuMonan : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Monans", new[] { "LoaiMonan_LoaiMonan_ID" });
            DropColumn("dbo.Monans", "LoaiMonan");
            RenameColumn(table: "dbo.Monans", name: "LoaiMonan_LoaiMonan_ID", newName: "LoaiMonan");
            AlterColumn("dbo.Monans", "LoaiMonan", c => c.String(maxLength: 128));
            CreateIndex("dbo.Monans", "LoaiMonan");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Monans", new[] { "LoaiMonan" });
            AlterColumn("dbo.Monans", "LoaiMonan", c => c.String());
            RenameColumn(table: "dbo.Monans", name: "LoaiMonan", newName: "LoaiMonan_LoaiMonan_ID");
            AddColumn("dbo.Monans", "LoaiMonan", c => c.String());
            CreateIndex("dbo.Monans", "LoaiMonan_LoaiMonan_ID");
        }
    }
}
