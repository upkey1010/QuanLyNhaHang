using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class Monan_BLL
    {
        Monan_DAL dal = new Monan_DAL();
        public void AddMAtoDB(Monan monan)
        {
            dal.AddMAtoDB(monan);
        }
        public List<Monan> getList()
        {
            return dal.getList();
        }
    }
}
