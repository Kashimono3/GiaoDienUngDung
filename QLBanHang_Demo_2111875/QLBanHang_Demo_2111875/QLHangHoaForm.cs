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
    public partial class QLHangHoaForm : Form
    {
        public QLHangHoaForm()
        {
            InitializeComponent();
        }

        private void QLHangHoaForm_Load(object sender, EventArgs e)
        {
            LayDanhSachMH();
        }
        public void LayDanhSachMH()
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * From LoaiMatHang";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            cbLoaiHang.DisplayMember = "TenLoai";
            cbLoaiHang.ValueMember = "MaLoai";
            cbLoaiHang.DataSource = table;
          
        }
        public void LayDanhSachTheoMaLoai(int maLoai)
        {
            var connString = Utilities.connectionString;
            var conn = new SqlConnection(connString);
            var command = conn.CreateCommand();
            command.CommandText = $"SELECT * From MatHang WHERE MaLoai = {maLoai}";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            dgvHangHoa.DataSource = table;
        }

        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoaiHang.SelectedValue != null)
            {
                var maLoai = Convert.ToInt32(cbLoaiHang.SelectedValue);
                LayDanhSachTheoMaLoai(maLoai);
            }
        }

    }
}
