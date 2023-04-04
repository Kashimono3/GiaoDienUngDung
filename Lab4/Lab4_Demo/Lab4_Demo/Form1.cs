using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien DSSV;
        public frmSinhVien()
        {
            
            InitializeComponent();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image file(*.bmp;*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbHinh.Image = Image.FromFile(openFile.FileName);
                txtHinh.Text = openFile.FileName.Substring(openFile.FileName.LastIndexOf('\\') + 1);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;           
            this.mtxtSDT.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            if (rdNu.Checked)
                gt = false;
            sv.Phai = gt;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.SoDienThoai = this.mtxtSDT.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
          
            sv.Email = this.txtEmail.Text;

            return sv;
        }
       
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.Phai = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.Phai = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SoDienThoai = lvitem.SubItems[5].Text;   
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }
    
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.Phai)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.mtxtSDT.Text = sv.SoDienThoai;
            this.txtEmail.Text = sv.Email;
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            string gt = "Nữ";
            if (sv.Phai)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoDienThoai);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
           
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in DSSV.DSSV)
            {
                ThemSV(sv);
            }
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DSSV = new QuanLySinhVien();
            DSSV.DocTuFile();
            LoadListView();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void lvSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvSinhVien.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

       
    }
}
