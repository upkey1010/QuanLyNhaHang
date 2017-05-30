using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class Donhang_BLL
    {
        Donhang_DAL dal = new Donhang_DAL();

        public void AddDHtoDB(Donhang dh)
        {
            dal.AddDHtoDB(dh);
        }
        public Donhang FindUnpaidID(string BananID)
        {
            return dal.FindUnpaidID(BananID);
        }

        public void DoitrangthaiDH(Donhang dh)
        {
            dal.DoitrangthaiDH(dh);
        }
        public void DelDH(Donhang dh)
        {
            dal.DelDH(dh);
        }


    }
}
