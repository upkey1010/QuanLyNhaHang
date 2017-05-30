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
    public partial class AddMAtoTable : Form
    {
        Monan_BLL monan_bll;
        ChitietDonhang_BLL chitiet_bll;
        Banan_BLL banan_bll;
        Donhang_BLL dh_bll;
        string SelectedMA_ID;
        public delegate void UpdateGridview();
        public UpdateGridview update;

        public AddMAtoTable()
        {
            InitializeComponent();
            monan_bll = new Monan_BLL();
            chitiet_bll = new ChitietDonhang_BLL();
            banan_bll = new Banan_BLL();
            dh_bll = new Donhang_BLL();
            label_tenban.Text = Mainform.SelectedTable;
            loadDgvMonan();
            loadDgvChitietDonhang();
            LoadTongtien();
            txt_soluong.Text = "1";
            //label_madonhang.Text = dh_bll.FindUnpaidID(banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID).Donhang_ID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadTongtien()
        {
            totalprice_label.Text =  Tinhtongtien().ToString();
        }
        public int Tinhtongtien()
        {
            int Tongtien = 0;
            foreach (Chitiet_donhang Item in chitiet_bll.getListDH_unpaid(banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID))
            {
                Tongtien += Item.Monan.Giatien * Item.Soluong;
            }
            return Tongtien;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            if (confirmPayment.StatusDH == true)
            {
                MessageBox.Show("Don hang da thanh toan, khong the them mon an !");
            }
            else
            {
                if (chitiet_bll.checkMonanDachon(getInfoChitietDonhang().Donhang_ID, getInfoChitietDonhang().Monan_ID) == 0)
                {
                    chitiet_bll.AddChitietDonhangtoDB(getInfoChitietDonhang());
                }
                else
                {
                    chitiet_bll.updateSoluong(getInfoChitietDonhang());
                }
            }
            //loadDgvChitietDonhang();
            //LoadTongtien();
        }

        private void loadDgvMonan()
        {
            List<Monan> list = monan_bll.getList();
            
            dgv_monan.DataSource = list.Select(p => new { MaMonan = p.Monan_ID, TenMonan = p.TenMonan, Giatien = p.Giatien }).ToList();
        }

        private void loadDgvChitietDonhang()
        {
            List<Chitiet_donhang> list = chitiet_bll.getListDH_unpaid(banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID);
            if (list.Count() != 0)
            {
                dgv_hoadon.DataSource = list.Select(p => new { TenMonan = p.Monan.TenMonan, Soluong = p.Soluong, Dongia = p.Monan.Giatien }).ToList();
            }
        }

        private void dgv_monan_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgv_monan.SelectedRows.Count == 1)
            {
                SelectedMA_ID = (string)dgv_monan.SelectedCells[0].Value;
                label_MA.Text = (string)dgv_monan.SelectedCells[0].Value;
            }
        }

        private Chitiet_donhang getInfoChitietDonhang()
        {
            Chitiet_donhang chitiet = new Chitiet_donhang();
            chitiet.Donhang_ID = dh_bll.FindUnpaidID(banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID).Donhang_ID;
            chitiet.Monan_ID = SelectedMA_ID;
            chitiet.Soluong = Convert.ToInt32(txt_soluong.Text);
            return chitiet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDgvChitietDonhang();
            LoadTongtien();
        }

        private void button_addMAtoBA_thanhtoan_Click(object sender, EventArgs e)
        {
            confirmPayment confirm = new confirmPayment();
            confirm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update.Invoke();
            this.Close();
        }
    }
}
