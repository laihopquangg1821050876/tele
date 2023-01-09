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

namespace QliKhohang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection HangHoaDb = new SQLiteConnection("data source = C:\\Users\\LAI HOP QUANG\\Desktop\\CodeWinForm\\QliKhohang\\QuanlikhohangDb.db");
        private void ConnecSqlite()
        {
            //HangHoaDb.Open();
            string query = "select * from HangHoa";
            SQLiteCommand cmd = new SQLiteCommand(query, HangHoaDb);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);            
            adapter.Fill(dt);
            //bunifuDataGridView1.DataSource = dt;
            loadDataGridview(dt);

        }

        private void loadDataGridview(DataTable dt)
        {
            List<Product> lst = ConvertData(dt);
            foreach(Product p in lst)
            {
                int i = bunifuDataGridView1.RowCount;
                bunifuDataGridView1.Rows.Add(new object[] {true, i, p.MaHang, p.TenHang, p.SoLuong, p.DonVi, p.GiaThanh });
            }
        }

        private List<Product> ConvertData(DataTable dt)
        {
            List<Product> lst_Product = new List<Product>();
            if(dt.Rows.Count > 0)
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
    }
}
