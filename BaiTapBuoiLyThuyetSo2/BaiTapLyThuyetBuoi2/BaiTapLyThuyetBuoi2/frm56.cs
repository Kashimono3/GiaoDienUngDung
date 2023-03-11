using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyetBuoi2
{
    public partial class frm56 : Form
    {
        public frm56()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNam.Checked)
                MessageBox.Show("Giới tính bạn là : " + rdNam.Text);

        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNu.Checked)
                MessageBox.Show("Giới tính bạn là : " + rdNu.Text);
        }
    }
}
