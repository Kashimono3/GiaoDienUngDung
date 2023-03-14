using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_Lap2_1
{
     public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhSachMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDt;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhSachMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso,string hoten, DateTime ngaysinh,DanhSachMonHoc ds, string gt, string [] nn, string sdt,string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDt = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số : " + MaSo + "\n" + "Họ Tên: " + HoTen + "\n" + "Ngày Sinh: " + NgaySinh.ToString() + "\n" + "Giới Tính: " + GioiTinh + "\n" + "Số ĐT : " + SoDt + "\n" + "Mail : " + Mail + "\n";
            string sngoaingu = "Ngoại ngữ:";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string MonDay = "Danh Sách Môn Dạy";
            foreach (MonHoc mh in dsMonHoc.ds)
                MonDay += mh + ";";
            s += "\n" + sngoaingu + "\n" + MonDay;
            return s;

        }
    }
}
