namespace BaitapRestaurent
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BaitapRestaurent.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("Model1")
        {
            Database.SetInitializer<Model1>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Banan> Banan { get; set; }
        public virtual DbSet<Donhang> Donhang { get; set; }
        public virtual DbSet<Monan> Monan { get; set; }
        public virtual DbSet<Chitiet_donhang> Chitiet_donhang { get; set; }
        public virtual DbSet<LoaiMonan> LoaiMonan { get; set; }


        public class CreateDB : CreateDatabaseIfNotExists<Model1>
        {
            protected override void Seed(Model1 d)
            {
                d.Nhanvien.Add(new Nhanvien { NV_ID = "NV1", TenNV ="Heo", Ngaysinh = DateTime.Now, Gioitinh=true, Capbac="Truong cua hang", TenDangNhap="upkey1010", Matkhau="o0o0o0" });
                d.SaveChanges();
            }
        }

        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}