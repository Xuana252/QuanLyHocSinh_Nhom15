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
        public decimal Diem15p;
        public decimal Diem1Tiet;
        public decimal DiemTB;

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
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
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
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
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
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
        }

        public decimal TinhDiemTBHocKy(string idhocsinh,decimal namhoc,string hocky)
        {
            decimal diemtb = 0;
            int i = 0;
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "select diemtb from CHITIETBANGDIEM, BANGDIEM where CHITIETBANGDIEM.idbangdiem = BANGDIEM.idbangdiem and hocky = @hocky and namhoc = @namhoc and idhocsinh=@idhocsinh ";
            db.sqlCmd.Parameters.AddWithValue("@idhocsinh", idhocsinh);
            db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);
            db.sqlCmd.Parameters.AddWithValue("@hocky", hocky);

            db.sqlCmd.Connection = db.sqlCon;
            db.reader = db.sqlCmd.ExecuteReader();
            while (db.reader.Read())
            {
                diemtb=diemtb+db.reader.GetDecimal(0);
                i++;
            }
            db.reader.Close();
            if (i== 0)
            {
                return 0;
            }
            diemtb = diemtb / i;
            db.Close();
            return diemtb;


        }
    }
}
