using BaitapRestaurent.BLL;
using BaitapRestaurent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapRestaurent.GUI
{
    public partial class Mainform : Form
    {
        Banan_BLL banan_bll;
        Monan_BLL monan_bll;
        Donhang_BLL dh_bll;
        public static string SelectedTable = "Ban an so 1";
        public Mainform()
        {
            InitializeComponent();
            banan_bll = new Banan_BLL();
            monan_bll = new Monan_BLL();
            dh_bll = new Donhang_BLL();
            loadDgvMain();
        }

        public void loadDgvMain()
        {
            List<Banan> list = banan_bll.getListBAtoShow();
            dgv_main.DataSource = list.Select(p => new { MaBanan = p.Banan_ID, TenBanan = p.TenBanan, Tinhtrang=p.Tinhtrang }).ToList();
        }

        private void main_add_Click(object sender, EventArgs e)
        {
            banan_bll.AddBAtoDB();
            loadDgvMain();
        }

        private void button_main_QLNV_Click(object sender, EventArgs e)
        {
            QuanlyNhanvien QLNV = new QuanlyNhanvien();
            if(DangnhapForm.NhanvienLoggedin.Capbac=="Nhan vien thuong")
            {
                MessageBox.Show("Ban khong du cap bac de truy cap!");
            }
            else
            {
                QLNV.Show();
            }
            
        }

        private void button_main_QLMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanlyMonan QLMA = new QuanlyMonan();
            QLMA.Show();
        }

        private void dgv_main_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_main.SelectedRows.Count == 1)
            {
                SelectedTable = (string) dgv_main.SelectedCells[1].Value;
                test.Text = Convert.ToString(banan_bll.FindIDbyName(SelectedTable).Tinhtrang);
                test2.Text = SelectedTable;
            }
        }

        private void button_main_goimon_Click(object sender, EventArgs e)
        {
            AddMAtoTable AddMAtoBA = new AddMAtoTable();
            if (banan_bll.FindIDbyName(SelectedTable).Tinhtrang == false)
            {
                dh_bll.AddDHtoDB(getInfoDHtoAdd());

                Banan BA = new Banan();
                BA.Banan_ID = banan_bll.FindIDbyName(SelectedTable).Banan_ID;
                BA.Tinhtrang = true;
                BA.TenBanan = SelectedTable;
                banan_bll.updateBA(BA);
            }
            AddMAtoBA.update = new AddMAtoTable.UpdateGridview(loadDgvMain);
            AddMAtoBA.Show();
        }
        private Donhang getInfoDHtoAdd()
        {
            Donhang dh = new Donhang();
            dh.NV_ID = DangnhapForm.NV_ID_login;
            dh.Banan_ID = banan_bll.FindIDbyName(SelectedTable).Banan_ID;
            dh.ThoigianTaodon = DateTime.Now;
            dh.Tinhtrang = false;
            return dh;
        }
    }
}
