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
using MetroFramework.Controls;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocSinh_Nhom15
{
    public partial class App : MetroFramework.Forms.MetroForm
    {
        //Khởi tạo các form cần thiết ban đầu
        MonHocForm monHocForm;
        DangKi dangKiForm;
        DiemForm diemForm;
        GiaoVienForm giaoVienForm;
        HocSinhForm studentForm;
        LopForm lopForm;

        //Khởi tạo các đối tượng thuộc các class quan trọng
        TaiKhoan user = TaiKhoan.GetInstance();
        HocSinh HocSinh = HocSinh.GetInstance();
        LopHoc LopHoc = LopHoc.GetInstance();

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

        //Sự kiện khi App load lần đầu
        private void App_Load(object sender, EventArgs e)
        {

            //Cập nhật các thông số ban đầu của app
            AppTabControl.SelectedIndex = 0;
            UserIDLabel.Text = user.idGiaoVien;
            UserNameLabel.Text = user.hoTen;
            UserDateofBirthLabel.Text = user.ngaySinh;
            UserSubjectLabel.Text = user.monHoc;
            UserRoleLabel.Text = user.vaiTro;

            //Tạo Form cần thiết 
            monHocForm = new MonHocForm();
            dangKiForm = new DangKi();
            diemForm = new DiemForm();
            giaoVienForm = new GiaoVienForm();
            studentForm = new HocSinhForm(this);
            lopForm = new LopForm();

        }

        //Hàm load Tab Tiếp nhận
        public void LoadTabTiepNhan(string hoTenTimKiem)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            //Load tuổi tối thiểu và tối đa

            db.sqlCmd.CommandText = "SELECT TuoiToiThieu, TuoiToiDa FROM QUIDINH";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            if (db.reader.Read())
            {
                TiepNhanMinAgeNumericBox.ValueChanged -= TiepCanMinAgeNumericBox_ValueChanged;
                this.TiepNhanMinAgeNumericBox.Value = db.reader.GetInt32(0);


                TiepNhanMaxAgeNumericBox.ValueChanged -= TiepNhanMaxAgeNumericBox_ValueChanged;
                this.TiepNhanMaxAgeNumericBox.Value = db.reader.GetInt32(1);

                TiepNhanMinAgeNumericBox.ValueChanged += TiepCanMinAgeNumericBox_ValueChanged;
                TiepNhanMaxAgeNumericBox.ValueChanged += TiepNhanMaxAgeNumericBox_ValueChanged;


            }
            db.reader.Close();


            //Load danh sách học sinh tiếp nhận dựa trên thanh tìm kiếm nếu trống thì lấy toàn bộ danh sách

            //CODE MỚI
            TiepNhanListView.Items.Clear();
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach())
            {
                if (hocSinh.SubItems[2]!=null)
                {
                    if (hoTenTimKiem.Length == 0)//Nếu thanh tìm kiếm trống
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = (hocSinh.Text);
                        item.SubItems.Add(hocSinh.SubItems[1].Text);
                        item.SubItems.Add(hocSinh.SubItems[3].Text);
                        item.SubItems.Add(hocSinh.SubItems[6].Text);
                        item.SubItems.Add(hocSinh.SubItems[5].Text);
                        item.SubItems.Add(hocSinh.SubItems[4].Text);

                        TiepNhanListView.Items.Add(item);
                    }
                    else if (hocSinh.SubItems[1].Text == hoTenTimKiem)//Ngược lại nếu tên học sinh trùng với ten trong thanh tìm kiếm
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = (hocSinh.Text);
                        item.SubItems.Add(hocSinh.SubItems[1].Text);
                        item.SubItems.Add(hocSinh.SubItems[3].Text);
                        item.SubItems.Add(hocSinh.SubItems[6].Text);
                        item.SubItems.Add(hocSinh.SubItems[5].Text);
                        item.SubItems.Add(hocSinh.SubItems[4].Text);

                        TiepNhanListView.Items.Add(item);
                    }
                    
                }
                
            }

            //CODE CŨ

            //if (hoTenTimKiem.Length == 0)
            //    db.sqlCmd.CommandText = "SELECT idHocSinh,HoTen,GioiTinh,Email,DiaChi,CONVERT(VARCHAR(10),NgaySinh,103) FROM HOCSINH WHERE idLop IS NULL";
            //else
            //{
            //    db.sqlCmd.CommandText = "SELECT idHocSinh,HoTen,GioiTinh,Email,DiaChi,CONVERT(VARCHAR(10),NgaySinh,103) FROM HOCSINH WHERE idLop IS NULL AND hoTen=@hoTen";
            //    db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTenTimKiem);
            //}    

            //db.sqlCmd.Connection = db.sqlCon;

            //db.reader = db.sqlCmd.ExecuteReader();

            //TiepNhanListView.Items.Clear();

            //while (db.reader.Read())
            //{
            //    string idHocSinh = db.reader.GetString(0);
            //    string hoTen = db.reader.GetString(1);
            //    string gioiTinh = db.reader.GetString(2);
            //    string email = db.reader.GetString(3);
            //    string diaChi = db.reader.GetString(4);
            //    string ngaySinh = db.reader.GetString(5);

            //    ListViewItem item = new ListViewItem();
            //    item.Text = (idHocSinh);
            //    item.SubItems.Add(hoTen);
            //    item.SubItems.Add(gioiTinh);
            //    item.SubItems.Add(ngaySinh);
            //    item.SubItems.Add(diaChi);
            //    item.SubItems.Add(email);

            //    TiepNhanListView.Items.Add(item);

            //}
            //db.reader.Close();
        }

        //Hàm load Tab Danh sách lớp

        public void LoadTabDanhSachLop(string tenLop,string hoTenTimKiem)
        {
            //Load danh sách lớp học vào combobox lớp học
            foreach(ListViewItem item in LopHoc.LayDanhSach())
            {
                DanhSachLopTenLopComboBox.Items.Add(item.SubItems[1].Text);
            }    

            //Load danh sách học sinh tiếp nhận dựa trên thanh tìm kiếm

            DanhSachLopListView2.Items.Clear();
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach())
            {
                if (hocSinh.SubItems[2] != null)
                {
                    if (hoTenTimKiem.Length == 0)//Nếu thanh tìm kiếm trống
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ((DanhSachLopListView2.Items.Count+1).ToString());
                        item.SubItems.Add(hocSinh.SubItems[0].Text);
                        item.SubItems.Add(hocSinh.SubItems[1].Text);
                        item.SubItems.Add(hocSinh.SubItems[3].Text);
                        item.SubItems.Add(hocSinh.SubItems[6].Text.Substring(hocSinh.SubItems[6].Text.Length - 4));

                        DanhSachLopListView2.Items.Add(item);
                    }
                    else if (hocSinh.SubItems[1].Text == hoTenTimKiem)//Ngược lại nếu tên học sinh trùng với ten trong thanh tìm kiếm
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ((DanhSachLopListView2.Items.Count + 1).ToString());
                        item.SubItems.Add(hocSinh.SubItems[0].Text);
                        item.SubItems.Add(hocSinh.SubItems[1].Text);
                        item.SubItems.Add(hocSinh.SubItems[3].Text);
                        item.SubItems.Add(hocSinh.SubItems[6].Text.Substring(hocSinh.SubItems[6].Text.Length-4));

                        DanhSachLopListView2.Items.Add(item);
                    }

                }

            }
        }

        //Sự kiện khi thay đổi tab chủ yếu dùng để gọi các hàm load dành cho từng trang tương ứng
        private void AppTabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            switch (AppTabControl.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    LoadTabTiepNhan("");
                    break;
                case 4:
                    LoadTabDanhSachLop("","");
                    break;
                case 5:
                    break;

            }
        }
        //Sự kiện khi bấm nút X thoát
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //TAB BÁO CÁO MÔN: Sư kiện khi bấm nút quản lí môn học
        private void QuanLyMonHocButton_Click(object sender, EventArgs e)
        {
            monHocForm.Show();
        }
       
        //TAB TIẾP NHẬN: Sự kiện khi bấm nút thêm sửa học sinh
        private void TiepNhanThemHocSinhButton_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu người dùng có đang chọn học sinh nào không nếu có thì bật cờ chỉnh sửa để cấu hình chức năng chỉnh sửa
            if (TiepNhanListView.SelectedItems.Count > 0)
            {
                HocSinh.flagSua = true;
                ListViewItem item = TiepNhanListView.SelectedItems[0];
                HocSinh.idHocSinh = item.Text;
                HocSinh.HoTen = item.SubItems[1].Text;
                HocSinh.GioiTinh = item.SubItems[2].Text;
                HocSinh.NgaySinh = item.SubItems[3].Text;
                HocSinh.DiaChi = item.SubItems[4].Text;
                HocSinh.Email = item.SubItems[5].Text;
            }
            else
                HocSinh.flagSua = false;
            studentForm.Show();
        }

        //TAB BÁO CÁO: Sự kiện khi bấm nút thêm sửa điểm
        private void BaoCaoThemSuaDiemButton_Click(object sender, EventArgs e)
        {
            diemForm.Show();
        }
        //TAB DANH SÁCH LỚP: Sự kiện khi bấm nút quản lí danh sách lớp
        private void DanhSachLopQuanLiButton_Click(object sender, EventArgs e)
        {
            lopForm.Show();
        }
        //TAB TÀI KHOẢN: Sự kiện khi bấm nút đăng kí
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            dangKiForm.Show();
        }
        //TAB TÀI KHOẢN: Sự kiện khi bấm nút đăng xuất
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //TAB TÀI KHOẢN: Sự kiện khi bấm nút quản lí danh sách tài khoản
        private void QuanLiTaiKhoanButton_Click(object sender, EventArgs e)
        {
            giaoVienForm.Show();
        }

        //Sự kiện khi kéo thả thanh panel của app (Kéo cửa sổ app theo chuột)
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //TAB TỔNG KẾT: Sự kiện khi chọn combobox học kì/môn học (đảm bảo đã chọn học kì thì không thể chọn combo môn học)
        private void TongKetMonHocCaHocKiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TongKetMonHocCaHocKiComboBox.Text != "Môn học")
                this.TongKetMonComboBox.Enabled = false;
            else
                this.TongKetMonComboBox.Enabled = true;
        }


        



        //TAB TIẾP NHẬN: Sự kiện khi bấm nút xóa học sinh
        private void TiepNhanXoaHocSinhButton_Click(object sender, EventArgs e)
        {
            //CODE MỚI

            HocSinh.XoaHocSinh(TiepNhanListView.SelectedItems);
            LoadTabTiepNhan("");

            //CODE CŨ

            //SQLConnect db = SQLConnect.GetInstance();
            //db.Open();
            //db.sqlCmd.CommandType = CommandType.Text;
            //foreach (ListViewItem item in TiepNhanListView.SelectedItems)
            //{
            //    db.sqlCmd.CommandText = "DELETE FROM HOCSINH WHERE idHocSinh=@idHocSinh";


            //    db.sqlCmd.Parameters.AddWithValue("@idHocSinh", item.Text);


            //    db.sqlCmd.Connection = db.sqlCon;

            //    try
            //    {
            //        db.sqlCmd.ExecuteNonQuery();
            //        LoadTabTiepNhan("");
            //    }
            //    catch (Exception ex)
            //    {
            //        Error.GetInstance().Show(ex.Message.Substring(ex.Message.IndexOf('\n')));
            //    }
            //}
           
        }
        
        //TAB TIẾP NHẬN: Sự kiện khi bấm nút tìm kiếm
        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoadTabTiepNhan(TiepNhanSearchTextBox.Text.Trim());
        }

        //TAB TIẾP NHẬN: Sự kiện khi giá trị tuổi tối đa thay đổi
        private void TiepNhanMaxAgeNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if(TiepNhanMaxAgeNumericBox.Value<TiepNhanMinAgeNumericBox.Value)
            {
                TiepNhanMaxAgeNumericBox.Value = TiepNhanMinAgeNumericBox.Value + 1;
            }
            
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiDa = @TuoiToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiDa", (int)TiepNhanMaxAgeNumericBox.Value);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu"+ex.Message);
            }
        }

        //TAB TIẾP NHẬN: Sự kiện khi giá trị tuổi tối thiểu thay đổi
        private void TiepCanMinAgeNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (TiepNhanMaxAgeNumericBox.Value < TiepNhanMinAgeNumericBox.Value)
            {
                TiepNhanMaxAgeNumericBox.Value = TiepNhanMinAgeNumericBox.Value + 1;
            }

            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET TuoiToiThieu = @TuoiToiThieu;";

            db.sqlCmd.Parameters.AddWithValue("@TuoiToiThieu", (int)TiepNhanMinAgeNumericBox.Value);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút tìm kiếm học sinh 
        private void metroButton2_Click(object sender, EventArgs e)
        {
            LoadTabDanhSachLop("", DanhSachLopSearchTextBox.Text.Trim());
        }


        //Khối sự kiện dành cho việc vẽ các item dành cho listview
        //---------------------------------------------------------------------------------------------------------------------------------

        private void TraCuuListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.TraCuuListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void TraCuuListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void BaoCaoListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.BaoCaoListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void BaoCaoListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void TongKetListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.TongKetListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void TongKetListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void TiepNhanListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.TiepNhanListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void TiepNhanListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void DanhSachLopListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.DanhSachLopListView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void DanhSachLopListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void DanhSachLopListView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.DanhSachLopListView2.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void DanhSachLopListView2_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------

    }


}
