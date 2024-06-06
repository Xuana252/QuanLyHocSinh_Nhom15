using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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


        private void DangKiButton_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có trường nào bị bỏ trống không
            if(!DienDayDu()) 
            {
                Error.GetInstance().Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if(DangKiPasswordTextBox2.Text != DangKiPasswordTextBox1.Text)//kiểm tra mật khẩu nhập lại có trùng khớp không
            {
                Error.GetInstance().Show("Mật khẩu không trùng khớp vui lòng kiểm tra lại");
                DangKiPasswordTextBox1.Clear();
                DangKiPasswordTextBox2.Clear();
            }
            else if(DangKiPasswordTextBox1.Text.Length<8)//kiểm tra độ dài mật khẩu phù hợp
            {
                Error.GetInstance().Show("Mật khẩu phải dài hơn 8 kí tự");
                DangKiPasswordTextBox1.Clear();
                DangKiPasswordTextBox2.Clear();
            }
            else
            {

                string idGiaoVien = DangKiIDTextBox.Text;
                string tenTaiKhoan = DangKiUsernameTextBox.Text;
                string matKhau = DangKiPasswordTextBox1.Text;
                string hoTen = DangKiHoVaTenTextBox.Text;
                string diaChi = DangKiDiaChiTextBox.Text;
                string ngaySinh = DangKiNgaySinhDateTime1.Text;
                string vaiTro = DangKiVaiTroComboBox.Text;
                string monHoc = DangKiMonHocComboBox.Text;
                string gioiTinh = GioiTinhGroupBox.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

                if (!TaiKhoan.GetInstance().TonTai(tenTaiKhoan,matKhau))
                {
                    GiaoVien.GetInstance().ThemGiaoVien(idGiaoVien, hoTen, ngaySinh, diaChi, monHoc,gioiTinh);
                    TaiKhoan.GetInstance().DangKiTaiKhoan(idGiaoVien, tenTaiKhoan, matKhau, vaiTro);
                    this.Hide();
                }
                else
                    Error.GetInstance().Show("Tên tài khoản-mật khẩu đã tồn tại trong hệ thống vui lòng chọn tên tài khoản hoặc mật khẩu khác");

            }    

        }

        //Sự kiện khi form xuất hiện hoặc biến mất
        private void DangKi_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                ClearForm();

                //Cập nhật danh sách môn học
                DangKiMonHocComboBox.Items.Clear();
                foreach(ListViewItem monHoc in MonHoc.GetInstance().LayDanhSach())
                {
                    DangKiMonHocComboBox.Items.Add(monHoc.SubItems[1].Text);
                }

                //Cập nhật danh sách vai trò
                DangKiVaiTroComboBox.Items.Clear();
                foreach (ListViewItem vaiTro in VaiTro.GetInstance().LayDanhSach())
                {
                    DangKiVaiTroComboBox.Items.Add(vaiTro.SubItems[1].Text);
                }
                //Cập nhật ID giáo viên trong form
                DangKiIDTextBox.Text=GiaoVien.GetInstance().LayIdDangKi();

                //Chọn môn học, vai trò, ngày sinh, giới tính mặc định cho tài khoản giáo viên
                DangKiMonHocComboBox.SelectedIndex = 0;
                DangKiVaiTroComboBox.SelectedIndex = 1;
                DangKiNgaySinhDateTime1.Value = new DateTime(2000, 01, 01);
            }
        }

        //hàm clearform
        void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if(control is MetroTextBox||control is RichTextBox|| control is MetroDateTime) 
                {
                    control.Text = null;
                }
            }
        }
        //hàm kiểm tra điền đầy đủ
        bool DienDayDu()
        {
            foreach (Control control in this.Controls )
            {
                if (control.Text.Length == 0 && !(control is System.Windows.Forms.GroupBox))
                    return false;
            }
            return true;
        }
    }
}
