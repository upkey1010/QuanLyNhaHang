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
    public partial class confirmPayment : Form
    {
        Donhang_BLL dh_bll;
        Banan_BLL banan_bll;
        public static bool StatusDH;
        public confirmPayment()
        {
            InitializeComponent();
            dh_bll = new Donhang_BLL();
            banan_bll = new Banan_BLL();
            loadTongtien();
            StatusDH = false;
        }

        private void loadTongtien()
        {
            AddMAtoTable addMA = new AddMAtoTable();
            labeL_totalPrice.Text = addMA.Tinhtongtien().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Donhang getInfoDHToEdit()
        {
            Donhang dh = new Donhang();
            dh.Donhang_ID = dh_bll.FindUnpaidID(banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID).Donhang_ID;
            dh.Banan_ID = banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID;
            return dh;
        }
        private Banan getInfoBAtoEdit()
        {
            Banan banan = new Banan();
            banan.Banan_ID = banan_bll.FindIDbyName(Mainform.SelectedTable).Banan_ID;
            return banan;
        }

        private void button_confirmation_OK_Click(object sender, EventArgs e)
        {
            dh_bll.DoitrangthaiDH(getInfoDHToEdit());
            banan_bll.DoiTinhtrangBanan(getInfoBAtoEdit());
            StatusDH = true;
            this.Close();

        }
    }
}
