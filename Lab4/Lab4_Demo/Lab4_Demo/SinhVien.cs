using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Demo
{
    class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool Phai { get; set; }
        public string SoDienThoai { get; set; }
        public SinhVien()
        {
            
        }
        public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop, string hinh, bool phai, string sdt, string email )
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.NgaySinh = ngay;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.Phai = phai;
            this.SoDienThoai = sdt;
            this.Email = email;
        }
    }
}
