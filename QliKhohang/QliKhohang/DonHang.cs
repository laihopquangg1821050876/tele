using Bunifu.UI.WinForms;
using QliKhohang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QliKhohang.Model;

namespace QliKhohang
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {

        }
        SQLiteConnection HangHoaDb = new SQLiteConnection("data source = C:\\Users\\LAI HOP QUANG\\Desktop\\CodeWinForm\\QliKhohang\\QuanlikhohangDb.db");
        private void ConnecSqliteSHD()
        {
            //HangHoaDb.Open();
            string query = "select * from HangHoa";
            SQLiteCommand cmd = new SQLiteCommand(query, HangHoaDb);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
            

        }

        //private void loadDataGridview(DataTable dt)
        //{
        //    List<HoaDon> lst = ConvertData(dt);
        //    foreach (HoaDon p in lst)

        //    {
        //        bool check;
        //        int i = dgvHoaDon.RowCount;
        //        dgvHoaDon.Rows.Add(new object[] { p.MaHang, p.TenHang, p.SoLuong, p.DonVi, p.GiaThanh });
        //    }
        //}

        //private List<HoaDon> ConvertData(DataTable dt)
        //{
        //    List<HoaDon> lst_HoaDon = new List<HoaDon>();
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            HoaDon hoadon = new HoaDon();
        //            hoadon.MaHang = dr.ItemArray[0].ToString();
        //            hoadon.TenHang = dr.ItemArray[1].ToString();
        //            hoadon.SoLuong = Convert.ToInt32(dr.ItemArray[2].ToString());
        //            hoadon.DonVi = dr.ItemArray[3].ToString();
        //            hoadon.GiaThanh = Convert.ToInt32(dr.ItemArray[4].ToString());
        //            lst_HoaDon.Add(hoadon);
        //        }
        //    }
        //    return lst_HoaDon;
        //}

        private void btnLoadHD_Click(object sender, EventArgs e)
        {
            //dgvHoaDon.Rows.Clear();
            ConnecSqliteSHD();
        }

        private void btnCloseHD_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiemHD_CellClick(object sender, EventArgs e)
        {

        }

        

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoaDon.Rows[e.RowIndex];
            txtMaHangCTHD.Text = Convert.ToString(row.Cells["MaHangHD"].Value);
            txtTenHangCTHD.Text = Convert.ToString(row.Cells["TenHangHD"].Value);            
            txtDonViCTHD.Text = Convert.ToString(row.Cells["DonViHD"].Value);
            txtGiaThanhCTHD.Text = Convert.ToString(row.Cells["GiThanhHD"].Value);

        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHangCTHD_TextChanged(object sender, EventArgs e)
        {

        }
        void Reset()
        {
            txtMaHangCTHD.Clear();
            txtTenHangCTHD.Clear();
            txtSoLuongCTHD.Clear();
            txtDonViCTHD.Clear();
            txtGiaThanhCTHD.Focus();
        }

        private void btnThemXuat_Click(object sender, EventArgs e)
        {
           dgvHD.Rows.Add(new object[] {  dgvHD.RowCount, txtMaHangCTHD.Text, txtTenHangCTHD.Text, txtSoLuongCTHD.Text, txtDonViCTHD.Text, txtGiaThanhCTHD.Text });
           ResetHD();
        }

        private void ResetHD()
        {
            txtMaHangCTHD.Text = "";
            txtTenHangCTHD.Text = "";
            txtSoLuongCTHD.Text = "";
            txtDonViCTHD.Text = "";
            txtGiaThanhCTHD.Text = "";
        }
        

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            if (this.dgvHD.SelectedRows.Count > 0)
            {
                dgvHD.Rows.RemoveAt(this.dgvHD.SelectedRows[0].Index);
                MessageBox.Show("đã xóa ");
            }
            else 
            {
                MessageBox.Show("Không có sản phẩm xóa");
            }
        }   

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchHD_TextChanged(object sender, EventArgs e)
        {
            {
                //string sql = "Select * from HangHoa where MaHang LIKE '%" + txtSearchHD.Text + "%' or  TenHang LIKE '%" + txtSearchHD.Text + "%'";
                //dgvHD.DataSource = Load.LoadDulieu(sql);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SearchHH()
        {
            HangHoaDb.Open();
            string sql = "select * from HangHoa where TenHang like '%" + txtSearchHD.Text + "%'";
            SQLiteCommand cmd = new SQLiteCommand(sql, HangHoaDb);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;

            HangHoaDb.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchHH();
        }
    }
}
