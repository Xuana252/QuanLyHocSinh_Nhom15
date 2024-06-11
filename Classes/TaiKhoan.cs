using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class TaiKhoan
    {
        private static TaiKhoan _instance;
        public string idTaiKhoan;
        public string idGiaoVien;
        public string idMonHoc;
        public string idVaiTro;
        public string tenTaiKhoan;
        public string matKhau;
        public string hoTen;
        public string ngaySinh;
        public string monHoc;
        public string vaiTro;
        public string gioiTinh;
        public string diaChi;

        //các thuộc tính dùng để chỉnh sửa
        public string tenTaiKhoanSua;
        public string matKhauSua;
        public string vaiTroSua;

        public bool flagSua=false;

        public static TaiKhoan GetInstance()
        {
            if(_instance == null )
                _instance = new TaiKhoan();
            return _instance;
        }

        

        //Hàm lấy danh sách tài khoản trong hệ thống
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT * FROM TAIKHOAN";


            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idTaiKhoan = db.reader.GetString(0);
                string idGiaoVien = db.reader.GetString(1);
                string tenTaiKhoan = db.reader.GetString(2);
                string matKhau = db.reader.GetString(3);
                string idVaiTro = db.reader.GetString(4);

                ListViewItem item = new ListViewItem();
                item.Text = (idTaiKhoan);
                item.SubItems.Add(idGiaoVien);
                item.SubItems.Add(tenTaiKhoan);
                item.SubItems.Add(matKhau);
                item.SubItems.Add(idVaiTro);

                itemList.Add(item);

            }
            db.reader.Close();
            db.Close();
            return itemList;
        }

        //Hàm thêm tài khoản
        public void DangKiTaiKhoan(string idGiaoVien,string tenTaiKhoan, string mauKhau, string vaiTro)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;


            db.sqlCmd.CommandText = "DECLARE @idVaiTro CHAR(2), @idTaiKhoan CHAR(5);" +
                       "SELECT @idVaiTro = idVaiTro FROM VAITRO WHERE TenVaiTro = @vaiTro;" +
                       "SELECT @idTaiKhoan = RIGHT(YEAR(GETDATE()), 2) + " +
                       "RIGHT('000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idTaiKhoan, 3) AS INT)) + 1 FROM TAIKHOAN " +
                       "WHERE idTaiKhoan LIKE RIGHT(YEAR(GETDATE()), 2) + '%'), 1) AS VARCHAR(3)), 3);" +
                       "INSERT INTO TAIKHOAN VALUES (@idTaiKhoan, @idGiaoVien, @tenTaiKhoan, @password, @idVaiTro);";


            db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGiaoVien);
            db.sqlCmd.Parameters.AddWithValue("@vaiTro", vaiTro);
            db.sqlCmd.Parameters.AddWithValue("@password", mauKhau);
            db.sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);


            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
                ThongBaoForm.GetInstance().Inform("Đăng kí tài khoản thành công");
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi khi tạo tài khoản:\n"+ex.Message);
            }
            db.Close() ;
        }

        //Hàm kiểm tra tài khoản tồn tài trong hệ thống
        public bool TonTai(string tenTaiKhoan, string matKhau)
        {
            //Kiểm tra thông tin đăng nhập trên database
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT idTaiKhoan,TAIKHOAN.idGiaoVien,TenTaiKhoan,MatKhau,VAITRO.idVaiTro,HoTen,CONVERT(VARCHAR(10),NgaySinh,103),MONHOC.idMonHoc,TenMonHoc,TenVaiTro FROM TAIKHOAN JOIN GIAOVIEN ON TAIKHOAN.idGiaoVien = GIAOVIEN.idGiaoVien JOIN MONHOC ON MONHOC.idMonHoc= GIAOVIEN.idMonHoc JOIN VAITRO ON VAITRO.idVaiTro = TAIKHOAN.idVaiTro  WHERE TenTaiKhoan=@tenTaiKhoan AND MatKhau=@matKhau";

            db.sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
            db.sqlCmd.Parameters.AddWithValue("@matKhau", matKhau);

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())//nếu thành công
            {
                //cập nhật thông tin tài khoản dựa vào kết quả trả về
                db.reader.Close();
                db.Close();
                return true;
            }
            else//nếu thất bại
            {
                db.reader.Close();
                db.Close();
                return false;
            }
           
        }

        //Hàm kiểm tra đăng nhập
        public bool DangNhap(string tenTaiKhoan,string matKhau)
        {
            //Kiểm tra thông tin đăng nhập trên database
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT idTaiKhoan,TAIKHOAN.idGiaoVien,TenTaiKhoan,MatKhau,VAITRO.idVaiTro,HoTen,CONVERT(VARCHAR(10),NgaySinh,103),MONHOC.idMonHoc,TenMonHoc,TenVaiTro,GioiTinh,DiaChi FROM TAIKHOAN JOIN GIAOVIEN ON TAIKHOAN.idGiaoVien = GIAOVIEN.idGiaoVien JOIN MONHOC ON MONHOC.idMonHoc= GIAOVIEN.idMonHoc JOIN VAITRO ON VAITRO.idVaiTro = TAIKHOAN.idVaiTro  WHERE TenTaiKhoan=@tenTaiKhoan AND MatKhau=@matKhau";

            db.sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
            db.sqlCmd.Parameters.AddWithValue("@matKhau", matKhau);

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())//nếu thành công
            {
                //cập nhật thông tin tài khoản dựa vào kết quả trả về
                TaiKhoan user = TaiKhoan.GetInstance();
                user.idTaiKhoan = db.reader.GetString(0);
                user.idGiaoVien = db.reader.GetString(1);
                user.tenTaiKhoan = db.reader.GetString(2);
                user.matKhau = db.reader.GetString(3);
                user.idVaiTro = db.reader.GetString(4);
                user.hoTen = db.reader.GetString(5);
                user.ngaySinh = db.reader.GetString(6);
                user.idMonHoc = db.reader.GetString(7);
                user.monHoc = db.reader.GetString(8);
                user.vaiTro = db.reader.GetString(9);
                user.gioiTinh = db.reader.GetString(10);
                user.diaChi = db.reader.GetString(11);
                db.reader.Close();
                db.Close();
                return true;
            }
            else//nếu thất bại
            {
                db.reader.Close();
                db.Close();
                return false;
            }
        }

        //Hàm chỉnh sửa thông tin tài khoản
        public void ChinhSuaTaiKhoan(string idGiaoVien,string tenTaiKhoan,string matKhau,string vaiTro)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;


            db.sqlCmd.CommandText = "DECLARE @idVaiTro CHAR(2), @idTaiKhoan CHAR(5);" +
                       "SELECT @idVaiTro = idVaiTro FROM VAITRO WHERE TenVaiTro = @vaiTro;" +
                       "UPDATE TAIKHOAN SET TenTaiKhoan = @tenTaiKhoan,MatKhau = @password, idVaiTro = @idVaiTro WHERE idGiaoVien = @idGiaoVien";


            db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGiaoVien);
            db.sqlCmd.Parameters.AddWithValue("@vaiTro", vaiTro);
            db.sqlCmd.Parameters.AddWithValue("@password", matKhau);
            db.sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);


            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
                ThongBaoForm.GetInstance().Inform("Chỉnh sửa tài khoản thành công");
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi khi tạo tài khoản:\n" + ex.Message);
            }
            db.Close();
        }
    }
}
