using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Demo
{
  
    public partial class Form1 : Form
    {
        QuanLySinhVien QLSV;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            QLSV = new QuanLySinhVien();
            QLSV.DocTuFile();
            LoadListView();
        }
  
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mh = new List<string>();
            sv.MaSo = this.mstxMSSV.Text;
            sv.HovaTenLot = this.txtHovaTenLot.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cbLop.Text;
            sv.SoDienThoai = this.mstxSDT.Text;
            sv.CMND = this.mstxSoCMND.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                if (clbMonHoc.GetItemChecked(i))
                    mh.Add(clbMonHoc.Items[i].ToString());
            sv.MonHocDangKy = mh;
            return sv;
        }
     
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HovaTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.CMND = lvitem.SubItems[5].Text;
            sv.SoDienThoai = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[8].Text == "Nam")
                sv.GioiTinh = true;       
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split('*');
            foreach (string t in s)
                mh.Add(t);
            sv.MonHocDangKy = mh;          
            return sv;
        }
       
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mstxMSSV.Text = sv.MaSo;
            this.txtHovaTenLot.Text = sv.HovaTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbLop.Text = sv.Lop;
            this.mstxSoCMND.Text = sv.CMND;
            this.mstxSDT.Text = sv.SoDienThoai;
            this.txtDiaChi.Text = sv.DiaChi;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                this.clbMonHoc.SetItemChecked(i, false);
            foreach (string s in sv.MonHocDangKy)
            {
                for (int i = 0; i < this.clbMonHoc.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbMonHoc.Items[i]) == 0)
                        this.clbMonHoc.SetItemChecked(i,
                        true);
            }
        } 
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HovaTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.CMND);
            lvitem.SubItems.Add(sv.SoDienThoai);
            lvitem.SubItems.Add(sv.DiaChi);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string mh = "";
            foreach (string s in sv.MonHocDangKy)
                mh += s + " ";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvSinhVien.Items.Add(lvitem);      
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in QLSV.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Sinh Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = QLSV.Tim(sv.MaSo,delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.QLSV.Them(sv);
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var form = new frmtuychon();
            form.ShowDialog();
        }
    }
}
