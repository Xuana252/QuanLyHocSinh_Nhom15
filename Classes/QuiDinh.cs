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
            

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET SiSoToiDa = @SiSoToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@SiSoToiDa", SiSo);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
            db.Close();
        }
        
        //Hàm thay đổi tuổi tối thiểu
        public void ThayDoiTuoiToiThieu(int TuoiToiThieu)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiThieu = @TuoiToiThieu;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiThieu", TuoiToiThieu);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
            db.Close();
        }

        //Hàm thay đổi tuổi tối đa
        public void ThayDoiTuoiToiDa(int  TuoiToiDa) 
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiDa = @TuoiToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiDa", TuoiToiDa);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
            db.Close();
        }

        //Hàm thay đổi điểm qua môn
        public void ThayDoiDiemQuaMon(decimal DiemQuaMon)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET DiemQuaMon = @DiemQuaMon;";

            db.sqlCmd.Parameters.AddWithValue("@DiemQuaMon", DiemQuaMon);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
            db.Close();
        }

        //Hàm Load tuổi qui định
        public void LoadTuoiQuiDinh()
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "SELECT TuoiToiThieu, TuoiToiDa FROM QUIDINH";



            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                TuoiToiThieu = db.reader.GetInt32(0);
                TuoiToiDa = db.reader.GetInt32(1);
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình lấy dữ liệu tuổi qui định từ hệ thống\n");
            }
            db.reader.Close();
            db.Close();
        }

        //Hàm Load sỉ số tối đa
        public void LoadSiSoToiDa()
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "SELECT SiSoToiDa FROM QUIDINH";



            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                SiSoToiDa = db.reader.GetInt32(0);
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình lấy dữ liệu sỉ số tối đa từ hệ thống\n");
            }
            db.reader.Close();
            db.Close();
        }

        //Hàm load điểm qua môn 
        public void LoadDiemQuaMon()
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "SELECT DiemQuaMon FROM QUIDINH";



            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                DiemQuaMon = db.reader.GetDecimal(0);
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi trong quá trình lấy dữ liệu điểm qua môn qui định từ hệ thống\n");
            }
            db.reader.Close();
            db.Close();
        }

    }
}
