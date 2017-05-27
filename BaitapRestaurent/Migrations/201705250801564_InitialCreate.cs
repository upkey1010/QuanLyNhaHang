namespace BaitapRestaurent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        NV_ID = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        TenDangNhap = c.String(),
                        Matkhau = c.String(),
                        Ngaysinh = c.DateTime(nullable: false),
                        Gioitinh = c.Boolean(nullable: false),
                        Capbac = c.String(),
                    })
                .PrimaryKey(t => t.NV_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhanviens");
        }
    }
}
