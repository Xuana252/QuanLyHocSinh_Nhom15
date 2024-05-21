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
        private static SQLConnect _instance;
        string strCon = @"Data Source=studentmanagement.c3kuwokswvvn.ap-southeast-2.rds.amazonaws.com,1433;Initial Catalog=StudentManagement;User ID=admin;Password=12345678;Encrypt=False;TrustServerCertificate=True";
        public SqlConnection sqlCon = null; 
        public SqlCommand sqlCmd = null;
        public SqlDataReader reader = null;
        public static SQLConnect GetInstance() 
        {
            if(_instance == null) 
                _instance = new SQLConnect();
            return _instance;
        }

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
                    if(sqlCon.State==System.Data.ConnectionState.Open) 
                    {
                        Error._instsance.Show("thanh cong");
                    }
                }

                sqlCmd = new SqlCommand();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
