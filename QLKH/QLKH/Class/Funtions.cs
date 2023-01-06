using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace QLKH.Class
{
    class Funtions
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
            SQLiteConnection Con = new SQLiteConnection("data source=C:\\Users\\LAI HOP QUANG\\Desktop\\sqlite\\QLKH.db");           
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand sQLiteCommand = Con.CreateCommand();
            sQLiteCommand.CommandText = "SELECT * FROM HangHoa";

            sQLiteDataReader = sQLiteCommand.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                Console.WriteLine(sQLiteDataReader.GetString(0));
            }          
            //Mở kết nối
            //Kiểm tra kết nối
            if (Con.State != ConnectionState.Open)
            {

                MessageBox.Show("Kết nối thành công");
            }

            else
            {
                MessageBox.Show("Không thể kết nối với dữ liệu");
            }

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
    }
}
