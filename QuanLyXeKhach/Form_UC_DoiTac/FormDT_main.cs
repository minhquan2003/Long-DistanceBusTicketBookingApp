using QuanLyXeKhach.Control_Ads;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.Form_UC_DoiTac
{
    public partial class FormDT_main : Form
    {
        public FormDT_main()
        {
            InitializeComponent();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_KH_Main);
        }

        private void pl_DT_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_KH_Main);
        }

        private void btnDT_DichVu_Click(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_DT_DichVu uC_DT_dichvu = new UC_DT_DichVu();
            uC_DT_dichvu.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_DT_dichvu);
        }

        private void btnDT_UuDai_Click(object sender, EventArgs e)
        {
            ///
            pl_DT_show.Controls.Clear();
            UC_DT_UuDai uC_DT_uudai = new UC_DT_UuDai();
            uC_DT_uudai.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_DT_uudai);
        }

        private void btnDT_UuDai_Click_1(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_DT_UuDai uC_DT_uudai = new UC_DT_UuDai();
            uC_DT_uudai.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_DT_uudai);
        }
    }
}
