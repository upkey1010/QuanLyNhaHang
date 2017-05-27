using BaitapRestaurent.BLL;
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
    public partial class DangnhapForm : Form
    {
        Nhanvien_BLL nv_bll;
        public DangnhapForm()
        {
            InitializeComponent();
            nv_bll = new Nhanvien_BLL();
            Error_login_mess.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_dangnhap_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            if (nv_bll.checkNhanvienLogin(txt_login_Tendangnhap.Text,txt_login_password.Text) != 0)
            {
                this.Hide();
                mainform.Show();                
            }
            else
            {
                Error_login_mess.Show();
            }
        }

        private void PressEnterLoginCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_dangnhap_Click(this, new EventArgs());
            }
        }
        
    }
}
