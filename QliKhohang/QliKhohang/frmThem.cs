using Bunifu.UI.WinForms;
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


namespace QliKhohang
{
    public partial class frmThem : Form
    {
        public frmThem()
        {
            InitializeComponent();
            LoadDataGridViewS();
        }
        SQLiteConnection HangHoaDb = new SQLiteConnection("data source = C:\\Users\\LAI HOP QUANG\\Desktop\\CodeWinForm\\QliKhohang\\QuanlikhohangDb.db");






        private DataTable DTTable = new DataTable();

        private void LoadDataGridViewS()
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmThem_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            HangHoaDb.Open();
            string query = "select * from HangHoa";
            SQLiteCommand cmd = new SQLiteCommand(query, HangHoaDb);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            
            for (int i = 0; i < ThemDGV.Rows.Count - 1; i++)
            {
                string sql = String.Format("insert into HangHoa values('{0}', '{1}', '{2}', '{3}', '{4}')", ThemDGV.Rows[i].Cells["MaHangDGVThem"].Value, ThemDGV.Rows[i].Cells["TenHangDGVThem"].Value, ThemDGV.Rows[i].Cells["SoLuongDGVThem"].Value, ThemDGV.Rows[i].Cells["DonViDGVThem"].Value, ThemDGV.Rows[i].Cells["GiaThanhDGVThem"].Value);
                cmd.CommandText = sql;

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thêm được");
                }
            }

            HangHoaDb.Close();


            this.Close();

        }
        private DataTable dataTable = new DataTable();

        private void bunifuButton1_Click(object sender, EventArgs e)
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

            ThemDGV.Rows.Add(new object[] {  ThemDGV.RowCount, txtMaHang.Text, txtTenHang.Text, txtSoLuong.Text, txtDonVi.Text, txtGiaThanh.Text });
            ThemReset();
        }

        private void ThemReset()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonVi.Text = "";
            txtGiaThanh.Text = "";
        }

        private void ThemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaThem_Click(object sender, EventArgs e)
        {
            if (this.ThemDGV.SelectedRows.Count > 0)
            {
                ThemDGV.Rows.RemoveAt(this.ThemDGV.SelectedRows[0].Index);
                MessageBox.Show("đã xóa ");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm xóa");
            }
        }
    }
}
