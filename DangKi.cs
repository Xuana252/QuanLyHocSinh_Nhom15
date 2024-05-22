using MetroFramework.Controls;
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
    public partial class DangKi : MetroFramework.Forms.MetroForm
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Sự kiên khi form đăng kí xuất hiện
        private void DangKi_Shown(object sender, EventArgs e)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            //Cập nhật danh sách môn học
            db.sqlCmd.CommandText = "SELECT TenMonHoc FROM MONHOC";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            DangKiMonHocComboBox.Items.Clear();

            while (db.reader.Read())
            { 
                DangKiMonHocComboBox.Items.Add(db.reader.GetString(0));
            }
            db.reader.Close();

            //Cập nhật danh sách vai trò
            db.sqlCmd.CommandText = "SELECT TenVaiTro FROM VAITRO";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            DangKiVaiTroComboBox.Items.Clear();

            while (db.reader.Read())
            {
                DangKiVaiTroComboBox.Items.Add(db.reader.GetString(0));
            }
            db.reader.Close();

            //Cập nhật ID giáo viên trong form
            db.sqlCmd.CommandText = "SELECT  RIGHT('00000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idGiaoVien, 5) AS INT)) + 1 FROM GIAOVIEN), 1) AS VARCHAR(5)), 5) AS result;";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            { 
                DangKiIDTextBox.Text = db.reader.GetString(0);
            }
            db.reader.Close();

            //Chọn môn học và vai trò mặc định và ngày sinh mặc định cho tài khoản giáo viên
            DangKiMonHocComboBox.SelectedIndex=0;
            DangKiVaiTroComboBox.SelectedIndex = 1;
            DangKiNgaySinhDateTime1.Value = new DateTime(2000, 01, 01);
        }

        private void DangKiButton_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có trường nào bị bỏ trống không
            if(DangKiUsernameTextBox.Text.Length == 0||DangKiPasswordTextBox1.Text.Length == 0|| DangKiPasswordTextBox2.Text.Length == 0||DangKiHoVaTenTextBox.Text.Length == 0||DangKiDiaChiTextBox.Text.Length == 0) 
            {
                Error.GetInstance().Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if(DangKiPasswordTextBox2.Text != DangKiPasswordTextBox1.Text)//kiểm tra mật khẩu nhập lại có trùng khớp không
            {
                Error.GetInstance().Show("Mật khẩu không trùng khớp vui lòng kiểm tra lại");
                DangKiPasswordTextBox1.Clear();
                DangKiPasswordTextBox2.Clear();
            }
            else
            {
                SQLConnect db = SQLConnect.GetInstance();
                db.Open();
                db.sqlCmd.CommandType = CommandType.Text;

                string idGiaoVien = DangKiIDTextBox.Text;
                string tenTaiKhoan = DangKiUsernameTextBox.Text;
                string password = DangKiPasswordTextBox1.Text;
                string hoTen = DangKiHoVaTenTextBox.Text;
                string diaChi = DangKiDiaChiTextBox.Text;
                string ngaySinh = DangKiNgaySinhDateTime1.Text;
                string vaiTro = DangKiVaiTroComboBox.Text;
                string monHoc = DangKiMonHocComboBox.Text;


                db.sqlCmd.CommandText = "SET DATEFORMAT DMY; " +
                           "DECLARE @idMonHoc CHAR(2), @idVaiTro CHAR(2), @idTaiKhoan VARCHAR(5);" +
                           "SELECT @idMonHoc = idMonHoc FROM MONHOC WHERE TenMonHoc = @monHoc;" +
                           "SELECT @idVaiTro = idVaiTro FROM VAITRO WHERE TenVaiTro = @vaiTro;" +
                           "SELECT @idTaiKhoan = RIGHT(YEAR(GETDATE()), 2) + " +
                           "RIGHT('000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idTaiKhoan, 5) AS INT)) + 1 FROM TAIKHOAN " +
                           "WHERE idTaiKhoan LIKE RIGHT(YEAR(GETDATE()), 2) + '%'), 1) AS VARCHAR(5)), 5);" +
                           "INSERT INTO GIAOVIEN VALUES (@idGiaoVien, @hoTen, @ngaySinh, @diaChi, @idMonHoc);" +
                           "INSERT INTO TAIKHOAN VALUES (@idTaiKhoan, @idGiaoVien, @tenTaiKhoan, @password, @idVaiTro);";

                
                db.sqlCmd.Parameters.AddWithValue("@monHoc", monHoc);
                db.sqlCmd.Parameters.AddWithValue("@vaiTro", vaiTro);
                db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGiaoVien);
                db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTen);
                db.sqlCmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                db.sqlCmd.Parameters.AddWithValue("@diaChi", diaChi);
                db.sqlCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                db.sqlCmd.Parameters.AddWithValue("@password", password);


                db.sqlCmd.Connection = db.sqlCon;

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch 
                {
                    Error.GetInstance().Show("xảy ra lỗi trong quá trình tạo tài khoản");    
                }

            }    

        }
    }
}
