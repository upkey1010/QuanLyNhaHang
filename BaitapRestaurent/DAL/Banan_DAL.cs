using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    class Banan_DAL
    {
        Model1 db = new Model1();
        public string Generate_BananID()
        {
            return "BA" + (db.Banan.Count() + 1).ToString();
        }

        public string Generate_TenBanan()
        {
            return "Ban an so " + (db.Banan.Count() + 1).ToString();
        }

        public void AddBAtoDB()
        {
            Banan banan=new Banan();
            banan.Banan_ID = Generate_BananID();
            banan.TenBanan = Generate_TenBanan();
            banan.Tinhtrang = false;
            db.Banan.Add(banan);
            db.SaveChanges();
        }

        public List<Banan> getListBAtoShow()
        {
            var s = db.Banan.Select(p => p).ToList();
            return s;
        }

        public Banan FindIDbyName(string name)
        {
            var s = db.Banan.Single(p => p.TenBanan == name);
            return s;
        }

        public void updateBA(Banan banan)
        {
            var s = db.Banan.Single(p => p.Banan_ID == banan.Banan_ID);
            s.TenBanan = banan.TenBanan;
            s.Tinhtrang = banan.Tinhtrang;
            db.SaveChanges();
        }
        public void DelBanan(Banan banan)
        {
            var s = db.Banan.Single(p => p.Banan_ID == banan.Banan_ID);
            db.Banan.Remove(s);
            db.SaveChanges();
        }

        public void DoiTinhtrangBanan(Banan banan)
        {
            var s = db.Banan.Single(p => p.Banan_ID == banan.Banan_ID);
            s.Tinhtrang = false;
            db.SaveChanges();
        }

    }
}
