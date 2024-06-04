using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class ChiTietBangDiem
    {
        private static ChiTietBangDiem _instance;
        public string idBangDiem;
        public string idHocSinh;
        public float Diem15p;
        public float Diem1Tiet;
        public float DiemTB;

        public static ChiTietBangDiem GetInstance()
        {
            if (_instance == null)
                _instance = new ChiTietBangDiem();
            return _instance;
        }

        public void ThemDiem(string idbangdiem,string idhocsinh,decimal diem15p,decimal diem1t, decimal diemTB)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "INSERT INTO CHITIETBANGDIEM values(@idbangdiem,@idhocsinh,@diem15p,@diem1t,@diemtb)";

            db.sqlCmd.Parameters.AddWithValue("@idbangdiem", idbangdiem);
            db.sqlCmd.Parameters.AddWithValue("@idhocsinh", idhocsinh);
            db.sqlCmd.Parameters.AddWithValue("@diem15p", diem15p);
            db.sqlCmd.Parameters.AddWithValue("@diem1t", diem1t);
            db.sqlCmd.Parameters.AddWithValue("@diemtb", diemTB);
            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message);
            }
        }

        public void SuaDiem(string idbangdiem, string idhocsinh, decimal diem15p, decimal diem1t, decimal diemTB)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "update CHITIETBANGDIEM set diem15p = @diem15p, Diem1Tiet = @diem1t, DiemTB = @diemtb " +
                                    "where idbangdiem = @idbangdiem and idhocsinh = @idhocsinh";

            db.sqlCmd.Parameters.AddWithValue("@idbangdiem", idbangdiem);
            db.sqlCmd.Parameters.AddWithValue("@idhocsinh", idhocsinh);
            db.sqlCmd.Parameters.AddWithValue("@diem15p", diem15p);
            db.sqlCmd.Parameters.AddWithValue("@diem1t", diem1t);
            db.sqlCmd.Parameters.AddWithValue("@diemtb", diemTB);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message);
            }
        }

        public void XoaDiem(string idbangdiem,string idhocsinh)
        {
            SQLConnect db=SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "delete from CHITIETBANGDIEM where idbangdiem=@idbangdiem and idhocsinh=@idhocsinh";

            db.sqlCmd.Parameters.AddWithValue("@idbangdiem", idbangdiem);
            db.sqlCmd.Parameters.AddWithValue("@idhocsinh", idhocsinh);
            db.sqlCmd.Connection= db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message);
            }
        }
    }
}
