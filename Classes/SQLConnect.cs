using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyHocSinh_Nhom15
{
    sealed class SQLConnect
    {
        //Singleton
        private static SQLConnect _instance;

        //Chuỗi kết nối
        string strCon = @"Data Source=studentmanagement.c3kuwokswvvn.ap-southeast-2.rds.amazonaws.com,1433;Initial Catalog=StudentManagement;User ID=admin;Password=12345678;Encrypt=False;TrustServerCertificate=True";
        
        //Đối tượng kết nối
        public SqlConnection sqlCon = null; 
        
        //Command
        public SqlCommand sqlCmd = null;
        
        //Đầu đọc dữ liệu
        public SqlDataReader reader = null;

        //Hàm gọi đối tượng singleton
        public static SQLConnect GetInstance() 
        {
            if(_instance == null) 
                _instance = new SQLConnect();
            return _instance;
        }

        //Hàm mở kết nối
        public void Open()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == System.Data.ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                sqlCmd = new SqlCommand();
            }
            catch (Exception ex) 
            {
                Error.GetInstance().Show(ex.Message);
            }
            
        }
    }
}
