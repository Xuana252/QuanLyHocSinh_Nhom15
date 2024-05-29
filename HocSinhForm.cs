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
                Error.GetInstance().Show("Vui lòng nhập đầy đủ thông tin");
            }
            else 
            {
                //CODE MỚI
                string hoTen = HocSinhHoTenTextBox.Text;
                string gioiTinh = HocSinhGioiTinhComboBox.Text;
                string diaChi = HocSinhDiaChiTextBox.Text;
                string ngaySinh = HocSinhNgaySinhDateTime.Text;
                string email = HocSinhEmailTextBox.Text;
                if (hocSinh.flagSua)
                    hocSinh.SuaHocSinh(hoTen, gioiTinh, diaChi, ngaySinh, email);
                else
                    hocSinh.ThemHocSinh(hoTen, gioiTinh, diaChi, ngaySinh, email);

                mainApp.LoadTabTiepNhan("");
                this.Hide();
                
                //CODE CŨ

                //SQLConnect db = SQLConnect.GetInstance();
                //db.Open();
                //db.sqlCmd.CommandType = CommandType.Text;

                //string hoTen = HocSinhHoTenTextBox.Text;
                //string gioiTinh = HocSinhGioiTinhComboBox.Text;
                //string diaChi = HocSinhDiaChiTextBox.Text;
                //string ngaySinh = HocSinhNgaySinhDateTime.Text;
                //string email = HocSinhEmailTextBox.Text;

                //db.sqlCmd.CommandText = "SET DATEFORMAT DMY;" +
                //   "DECLARE @idHocSinh Char(7);" +
                //   "SELECT @idHocSinh = RIGHT(YEAR(GETDATE()),4)+ RIGHT('000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idHocSinh, 3) AS INT)) + 1 FROM HOCSINH WHERE idHocSinh LIKE (CAST(YEAR(GETDATE()) AS VARCHAR(4))) + '%'), 1) AS VARCHAR(3)), 3);" +
                //   "INSERT INTO HOCSINH VALUES (@idHocSinh,@hoTen,Null,@gioiTinh,@email,@diaChi,@ngaySinh);";


                //db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTen);
                //db.sqlCmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                //db.sqlCmd.Parameters.AddWithValue("@diaChi", diaChi);
                //db.sqlCmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                //db.sqlCmd.Parameters.AddWithValue("@email", email);


               
                //db.sqlCmd.Connection = db.sqlCon;

                //try
                //{
                //    db.sqlCmd.ExecuteNonQuery();
                //}
                //catch (Exception ex)
                //{
                //    Error.GetInstance().Show(ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
                //}

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
                if (control.Text.Length == 0)
                    return false;
            }
            return true;
        }

        //Sự kiện xảy ra khi form xuất hiện 
        private void HocSinhEmailTextBox_VisibleChanged(object sender, EventArgs e)
        {

                
        }

        //Sự kiện xảy ra khi form xuất hiện
        private void HocSinhForm_VisibleChanged(object sender, EventArgs e)
        {
            if (hocSinh.flagSua)
            {
                HocSinhHoTenTextBox.Text = hocSinh.HoTen;
                HocSinhDiaChiTextBox.Text = hocSinh.DiaChi;
                HocSinhEmailTextBox.Text = hocSinh.Email;
                HocSinhGioiTinhComboBox.Text = hocSinh.GioiTinh;
                HocSinhNgaySinhDateTime.Value = DateTime.ParseExact(hocSinh.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            else
                ClearForm();
        }
    }
}
