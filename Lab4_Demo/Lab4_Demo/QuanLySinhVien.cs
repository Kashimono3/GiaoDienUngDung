using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Lab4_Demo
{
    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return this.DanhSach[index]; }
            set { this.DanhSach[index] = value; }
        }

        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt";
            string[] s;
            string t;
            SinhVien sv;
            StreamReader sr = new StreamReader(filename);
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split(',');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.Phai = false;
                if (s[2] == "1")
                    sv.Phai = true;
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SoDienThoai = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];
                this.DanhSach.Add(sv);

            }
        }
    }
}

