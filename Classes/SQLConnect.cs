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
    public sealed class SQLConnect
    {
        //Singleton
        private static SQLConnect _instance;

        //Chuỗi kết nối
        public string strCon = @"Data Source=studentmanagement.c3kuwokswvvn.ap-southeast-2.rds.amazonaws.com,1433;Initial Catalog=StudentManagement;User ID=admin;Password=12345678;Encrypt=False;TrustServerCertificate=True";
                               //@"Data Source=TAOCOMPUTER\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True;Encrypt=False";

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
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandType = CommandType.Text;
            }
            catch (SqlException sqlEx)
            {
                // Handle SqlException specifically
                ThongBaoForm.GetInstance().LogError("Lỗi không thể kết nối tới cơ sở dữ liệu. Vui lòng liên hệ ban quản lý hoặc kiểm tra kết nối trên máy tính của bạn.\n" + sqlEx.Message);
            }
            catch(Exception ex) 
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi: "+ ex.Message);
            }
            finally
            {
                if (sqlCmd == null)
                {
                    sqlCon?.Close();
                    Environment.Exit(1);
                }
            }

        }
        //Hàm đóng kết nối
        public void Close()
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
            {
                sqlCon.Close();
                sqlCon.Dispose(); // Dispose SqlConnection to release resources
                sqlCon = null;
            }
        }
    }
}
