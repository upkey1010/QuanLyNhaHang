using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class LoaiMonan_BLL
    {
        LoaiMonan_DAL dal = new LoaiMonan_DAL();

        public void AddLoaiMAtoDB(LoaiMonan cate)
        {
            dal.AddLoaiMAtoDB(cate);
        }

        public List<LoaiMonan> getListtoShow()
        {
            return dal.getListtoShow();
        }

        public LoaiMonan FindIDbyName(string name)
        {
            return dal.FindIDbyName(name);
        }

    }
}
