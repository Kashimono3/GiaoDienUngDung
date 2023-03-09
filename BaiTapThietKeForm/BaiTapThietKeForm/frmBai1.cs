using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "50000";
            
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "50000";
         

        }

        private void rdDen_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "100000";
 
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblSoTien.Text = soTien.ToString();
        }
    }
}
