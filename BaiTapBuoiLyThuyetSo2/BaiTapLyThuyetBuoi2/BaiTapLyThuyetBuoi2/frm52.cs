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
    public partial class frm52 : Form
    {
        public frm52()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhSach.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--) 
            {
                LbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = LbDanhSachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                LbDanhSachChon.Items.RemoveAt(LbDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
