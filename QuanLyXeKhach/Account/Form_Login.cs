using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.Account
{
    public partial class Form_Login : Form
    {
        private Account.Form_DangKi Form_DangKi;
        public Form_Login()
        {
            InitializeComponent();
            Form_DangKi = new Account.Form_DangKi();
            
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Form_DangKi.Show();
        }
    }
}
