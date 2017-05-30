using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.DAL
{
    
    class Monan_DAL
    {
        Model1 db = new Model1();
        public string Generate_MonanID()
        {
            return "MA" + (db.Monan.Count() + 1).ToString();
        }

        public void AddMAtoDB(Monan monan)
        {
            monan.Monan_ID = Generate_MonanID();
            db.Monan.Add(monan);
            db.SaveChanges();
        }
        public List<Monan> getList()
        {
            var s = db.Monan.Select(p => p).ToList();
            return s;
        }
    }
}
