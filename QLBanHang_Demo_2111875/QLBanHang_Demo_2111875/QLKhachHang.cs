using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang_Demo_2111875
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LayDanhSachKhachHang();
            AddBinding();
        
            }
        public void LayDanhSachKhachHang()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * From KhachHang";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            dgvKhachHang.DataSource = table;    

        }

       public void AddBinding()
        {
            txtMaKhachHang.DataBindings.Add("Text", dgvKhachHang.DataSource,"MaKH");
            txtTenKhachHang.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");
            mstxtSoDienThoai.DataBindings.Add("Text", dgvKhachHang.DataSource, "SoDienThoai");
            txtDiaChi.DataBindings.Add("Text", dgvKhachHang.DataSource, "DiaChiGH");
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            mstxtSoDienThoai.Clear();
        }
        public int ThemKhachHang(string hoten, string sdt, string diachi)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO KhachHang VALUES(@TenKH,@SoDienThoai,@DiaChiGH)";
            command.Parameters.AddWithValue("TenKH", hoten);
            command.Parameters.AddWithValue("SoDienThoai", sdt);
            command.Parameters.AddWithValue("DiaChiGH", diachi);
            conn.Open();
            var soDongAnhHuong = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return soDongAnhHuong;
        }
        public int suaKhachHang(string makh,string hoten, string sdt, string diachi)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = "UPDATE  KhachHang SET TenKH= @Tenkh, SoDienThoai= @SoDienThoai ,DiaChiGH=@DiaChiGH   " + 
                "WHERE  MaKH = @MaKH";
            command.Parameters.AddWithValue("MaKH", makh);
            command.Parameters.AddWithValue("TenKH", hoten);
            command.Parameters.AddWithValue("SoDienThoai", sdt);
            command.Parameters.AddWithValue("DiaChiGH", diachi);
            conn.Open();
            var soDongAnhHuong = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return soDongAnhHuong;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var ma = txtMaKhachHang.Text;
            var hoten = txtTenKhachHang.Text;
            var sdt = mstxtSoDienThoai.Text;
            var diachi = txtDiaChi.Text;
            var soDongAnhHuong = -1;
            if(string.IsNullOrEmpty(hoten)|| string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đủ họ tên, Số điện thoại khách hàng", "Thông báo");
                return;

            }
            if (string .IsNullOrEmpty(ma))
            {
                soDongAnhHuong = ThemKhachHang(hoten, sdt, diachi);
            }   
            else
            {
                soDongAnhHuong = suaKhachHang(ma, hoten, sdt, diachi);
            }
            if (soDongAnhHuong > 0)
            {
                MessageBox.Show("Thêm/Sửa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm/Sửa không thành công", "Thông báo");
            }
            LayDanhSachKhachHang();
        }
    }
}
