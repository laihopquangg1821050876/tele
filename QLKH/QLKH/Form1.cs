using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;


namespace QLKH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection  Hanghoadbb = new SQLiteConnection("data source = C:\\Users\\LAI HOP QUANG\\Desktop\\sqlite\\QLKH.db");
            Hanghoadbb.Open();
            string query = "select * from HangHoa";
            SQLiteCommand cmd = new SQLiteCommand(query, Hanghoadbb);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dgvHangHoa.DataSource = dt;
            txtMaHang.Enabled = false;
            
            btnXuatExcel.Enabled = false;
            btnXuatPDF.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        private DataTable dataTable = new DataTable();
        private void LoadDataGridView()
        {
            dataTable.Columns.Add("", typeof(CheckBox));
            dataTable.Columns.Add("Mã Hàng", typeof(string));
            dataTable.Columns.Add("Tên Hàng", typeof(string));
            dataTable.Columns.Add(" Số lượng ", typeof(int));
            dataTable.Columns.Add("Giá thành", typeof(float));
            dgvHangHoa.DataSource = dataTable;
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e, object dataTable)
        {

            txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvHangHoa.CurrentRow.Cells["TenHang"].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtGiaThanh.Text = dgvHangHoa.CurrentRow.Cells["GiaThanh"].Value.ToString();
            btnXoa.Enabled = true;
            btnXuatExcel.Enabled = true;
            btnXuatPDF.Enabled = true;
            btnBoQua.Enabled = true;
            dgvHangHoa.DataSource = dataTable;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            
            btnXuatExcel.Enabled = true;
            btnXuatPDF.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaHang.Enabled = true; //cho phép nhập mới
            txtMaHang.Focus();
        }

        private void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtGiaThanh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaHang.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            dataTable.Rows.Add(txtMaHang.Text, txtTenHang.Text,Convert.ToInt32(txtSoLuong.Text), float.Parse(txtGiaThanh.Text));
            dgvHangHoa.DataSource = dataTable;

            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnXuatExcel.Enabled = true;
            btnLuu.Enabled = true;
            txtMaHang.Enabled = false;
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGiaThanh_TextChanged(object sender, EventArgs e)
        {

        }
         
    }

}
