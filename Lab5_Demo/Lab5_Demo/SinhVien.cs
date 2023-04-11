using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Demo
{
    public class SinhVien
    {

        
            //Các thuộc tính của lớp sinh viên
            public string MaSo { get; set; }
            public string HovaTenLot { get; set; }
             public string Ten { get; set; }
            public DateTime NgaySinh { get; set; }
            public string Lop { get; set; }
            public string CMND { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
            public bool GioiTinh { get; set; }

            public List<string> MonHocDangKy { get; set; }
        public SinhVien()
            {
            MonHocDangKy = new List<string>();
            }
          
            public SinhVien(string ms, string htl,string ten, DateTime ngay, string lop, string cmnd, string sdt,string dc, bool gt, List<string> mh)
            {
                this.MaSo = ms;
                this.HovaTenLot = htl;
                this.Ten = ten;
                this.NgaySinh = ngay;
                this.Lop = lop;
                this.CMND = cmnd;
                this.SoDienThoai = sdt;
                this.GioiTinh = gt;
                this.MonHocDangKy = mh;
            }
        }
    }
