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
        public Mainform()
        {
            InitializeComponent();
            banan_bll = new Banan_BLL();
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
            QLNV.Show();
        }

        private void button_main_QLMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanlyMonan QLMA = new QuanlyMonan();
            QLMA.Show();
        }
    }
}
