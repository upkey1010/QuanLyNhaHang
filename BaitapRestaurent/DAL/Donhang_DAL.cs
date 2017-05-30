using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    class Donhang_DAL
    {
        Model1 db = new Model1();

        public string Generate_DHID()
        {
            return "DH" + (db.Donhang.Count() + 1).ToString();
        }

        public void AddDHtoDB(Donhang dh)
        {
            dh.Donhang_ID = Generate_DHID();
            db.Donhang.Add(dh);
            db.SaveChanges();
        }
        public Donhang FindUnpaidID(string BananID)
        {
            var s = db.Donhang.Single(p => p.Tinhtrang == false && p.Banan_ID == BananID);
            return s;
        }

        public void DoitrangthaiDH(Donhang dh)
        {
            var s = db.Donhang.Single(p => p.Tinhtrang == false && p.Banan_ID == dh.Banan_ID);
            s.Tinhtrang = true;
            db.SaveChanges();
        }
        public void DelDH(Donhang dh)
        {
            var s = db.Donhang.Single(p => p.Tinhtrang == false && p.Banan_ID == dh.Banan_ID);
            db.Donhang.Remove(dh);
            db.SaveChanges();
        }
    }
}
