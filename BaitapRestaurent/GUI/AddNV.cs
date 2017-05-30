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
    public partial class AddNV : Form
    {
        Nhanvien_BLL nv_bll;
        public delegate void UpdateGridview();
        public UpdateGridview update;
        public AddNV()
        {
            nv_bll = new Nhanvien_BLL();
            InitializeComponent();
            AddRankcombobox();
            Error_mess.Hide();
        }

        public void AddRankcombobox()
        {
            cbb_addNV_rank.Items.Add("Truong cua hang");
            cbb_addNV_rank.Items.Add("Nhan vien thuong");
        }

        public Nhanvien getInfoNVtoAdd()
        {
            Nhanvien nv = new Nhanvien();

            nv.TenNV = txt_addNV_TenNV.Text;
            nv.Ngaysinh = DateTime.Parse (dateTimePicker_addNV.Text);
            nv.TenDangNhap = txt_addNV_TenDangnhap.Text;
            nv.Matkhau = txt_addNV_Matkhau.Text;
            nv.Capbac = cbb_addNV_rank.Text;
            if (rb_addNV_male.Checked) nv.Gioitinh = true;
            if (rb_addNV_female.Checked) nv.Gioitinh = false;
            return nv;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool register_success = false;
            
            if (txt_code.Text == "NV2017")
            {
                if (nv_bll.checkTenDangnhap(getInfoNVtoAdd().TenDangNhap) != 0)
                {
                    Error_mess.Show();
                }
                else
                {
                    nv_bll.AddNVtoDB(getInfoNVtoAdd());
                    register_success = true;
                }
            }
            else
            {
                MessageBox.Show("Chua nhap Code hoac Code khong dung !");
            }
            
            if (register_success == true)
            {
                if (DangnhapForm.checkPlace == false)
                {
                    this.Close();
                    DangnhapForm a = new DangnhapForm();
                    a.Show();
                }
                else
                {
                    update.Invoke();
                    this.Close();
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
