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
using QliKhohang.Model;
using Bunifu.UI.WinForms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.InteropServices;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace QliKhohang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SQLiteConnection HangHoaDb;

        private void ConnecSqlite()
        {
            //HangHoaDb.Open();
            string query = "select * from HangHoa";
            SQLiteCommand cmd = new SQLiteCommand(query, HangHoaDb);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            //HangHoaDb.Close();
            ;
        }
        public void loadDataGridview(DataTable dt)
        {
            List<Product> lst = ConvertData(dt);

            foreach (Product p in lst)

            {
                bool check;
                int i = bunifuDataGridView1.RowCount;
                bunifuDataGridView1.Rows.Add(new object[] { i, p.MaHang, p.TenHang, p.SoLuong, p.DonVi, p.GiaThanh });
            }
        }

        private List<Product> ConvertData(DataTable dt)
        {
            List<Product> lst_Product = new List<Product>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Product product = new Product();
                    product.MaHang = dr.ItemArray[0].ToString();
                    product.TenHang = dr.ItemArray[1].ToString();
                    product.SoLuong = Convert.ToInt32(dr.ItemArray[2].ToString());
                    product.DonVi = dr.ItemArray[3].ToString();
                    product.GiaThanh = Convert.ToInt32(dr.ItemArray[4].ToString());
                    lst_Product.Add(product);
                }
            }
            return lst_Product;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string HangHoaDbstring = "data source = C:\\Users\\LAI HOP QUANG\\Desktop\\CodeWinForm\\QliKhohang\\QuanlikhohangDb.db";
            HangHoaDb = new SQLiteConnection(HangHoaDbstring);


        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThem frmThem = new frmThem();
            frmThem.MdiParent = this.MdiParent;
            frmThem.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaThongTinHang frmSuaThongTinHang = new frmSuaThongTinHang();
            frmSuaThongTinHang.MdiParent = this.MdiParent;
            frmSuaThongTinHang.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frmXuatHangHoa frmXuat = new frmXuatHangHoa();
            frmXuat.MdiParent = this.MdiParent;
            frmXuat.ShowDialog();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable dataTable = new DataTable();

        private void btnReset_Click(object sender, EventArgs e)
        {
            ConnecSqlite();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa hàng không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                deleteHangHoa();
                string sql = "delete from HangHoa where MaHang='" + txtMaHang.Text + "'";
                if (HangHoaDb.State != ConnectionState.Open) HangHoaDb.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, HangHoaDb);
                cmd.ExecuteNonQuery();
                ConnecSqlite();

            }

        }

        private void deleteHangHoa()
        {
            string sql = "delete from HangHoa where MaHang='"+ txtMaHang.Text +"'";
            if (HangHoaDb.State != ConnectionState.Open)
                HangHoaDb.Open();
            SQLiteCommand cmds = new SQLiteCommand(sql, HangHoaDb);
            cmds.ExecuteNonQuery();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            frmDonHang frmDonhang = new frmDonHang();
            frmDonhang.MdiParent = this.MdiParent;
            frmDonhang.ShowDialog();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void chọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
                {
                    SetStatusDataGridView(bunifuDataGridView1, i, "CheckChon", true);
                }
            }
            catch
            { }
        }
        private void SetStatusDataGridView(DataGridView dgv, int row, string colName, object status)
        {
            try
            {
                Application.DoEvents();
                dgv.Invoke(new MethodInvoker(delegate ()
                {
                    dgv.Rows[row].Cells[colName].Value = status;
                }));
            }
            catch { }
        }
        private void bỏChọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
                {
                    SetStatusDataGridView(bunifuDataGridView1, i, "CheckChon", false);
                }
            }
            catch
            { }
        }
        private void search2_Click(object sender, EventArgs e)
        {
            loadGridKeyWorld();
        }

        private void search1_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadGridKeyWorld()
        {

            string query = "select * from HangHoa where TenHang like '%" + search1 + "%' ";
            SQLiteCommand cmd = new SQLiteCommand(query, HangHoaDb);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            //bunifuDataGridView1.DataSource = dt;
            loadDataSearch(dt);
        }
        private void loadDataSearch(DataTable dt)
        {
            List<Product> lst = ConvertData(dt);
            foreach (Product p in lst)

            {
                bool check;
                int i = bunifuDataGridView1.RowCount;
                bunifuDataGridView1.Rows.Add(new object[] { check = false, i, p.MaHang, p.TenHang, p.SoLuong, p.DonVi, p.GiaThanh });
            }
        }
        private void ToExcel(DataGridView dataGridView, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                    ToExcel(bunifuDataGridView1, saveFileDialog1.FileName);
                }
            }
        }
        private void SearchHH()
        {
            //HangHoaDb.Open();
            string sql = "select * from HangHoa where TenHang like '%" + search1.Text + "%'";
            SQLiteCommand cmd = new SQLiteCommand(sql, HangHoaDb);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bunifuDataGridView1.DataSource = dt;

            //HangHoaDb.Close();
        }


        private void btnTK_Click(object sender, EventArgs e)
        {
            SearchHH();

        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = bunifuDataGridView1.Rows[e.RowIndex];
            txtMaHang.Text = Convert.ToString(row.Cells["MaHangDGV"].Value);
            txtTenHang.Text = Convert.ToString(row.Cells["TenHangDGV"].Value);
            txtDonVi.Text = Convert.ToString(row.Cells["DonViDGV"].Value);
            txtSoLuong.Text = Convert.ToString(row.Cells["SoLuongDGV"].Value);
            txtGiaThanh.Text = Convert.ToString(row.Cells["GiaThanhDGV"].Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

    }
}
