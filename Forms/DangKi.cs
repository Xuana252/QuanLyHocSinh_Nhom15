using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    public partial class DangKi : MetroFramework.Forms.MetroForm
    {
        public GiaoVienForm giaoVien;
        public DangKi()
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TaiKhoan.GetInstance().flagSua = false;
            Close();
            
        }

        //Sự kện xảy ra khi bấm nút đăng kí
        private void DangKiButton_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có trường nào bị bỏ trống không
            if(!DienDayDu()) 
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng nhập đầy đủ thông tin");
            }
            else if(DangKiPasswordTextBox2.Text != DangKiPasswordTextBox1.Text)//kiểm tra mật khẩu nhập lại có trùng khớp không
            {
                ThongBaoForm.GetInstance().LogError("Mật khẩu không trùng khớp vui lòng kiểm tra lại");
                DangKiPasswordTextBox1.Clear();
                DangKiPasswordTextBox2.Clear();
            }
            else if(DangKiPasswordTextBox1.Text.Length<8)//kiểm tra độ dài mật khẩu phù hợp
            {
                ThongBaoForm.GetInstance().LogError("Mật khẩu phải dài hơn 8 kí tự");
                DangKiPasswordTextBox1.Clear();
                DangKiPasswordTextBox2.Clear();
            }
            else if(DateTime.Now.Year - DangKiNgaySinhDateTime1.Value.Year<22)//Kiểm tra độ tuổi giáo viên ít nhất là 22
            {
                ThongBaoForm.GetInstance().LogError("Đảm bảo tuổi của giáo viên phải lớn hơn 22");
                DangKiNgaySinhDateTime1.Value = DateTime.Now;
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

                if (!TaiKhoan.GetInstance().TonTai(tenTaiKhoan,matKhau)||TaiKhoan.GetInstance().flagSua)
                {
                    if(!TaiKhoan.GetInstance().flagSua)
                    {
                        GiaoVien.GetInstance().ThemGiaoVien(idGiaoVien, hoTen, ngaySinh, diaChi, monHoc, gioiTinh);
                        TaiKhoan.GetInstance().DangKiTaiKhoan(idGiaoVien, tenTaiKhoan, matKhau, vaiTro);
                    }
                    else
                    {
                        GiaoVien.GetInstance().ChinhSuaGiaoVien(idGiaoVien, hoTen, ngaySinh, diaChi, monHoc, gioiTinh);
                        TaiKhoan.GetInstance().ChinhSuaTaiKhoan(idGiaoVien, tenTaiKhoan, matKhau, vaiTro);
                        
                        giaoVien.GiaoVienForm_VisibleChanged(sender, e);
                    }
                    TaiKhoan.GetInstance().flagSua = false;
                    this.Close();
                }
                else
                    ThongBaoForm.GetInstance().LogError("Tên tài khoản-mật khẩu đã tồn tại trong hệ thống vui lòng chọn tên tài khoản hoặc mật khẩu khác");

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
                foreach (ListViewItem monHoc in MonHoc.GetInstance().LayDanhSach())
                {
                    DangKiMonHocComboBox.Items.Add(monHoc.SubItems[1].Text);
                }

                //Cập nhật danh sách vai trò
                DangKiVaiTroComboBox.Items.Clear();
                foreach (ListViewItem vaiTro in VaiTro.GetInstance().LayDanhSach())
                {
                    DangKiVaiTroComboBox.Items.Add(vaiTro.SubItems[1].Text);
                }
                //Cập nhật các thông tin khác tùy thuộc vào chức năng của form khi được gọi
                if (TaiKhoan.GetInstance().flagSua==false)//Đăng kí mới
                {
                    DangKiButton.Text = "Đăng kí";
                    //Cập nhật ID giáo viên trong form
                    GiaoVien.GetInstance().idGiaoVien = GiaoVien.GetInstance().LayIdDangKi();
                    DangKiIDTextBox.Text = GiaoVien.GetInstance().idGiaoVien;
                    //Chọn môn học, vai trò, ngày sinh, giới tính mặc định cho tài khoản giáo viên
                    DangKiMonHocComboBox.SelectedIndex = 0;
                    DangKiVaiTroComboBox.SelectedIndex = 1;
                    DangKiNgaySinhDateTime1.Value = new DateTime(2000, 01, 01);

                }
                else//Chỉnh sửa
                {
                    DangKiButton.Text = "Sửa";
                    DangKiUsernameTextBox.Text = TaiKhoan.GetInstance().tenTaiKhoanSua;
                    DangKiPasswordTextBox1.Text = DangKiPasswordTextBox2.Text = TaiKhoan.GetInstance().matKhauSua;
                    DangKiVaiTroComboBox.Text = TaiKhoan.GetInstance().vaiTroSua;
                    DangKiHoVaTenTextBox.Text = GiaoVien.GetInstance().hoTenSua;
                    DangKiNgaySinhDateTime1.Value = DateTime.ParseExact(GiaoVien.GetInstance().ngaySinhSua, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DangKiDiaChiTextBox.Text = GiaoVien.GetInstance().diaChiSua;
                    DangKiMonHocComboBox.Text = GiaoVien.GetInstance().monHocSua;
                    GioiTinhGroupBox.Controls.OfType<MetroRadioButton>().First(r => r.Tag != null && r.Tag.ToString() == GiaoVien.GetInstance().gioiTinhSua).Checked = true;
                    DangKiIDTextBox.Text = GiaoVien.GetInstance().idGiaoVienSua;
                }
               
                
               
               
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
