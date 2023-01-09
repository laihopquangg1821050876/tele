using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
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
            
            ThemDGV.Rows.Add(true ,  txtMaHang.Text, txtTenHang.Text, Convert.ToInt32(txtSoLuong.Text), txtDonVi.Text, float.Parse(txtGiaThanh.Text));
            ThemDGV.DataSource = dataTable;
           
        }

        private void ThemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
