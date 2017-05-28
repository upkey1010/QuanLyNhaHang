namespace BaitapRestaurent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_KhoaphuMonan2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Monans", name: "LoaiMonan", newName: "LoaiMonan_ID");
            RenameIndex(table: "dbo.Monans", name: "IX_LoaiMonan", newName: "IX_LoaiMonan_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Monans", name: "IX_LoaiMonan_ID", newName: "IX_LoaiMonan");
            RenameColumn(table: "dbo.Monans", name: "LoaiMonan_ID", newName: "LoaiMonan");
        }
    }
}
