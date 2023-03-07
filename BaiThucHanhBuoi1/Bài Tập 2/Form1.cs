using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show($"Bạn Đã Chọn Nam","Thông Báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show($"Bạn Đã Chọn Nữ", "Thông Báo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtMau.BackColor = Color.Red;
            else
                txtMau.BackColor = Color.Green;
        }
    }
}
