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
    public partial class AddMonan : Form
    {
        LoaiMonan_BLL cate_bll;
        Monan_BLL monan_bll;
        public delegate void UpdateGridview();
        public UpdateGridview update;
        public AddMonan()
        {
            InitializeComponent();
            cate_bll = new LoaiMonan_BLL();
            monan_bll = new Monan_BLL();
            addLoaiMonantoCBB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addLoaiMonantoCBB()
        {
            foreach(LoaiMonan item in cate_bll.getListtoShow())
            {
                cbb_addMA_loaiMA.Items.Add(item.TenLoaimonan);
            }
        }

        private Monan getInfotoAdd()
        {
            Monan monan = new Monan();
            monan.TenMonan = txt_addMA_TenMA.Text;
            monan.Giatien = Convert.ToInt32(txt_addMA_price.Text);
            monan.LoaiMonan_ID = cate_bll.FindIDbyName(cbb_addMA_loaiMA.Text).LoaiMonan_ID;
            return monan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monan_bll.AddMAtoDB(getInfotoAdd());
            update.Invoke();
            this.Close();
        }
    }
}
