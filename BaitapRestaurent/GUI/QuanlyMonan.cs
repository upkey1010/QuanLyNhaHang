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
    public partial class QuanlyMonan : Form
    {
        LoaiMonan_BLL cate_bll;
        public QuanlyMonan()
        {
            InitializeComponent();
            cate_bll = new LoaiMonan_BLL();
            loadDgvLoaiMonan();
        }

        private void loadDgvLoaiMonan()
        {
            List<LoaiMonan> list = cate_bll.getListtoShow();
            dgv_LoaiMonan.DataSource = list.Select(p => new { MaLoai = p.LoaiMonan_ID, TenLoai = p.TenLoaimonan }).ToList();
        }

        private void loadDgvMonan()
        {

        }

        private LoaiMonan getinfoLoaiMonan()
        {
            LoaiMonan cate = new LoaiMonan();
            cate.TenLoaimonan = txt_QLMA_TenLoaiAdd.Text;
            return cate;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddMonan addmonan = new AddMonan();
            addmonan.Show();
        }

        private void but_addcate_Click(object sender, EventArgs e)
        {
            cate_bll.AddLoaiMAtoDB(getinfoLoaiMonan());
            loadDgvLoaiMonan();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mainform = new Mainform();
            mainform.Show();
        }
    }
}
