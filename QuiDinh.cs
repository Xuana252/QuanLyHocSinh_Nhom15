using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Nhom15
{
    sealed class QuiDinh
    {
        private static QuiDinh _instance;

        public int SiSoToiDa;
        public int TuoiToiThieu;
        public int TuoiToiDa;
        public decimal DiemQuaMon;

        public static QuiDinh GetInstance()
        {
            if( _instance == null ) 
                _instance = new QuiDinh();
            return _instance;
        }

        //Hamf thay đổi sỉ số tối đa
        public void ThayDoiSiSoToiDa(int SiSo)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET SiSoToiDa = @SiSoToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@SiSoToiDa", SiSo);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
        }
        
        //Hàm thay đổi tuổi tối thiểu
        public void ThayDoiTuoiToiThieu(int TuoiToiThieu)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiThieu = @TuoiToiThieu;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiThieu", TuoiToiThieu);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
        }

        //Hàm thay đổi tuổi tối đa
        public void ThayDoiTuoiToiDa(int  TuoiToiDa) 
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiDa = @TuoiToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiDa", TuoiToiDa);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
        }
        
        //Hàm Load tuổi qui định
        public void LoadTuoiQuiDinh()
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT TuoiToiThieu, TuoiToiDa FROM QUIDINH";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                TuoiToiThieu = db.reader.GetInt32(0);
                TuoiToiDa = db.reader.GetInt32(1);
            }
            else
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình lấy dữ liệu tuổi qui định từ hệ thống\n");
            }
            db.reader.Close();
        }


        public void ThayDoiDiemQuaMon(decimal DiemQuaMon)
        {

        }

    }
}
