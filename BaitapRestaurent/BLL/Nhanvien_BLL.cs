using BaitapRestaurent.DAL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.BLL
{
    class Nhanvien_BLL
    {
        Nhanvien_DAL dal = new Nhanvien_DAL();

        public string Generate_NVID()
        {
            return dal.Generate_NVID();
        }

        public void AddNVtoDB(Nhanvien nv)
        {
            dal.AddNVtoDB(nv);
        }
        public List<Nhanvien> getListNVtoShow()
        {
            return dal.getListNVtoShow();
        }

        public int checkTenDangnhap(string tendangnhap)
        {
            return dal.checkTenDangnhap(tendangnhap);
        }

        public int checkNhanvienLogin(string user, string password)
        {
            return dal.checkNhanvienLogin(user, password);
        }

    }
}
