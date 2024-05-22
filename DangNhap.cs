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
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            string username = UserNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            db.sqlCmd.CommandText = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenTaiKhoan='"+username+"' AND MatKhau='"+password+"'";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if(db.reader.Read())
            {
                int check = db.reader.GetInt32(0);
                if(check == 0) 
                {
                    Error.GetInstance().Show("thông tin tên tài khoản hoặc mật khẩu không đúng");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
                }
                else
                {
                    Hide();
                    App app = new App();
                    app.Show();
                }
            }
            db.reader.Close();
        }
    }
}
