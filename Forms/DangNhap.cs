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

        //Sự kiện khi bấm nút X 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Sự kiện khi bấm nút đăng nhập
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (TaiKhoan.GetInstance().DangNhap(UserNameTextBox.Text.Trim(), PasswordTextBox.Text.Trim()))
            {
                //nếu đăng nhập thành công thì gọi cửa sổ app
                App app = new App();
                this.Hide();
                app.Show();
            }
            else
            {
                //nếu thất bại thì báo lỗi và làm trống form
                Error.GetInstance().Show("thông tin tên tài khoản hoặc mật khẩu không đúng");
                UserNameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
            }
            //App app = new App();
            //   this.Hide();
            //   app.Show();
        }


    }
}
