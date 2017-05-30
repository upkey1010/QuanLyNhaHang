using BaitapRestaurent.GUI;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    class ChitietDonhang_DAL
    {
        Model1 db = new Model1();

        public List<Chitiet_donhang> getListDH_unpaid(string Banan_ID)
        {
            var s = db.Chitiet_donhang.Where(p => p.Donhang.Tinhtrang == false && p.Donhang.Banan_ID == Banan_ID).ToList();
            return s;
        }

        public void AddChitietDonhangtoDB(Chitiet_donhang chitiet)
        {
            db.Chitiet_donhang.Add(chitiet);
            db.SaveChanges();
        }

        public void updateSoluong(Chitiet_donhang p)
        {
            var s = db.Chitiet_donhang.Single(a => a.Donhang_ID == p.Donhang_ID && a.Monan_ID==p.Monan_ID);
            s.Soluong += p.Soluong;
            db.SaveChanges();
        }

        public int checkMonanDachon(string IDDonhang, string IDMonan)
        {
            return db.Chitiet_donhang.Where(p => p.Donhang_ID == IDDonhang && p.Monan_ID == IDMonan).Count();
        }
       
    }
}
