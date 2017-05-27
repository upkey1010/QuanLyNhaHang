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
    }
}
