using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class ChitietDonhang_BLL
    {
        ChitietDonhang_DAL dal = new ChitietDonhang_DAL();
        public List<Chitiet_donhang> getListDH_unpaid(string Banan_ID)
        {
            return dal.getListDH_unpaid(Banan_ID);
        }

        public void AddChitietDonhangtoDB(Chitiet_donhang chitiet)
        {
            dal.AddChitietDonhangtoDB(chitiet);
        }
        public int checkMonanDachon(string IDDonhang, string IDMonan)
        {
            return dal.checkMonanDachon(IDDonhang, IDMonan);
        }
        public void updateSoluong(Chitiet_donhang p)
        {
            dal.updateSoluong(p);
        }


    }
}
