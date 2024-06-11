using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyHocSinh_Nhom15
{
    public partial class HocSinhForm : MetroFramework.Forms.MetroForm
    {
        App mainApp;
        HocSinh hocSinh = HocSinh.GetInstance();
        public HocSinhForm(App MainApp)
        {
            InitializeComponent();
            mainApp = MainApp;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Sự kiện xảy ra khi bấm nút ok để thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if(!DienDayDu())
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng nhập đầy đủ thông tin");
            }
            else 
            {
                //CODE MỚI
                string hoTen = HocSinhHoTenTextBox.Text;
                string gioiTinh = GioiTinhGroupBox.Controls.OfType<MetroRadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
                string diaChi = HocSinhDiaChiTextBox.Text;
                string ngaySinh = HocSinhNgaySinhDateTime.Text;
                string email = HocSinhEmailTextBox.Text;
                if (hocSinh.flagSua)
                    hocSinh.SuaHocSinh(hoTen, gioiTinh, diaChi, ngaySinh, email);
                else
                    hocSinh.ThemHocSinh(hoTen, gioiTinh, diaChi, ngaySinh, email);

                mainApp.LoadTabTiepNhan("");
                this.Hide();
                

            }
        }

        //hàm clearform
        void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MetroTextBox || control is RichTextBox || control is MetroDateTime)
                {
                    control.Text = null;
                }
            }
        }

        //hàm kiểm tra điền đầy đủ
        bool DienDayDu()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Text.Length == 0&&!(control is System.Windows.Forms.GroupBox))
                    return false;
            }
            return true;
        }

        //Sự kiện xảy ra khi form xuất hiện
        private void HocSinhForm_VisibleChanged(object sender, EventArgs e)
        {
            if (hocSinh.flagSua)
            {
                HocSinhHoTenTextBox.Text = hocSinh.HoTen;
                HocSinhDiaChiTextBox.Text = hocSinh.DiaChi;
                HocSinhEmailTextBox.Text = hocSinh.Email;
                GioiTinhGroupBox.Controls.OfType<MetroRadioButton>().First(r => r.Tag != null && r.Tag.ToString() == hocSinh.GioiTinh).Checked = true;
                HocSinhNgaySinhDateTime.Value = DateTime.ParseExact(hocSinh.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            else
                ClearForm();
        }

    }
}
