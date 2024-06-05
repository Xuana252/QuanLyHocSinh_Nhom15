    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class GiaoVien
    {
        private static GiaoVien _instance;
        public string idGiaoVien;
        public string HoTen;
        public string NgaySinh;
        public string DiaChi;
        public string idMonhoc;
        public string GioiTinh;

        public static GiaoVien GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GiaoVien();
            }
            return _instance;
        }
        //Hàm lấy idGiaoVien cho tài khoản đăng kí
        public string LayIdDangKi()
        {
            string id = "";
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT  RIGHT('00000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idGiaoVien, 5) AS INT)) + 1 FROM GIAOVIEN), 1) AS VARCHAR(5)), 5) AS result;";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                id = db.reader.GetString(0);
            }
            db.reader.Close();
            return id;
        }
        //Hàm thêm giáo viên 
        public void ThemGiaoVien(string idGiaoVien,string hoTen,string ngaySinh,string diaChi,string monHoc,string gioiTinh)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SET DATEFORMAT DMY; " +
                       "DECLARE @idMonHoc CHAR(2);" +
                       "SELECT @idMonHoc = idMonHoc FROM MONHOC WHERE TenMonHoc = @monHoc;"+
                       "INSERT INTO GIAOVIEN VALUES (@idGiaoVien, @hoTen, @ngaySinh, @diaChi, @idMonHoc,@gioiTinh);";


            db.sqlCmd.Parameters.AddWithValue("@monHoc", monHoc);
            db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGiaoVien);
            db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTen);
            db.sqlCmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            db.sqlCmd.Parameters.AddWithValue("@diaChi", diaChi);
            db.sqlCmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);


            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thêm giáo viên mới:\n"+ex.Message);
            }

        }
        //Hàm lấy danh sách giáo viên
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT idGiaoVien,HoTen,CONVERT(VARCHAR(10),NgaySinh,103),DiaChi,idMonHoc,GioiTinh FROM GIAOVIEN";


            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idGiaoVien = db.reader.GetString(0);
                string hoTen = db.reader.GetString(1);
                string ngaySinh = db.reader.GetString(2);
                string diaChi = db.reader.GetString(3);
                string idMonHoc = db.reader.GetString(4);
                string gioiTinh = db.reader.GetString(5);

                ListViewItem item = new ListViewItem();
                item.Text = (idGiaoVien);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(ngaySinh);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(idMonHoc);
                item.SubItems.Add(gioiTinh);

                itemList.Add(item);

            }
            db.reader.Close();
            return itemList;
        }

    }
}
