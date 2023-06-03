using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang_Demo_2111875
{
     public class MatHang
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int MaNCC { get; set; }
        public string TenNhaCC { get; set; }
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public MatHang(DataRow row)
        {
            MaMatHang = Convert.ToInt32(row["MaMatHang"]);
            TenMatHang = row["TenMatHang"].ToString();
            SoLuong = Convert.ToInt32(row["SoLuong"]);
            DonGia = Convert.ToInt32(row["DonGia"]);
            MaNCC = Convert.ToInt32(row["MaNCC"]);
            TenNhaCC = row["TenNhaCC"].ToString();
            MaLoai = Convert.ToInt32(row["MaLoai"]);
            TenLoai = row["TenLoai"].ToString();
        }
    }
}
