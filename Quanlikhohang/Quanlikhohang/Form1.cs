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

namespace Quanlikhohang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source= C:\\Users\\LAI HOP QUANG\\Desktop\\sqlite\\QLKH.db"); 
            try
            {
                conn.Open();    
            }
            catch
            {
                Console.WriteLine("Chưa kết nối DB");
            }
        }
    }
}
