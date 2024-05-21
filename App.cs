using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QuanLyHocSinh_Nhom15
{
    public partial class App : MetroFramework.Forms.MetroForm
    {

        static MonHocForm       monHocForm = new MonHocForm();
        static DangKi           dangKiForm = new DangKi();
        static DiemForm         diemForm = new DiemForm();
        static Error            errorForm = new Error();
        static GiaoVienForm     giaoVienForm = new GiaoVienForm();
        static HocSinhForm      studentForm = new HocSinhForm();
        static LopForm          lopForm = new LopForm();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public App()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuanLyMonHocButton_Click(object sender, EventArgs e)
        {
            monHocForm.Show();
        }

        private void App_Load(object sender, EventArgs e)
        {
            AppTabControl.SelectedIndex = 0;    
        }

        private void TiepNhanThemHocSinhButton_Click(object sender, EventArgs e)
        {
            studentForm.Show();
        }

        private void TiepNhanSuaThongTinButton_Click(object sender, EventArgs e)
        {
       
        }

        private void BaoCaoThemSuaDiemButton_Click(object sender, EventArgs e)
        {
            diemForm.Show();
        }

        private void DanhSachLopQuanLiButton_Click(object sender, EventArgs e)
        {
            lopForm.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            dangKiForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }

        private void QuanLiTaiKhoanButton_Click(object sender, EventArgs e)
        {
            giaoVienForm.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TongKetMonHocCaHocKiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.TongKetMonHocCaHocKiComboBox.Text != "Môn học")
                this.TongKetMonComboBox.Enabled = false;
            else
                this.TongKetMonComboBox.Enabled = true;
        }
    }
}
