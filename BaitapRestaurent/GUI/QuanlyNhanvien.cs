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
    public partial class QuanlyNhanvien : Form
    {
        Nhanvien_BLL nv_bll;
        public QuanlyNhanvien()
        {
            InitializeComponent();
            nv_bll = new Nhanvien_BLL();
            loadDatagridviewNV();
            DangnhapForm.checkPlace = true;
        }

        public void loadDatagridviewNV()
        {
            List<Nhanvien> list = nv_bll.getListNVtoShow();
            dgv_nv.DataSource = list.Select(p => new { MaNV = p.NV_ID, TenNhanvien = p.TenNV, Ngaysinh = p.Ngaysinh, Gioitinh=p.Gioitinh, Capbac=p.Capbac }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNV AddNV = new AddNV();
            AddNV.update = new AddNV.UpdateGridview(loadDatagridviewNV);
            AddNV.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
