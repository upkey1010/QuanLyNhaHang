using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    class LoaiMonan_DAL
    {
        Model1 db = new Model1();

        public string Generate_LoaiMonanID()
        {
            return "LMA" + (db.LoaiMonan.Count() + 1).ToString();
        }

        public void AddLoaiMAtoDB(LoaiMonan cate)
        {
            cate.LoaiMonan_ID = Generate_LoaiMonanID();
            db.LoaiMonan.Add(cate);
            db.SaveChanges();
        }

        public List<LoaiMonan> getListtoShow()
        {
            var s = db.LoaiMonan.Select(p => p).ToList();
            return s;
        }

        public LoaiMonan FindIDbyName(string name)
        {
            var s = db.LoaiMonan.Single(p => p.TenLoaimonan == name);
            return s;
        }
    }
}
