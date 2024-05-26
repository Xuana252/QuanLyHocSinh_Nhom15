using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    public partial class DangNhap : MetroFramework.Forms.MetroForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        { 
            //Kiểm tra thông tin đăng nhập trên database
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            string username = UserNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            db.sqlCmd.CommandText = "SELECT idTaiKhoan,TAIKHOAN.idGiaoVien,TenTaiKhoan,MatKhau,VAITRO.idVaiTro,HoTen,CONVERT(VARCHAR(10),NgaySinh,103),MONHOC.idMonHoc,TenMonHoc,TenVaiTro FROM TAIKHOAN JOIN GIAOVIEN ON TAIKHOAN.idGiaoVien = GIAOVIEN.idGiaoVien JOIN MONHOC ON MONHOC.idMonHoc= GIAOVIEN.idMonHoc JOIN VAITRO ON VAITRO.idVaiTro = TAIKHOAN.idVaiTro  WHERE TenTaiKhoan='" + username+"' AND MatKhau='"+password+"'";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if(db.reader.Read())//nếu thành công
            {
                //cập nhật thông tin tài khoản dựa vào kết quả trả về
                TaiKhoan user =TaiKhoan.GetInstance();
                user.idTaiKhoan=db.reader.GetString(0);
                user.idGiaoVien=db.reader.GetString(1);
                user.tenTaiKhoan =db.reader.GetString(2);
                user.matKhau=db.reader.GetString(3);
                user.idVaiTro=db.reader.GetString(4);
                user.hoTen=db.reader.GetString(5);
                user.ngaySinh=db.reader.GetString(6);
                user.idMonHoc=db.reader.GetString(7);
                user.monHoc=db.reader.GetString(8);
                user.vaiTro=db.reader.GetString(9);
                //Giấu form đăng nhập và hiện App
                Hide();
                db.reader.Close();
                App app = new App();
                app.Show();
            }
            else//nếu thất bại
            {
                Error.GetInstance().Show("thông tin tên tài khoản hoặc mật khẩu không đúng");
                UserNameTextBox.Clear();
                PasswordTextBox.Clear();
                db.reader.Close();
            }
            
        }


    }
}
