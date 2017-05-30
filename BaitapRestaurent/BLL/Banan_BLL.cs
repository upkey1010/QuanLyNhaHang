using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class Banan_BLL
    {
        Banan_DAL dal = new Banan_DAL();
        public void AddBAtoDB()
        {
            dal.AddBAtoDB();
        }
        public List<Banan> getListBAtoShow()
        {
            return dal.getListBAtoShow();
        }
        public Banan FindIDbyName(string name)
        {
            return dal.FindIDbyName(name);
        }
        public void updateBA(Banan banan)
        {
            dal.updateBA(banan);
        }
        public void DoiTinhtrangBanan(Banan banan)
        {
            dal.DoiTinhtrangBanan(banan);
        }
        public void DelBanan(Banan banan)
        {
            dal.DelBanan(banan);
        }


    }
}
