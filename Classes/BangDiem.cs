using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class BangDiem
    {
        //các thuộc tính chung
        private static BangDiem _instance;
        public string idBangDiem;
        public string idLop;
        public string tenLop;
        public string idMonHoc;
        public string tenMonHoc;
        public int HocKy;
        public int NamHoc;

        //các thuộc tính phù hợp cho tab Tổng kết
        public string loaiTongKet;
        public string hocKiTongKet;
        public decimal namTongKet;
        public string tenMonTongKet;


        public static BangDiem GetInstance()
        {
            if (_instance == null)
                _instance = new BangDiem();
            return _instance;
        }

        public List<ListViewItem> LayDanhSach(string tenlop, string tenmon,string hocky, decimal namhoc)
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "DECLARE @idmonhoc CHAR(2), @idlop CHAR(3); " +
                            "SELECT @idmonhoc = idMonHoc FROM MONHOC WHERE TenMonHoc = @tenmon; " +
                            "SELECT @idlop = idLop FROM LOPHOC WHERE TenLop = @tenlop; " +
                            "SELECT HOCSINH.idHocSinh, HoTen, Diem15p, Diem1Tiet, diemtb " +
                            "FROM HOCSINH " +
                            "JOIN BANGDIEM ON HOCSINH.idlop = BANGDIEM.idlop " +
                            "AND BANGDIEM.idMonHoc = @idmonhoc AND BANGDIEM.HocKy = @hocky AND BANGDIEM.NamHoc = @namhoc " +
                            "LEFT JOIN CHITIETBANGDIEM ON CHITIETBANGDIEM.idhocsinh = HOCSINH.idHocSinh and CHITIETBANGDIEM.idBangDiem=BANGDIEM.idBangDiem " +                            
                            "WHERE HOCSINH.idLop = @idlop;";
            db.sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);
            db.sqlCmd.Parameters.AddWithValue("@hocky", hocky);
            db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);



            db.reader = db.sqlCmd.ExecuteReader();
            int stt = 1;
            while (db.reader.Read())
            {
                string id = db.reader.GetString(0);
                string hoten = db.reader.GetString(1);
                decimal diem15p = !db.reader.IsDBNull(2) ? db.reader.GetDecimal(2) : 0;
                decimal diem1t = !db.reader.IsDBNull(3) ? db.reader.GetDecimal(3) : 0;
                decimal diemtb = !db.reader.IsDBNull(4) ? db.reader.GetDecimal(4) : 0;


                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(hoten);
                item.SubItems.Add(diem15p.ToString());
                item.SubItems.Add(diem1t.ToString());
                item.SubItems.Add(diemtb.ToString());
                item.SubItems.Add(id);

                itemList.Add(item);
                stt++;
            }
            db.reader.Close();
            db.Close();
            return itemList;
        }

        public void XoaBangDiem(string tenlop, string tenmon, string hocky, decimal namhoc)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "declare @idmonhoc char(2), @idlop char(3)" +
                                    "select @idmonhoc = idMonHoc from MONHOC where TenMonHoc = @tenmon;" +
                                    "select @idlop = idLop from LOPHOC where TenLop = @tenlop;" +
                                    "delete from BANGDIEM where idMonHoc=@idmonhoc and idLop=@idlop and HocKy=@hocky and NamHoc=@namhoc";

            db.sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);
            db.sqlCmd.Parameters.AddWithValue("@hocky", hocky);
            db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
                ThongBaoForm.GetInstance().Inform("Xóa bảng điểm thành công");
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
        }

        public void ThemBangDiem(string tenlop, string tenmon, string hocky, decimal namhoc)
        {
            
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

           
            db.sqlCmd.CommandText = "declare @idbangdiem char(5) ,@idmonhoc char(2), @idlop char(3)" +
                                    "select @idmonhoc = idMonHoc from MONHOC where TenMonHoc = @tenmon;" +
                                    "select @idlop = idLop from LOPHOC where TenLop = @tenlop;" +
                                    "select @idbangdiem = RIGHT('00000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idbangdiem, 5) AS INT)) + 1 FROM BANGDIEM), 1) AS VARCHAR(5)), 5)" +
                                    "insert into BANGDIEM values(@idbangdiem, @idlop, @idmonhoc,@hocky,@namhoc)";

            db.sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);
            db.sqlCmd.Parameters.AddWithValue("@hocky", hocky);
            db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);



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

        public string getIdBangDiem(string tenlop, string tenmon, string hocky, decimal namhoc)
        {
            string id="" ;
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "declare @idmonhoc char(2), @idlop char(3);" +
                                "select @idmonhoc = idMonHoc from MONHOC where TenMonHoc = @tenmon;" +
                                "select @idlop = idLop from LOPHOC where TenLop = @tenlop;" +
                                "select idbangdiem " +
                                "from BANGDIEM " +
                                "where hocky = @hocky and namhoc = @namhoc and idlop = @idlop and idmonhoc = @idmonhoc;";

            db.sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);
            db.sqlCmd.Parameters.AddWithValue("@hocky", hocky);
            db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);

            db.sqlCmd.Connection= db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();
            while(db.reader.Read())
            {
                id=db.reader.GetString(0);
            }
            db.reader.Close();
            db.Close();
            return id;
        }

    }

}
