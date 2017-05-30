using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    class Nhanvien_DAL
    {
        Model1 db = new Model1();

        public string Generate_NVID()
        {
            return "NV" + (db.Nhanvien.Count()+1).ToString();
        }
        public void AddNVtoDB(Nhanvien nv)
        {
            nv.NV_ID = Generate_NVID();
            db.Nhanvien.Add(nv);
            db.SaveChanges();
        }
        public List<Nhanvien> getListNVtoShow()
        {
            var s = db.Nhanvien.Select(p => p).ToList();
            return s;
        }

        public int checkTenDangnhap(string tendangnhap)
        {
            return db.Nhanvien.Where(p => p.TenDangNhap == tendangnhap).Count();
        }

        public int checkNhanvienLogin(string user, string password)
        {
            return db.Nhanvien.Where(p => p.TenDangNhap == user && p.Matkhau == password).Count();
        }

        public Nhanvien FindIDbyUser(string name)
        {
            var s = db.Nhanvien.Single(p => p.TenDangNhap == name);
            return s;
        }
    }
}
