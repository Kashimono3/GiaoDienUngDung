using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Demo
{
    public delegate int SoSanh(object sv1, object sv2);
    class QuanLySinhVien
    {
            public List<SinhVien> DanhSach;
            public QuanLySinhVien()
            {
                DanhSach = new List<SinhVien>();
            }
            
            public void Them(SinhVien sv)
            {
                this.DanhSach.Add(sv);
            }
            public SinhVien this[int index]
            {
                get { return DanhSach[index]; }
                set { DanhSach[index] = value; }
            }
           
            public void Xoa(object obj, SoSanh ss)
            {
                int i = DanhSach.Count - 1;
                for (; i >= 0; i--)
                    if (ss(obj, this[i]) == 0)
                        this.DanhSach.RemoveAt(i);
            }
            public SinhVien Tim(object obj, SoSanh ss)
            {
                SinhVien svresult = null;
                foreach (SinhVien sv in DanhSach)
                    if (ss(obj, sv) == 0)
                    {
                        svresult = sv;
                        break;
                    }
                return svresult;
            }

            public bool Sua(SinhVien svsua, object obj, SoSanh ss)
            {
                int i, count;
                bool kq = false;
                count = this.DanhSach.Count - 1;
                for (i = 0; i < count; i++)
                    if (ss(obj, this[i]) == 0)
                    {
                        this[i] = svsua;
                        kq = true;
                        break;
                    }
                return kq;
            }

          
            public void DocTuFile()
            {
                string filename = "DanhSach.txt", t;
                string[] s;
                SinhVien sv;
                StreamReader sr = new StreamReader(
                new FileStream(filename,
               FileMode.Open));
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split(',');
                    sv = new SinhVien();
                    sv.MaSo = s[0];
                    sv.HovaTenLot = s[1];
                    sv.Ten = s[2];
                    sv.NgaySinh = DateTime.Parse(s[3]);
                    sv.Lop = s[4];
                    sv.CMND = s[5];
                    sv.SoDienThoai = s[6];
                    sv.DiaChi = s[7];
                    sv.GioiTinh = false;
                    if (s[8] == "0")
                        sv.GioiTinh = true;
                    string[] mh = s[9].Split('*');
                    foreach (string c in mh)
                    sv.MonHocDangKy.Add(c);
                this.Them(sv);
                }
            }
    } 
}
