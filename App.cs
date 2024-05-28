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
using System.Diagnostics.Eventing.Reader;

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
        QuiDinh QuiDinh = QuiDinh.GetInstance();

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
            lopForm = new LopForm(this);

            //--------------------------Điều chỉnh các control tùy thuộc vào quyền hạn (vai trò) của User----------------------------------------------------------
            if (user.idVaiTro != "QL")
            {
                AppTabControl.TabPages.Remove(TabTiepNhan); //Không hiển thị tab tiếp nhận

                AppTabControl.ItemSize =new Size( (AppTabControl.Width-10) / 5,0);

                //TAB BÁO CÁO MÔN
                QuanLyMonHocButton.Visible=false;//Không hiển thị nút quản lí môn học

                //TAB TỔNG KẾT 
                TongKetDiemDatNumericBox.Enabled=false;//Không cho phép thay đổi điểm qua môn

                //TAB DANH SÁCH LỚP
                //Không hiển thị các control liên quan đến danh sách học sinh tiếp nhận
                //------------------------------------------------------------
                label7.Visible=false;
                metroLabel11.Visible=false;
                DanhSachLopListView2.Visible=false;
                DanhSachLopQuanLiButton.Visible=false;
                DanhSachLopSearchTextBox.Visible=false;
                DanhSachLopTimKiemButton.Visible=false;
                DanhSachLopXoaHocSinhButton.Visible=false;
                DanhSachLopThemHocSinhButton.Visible = false;
                metroPanel1.Visible=false;
                //---------------------------------------------------------------

                //Điều chỉnh chiều rộng của listview danh sách học sinh lớp và các cột của nó
                DanhSachLopListView1.Width = 1073;
                foreach (ColumnHeader header in DanhSachLopListView1.Columns)
                {
                    if (header.Index != 0)
                        header.Width = 1040 / 5;
                }

                //TAB TÀI KHOẢN
                TaiKhoanQuanLiTaiKhoanButton.Visible=false;//Không hiển thị nút quản lí tài khoản
                TaiKhoanDangKiButton.Visible=false;//Không hiển thị nút đăng kí

            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------

        }

        //Hàm load Tab Tiếp nhận
        public void LoadTabTiepNhan(string hoTenTimKiem)
        {
            //Load tuổi qui định trong hệ thống sau đó gán giá trị tương ứng
            QuiDinh.LoadTuoiQuiDinh();
            TiepNhanMinAgeNumericBox.ValueChanged -= TiepCanMinAgeNumericBox_ValueChanged;
            this.TiepNhanMinAgeNumericBox.Value = QuiDinh.TuoiToiThieu;


            TiepNhanMaxAgeNumericBox.ValueChanged -= TiepNhanMaxAgeNumericBox_ValueChanged;
            this.TiepNhanMaxAgeNumericBox.Value = QuiDinh.TuoiToiDa;

            TiepNhanMinAgeNumericBox.ValueChanged += TiepCanMinAgeNumericBox_ValueChanged;
            TiepNhanMaxAgeNumericBox.ValueChanged += TiepNhanMaxAgeNumericBox_ValueChanged;




            //Load danh sách học sinh tiếp nhận dựa trên thanh tìm kiếm nếu trống thì lấy toàn bộ danh sách

            //CODE MỚI
            TiepNhanListView.Items.Clear();
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach())
            {
                if (hocSinh.SubItems[2].Text=="NULL")
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
                    else if (hocSinh.SubItems[1].Text.Contains(hoTenTimKiem))//Ngược lại nếu tên học sinh trùng với ten trong thanh tìm kiếm
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

        public void LoadTabDanhSachLop(string idLop,string hoTenTimKiem)
        {
            List<ListViewItem> DanhSachHocSinh = HocSinh.LayDanhSach();
            //Load danh sách lớp học vào combobox lớp học
            DanhSachLopTenLopComboBox.Items.Clear();
            foreach(ListViewItem item in LopHoc.LayDanhSach())
            {
                DanhSachLopTenLopComboBox.Items.Add(item.SubItems[1].Text +" - "+item.Text);
            }

            if (idLop.Length == 0)
            {
                DanhSachLopListView1.Items.Clear(); //Làm trống danh sách học sinh lớp học

                DanhSachLopSSLabel.Text = "0";//Cập nhật sỉ số thành 0 nếu không có lớp nào được chọn
            }
            else
            {
                //Cập nhật danh sách học sinh lớp học dựa theo idLop
                DanhSachLopListView1.Items.Clear();
                foreach (ListViewItem hocSinh in DanhSachHocSinh)
                {
                    if (LopHoc.idLop == hocSinh.SubItems[2].Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ((DanhSachLopListView1.Items.Count + 1).ToString());
                        item.SubItems.Add(hocSinh.SubItems[1]);
                        item.SubItems.Add(hocSinh.SubItems[3]);
                        item.SubItems.Add(hocSinh.SubItems[6].Text.Substring(hocSinh.SubItems[6].Text.Length - 4));
                        item.SubItems.Add(hocSinh.SubItems[5]);
                        item.SubItems.Add(hocSinh.Text);


                        DanhSachLopListView1.Items.Add(item);
                    }
                }
                //Cập nhật sỉ số lớp đã chọn
                DanhSachLopSSLabel.Text = DanhSachLopListView1.Items.Count.ToString();

            }
 
            //Load danh sách học sinh tiếp nhận dựa trên thanh tìm kiếm

            DanhSachLopListView2.Items.Clear();
            foreach (ListViewItem hocSinh in DanhSachHocSinh)
            {
                if (hocSinh.SubItems[2].Text == "NULL")
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
                    else if (hocSinh.SubItems[1].Text.Contains(hoTenTimKiem))//Ngược lại nếu tên học sinh bao gồm trong thanh tìm kiếm
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

        //Sự kiện khi thay đổi tab dùng để dánh dấu tab đang chuyển tới
        private void AppTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "TabTraCuu":
                    break;
                case "TabBaoCao":
                    break;
                case "TabTongKet":
                    break;
                case "TabTiepNhan":
                    LoadTabTiepNhan("");
                    break;
                case "TabDanhSachLop":
                    LoadTabDanhSachLop("", "");
                    break;
                case "TabUser":
                    break;

            }
        }

        
        //Sự kiện khi bấm nút X thoát

        //Sự kiện khi chọn combobox tên lớp
        private void DanhSachLopTenLopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhSachLopTenLopComboBox.Text = DanhSachLopTenLopComboBox.SelectedItem.ToString();
        }
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
                TiepNhanMaxAgeNumericBox.Value = TiepNhanMinAgeNumericBox.Value;
            }

            QuiDinh.ThayDoiTuoiToiDa((int)TiepNhanMaxAgeNumericBox.Value);
        }

        //TAB TIẾP NHẬN: Sự kiện khi giá trị tuổi tối thiểu thay đổi
        private void TiepCanMinAgeNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (TiepNhanMaxAgeNumericBox.Value < TiepNhanMinAgeNumericBox.Value)
            {
                TiepNhanMinAgeNumericBox.Value = TiepNhanMaxAgeNumericBox.Value;
            }

            QuiDinh.ThayDoiTuoiToiThieu((int)TiepNhanMinAgeNumericBox.Value);
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút tìm kiếm học sinh 
        private void metroButton2_Click(object sender, EventArgs e)
        {
            LoadTabDanhSachLop(LopHoc.idLop, DanhSachLopSearchTextBox.Text.Trim());
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút xem lớp
        private void DanhSachLopXemLopButton_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã chọn lớp hay chưa
            if (DanhSachLopTenLopComboBox.Text.Length>0)
            {
                string idLop = DanhSachLopTenLopComboBox.Text.Substring(DanhSachLopTenLopComboBox.Text.Length-3);
                LopHoc.idLop = idLop;
            }
            else
            {
                Error.GetInstance().Show("Vui lòng chọn lớp muốn xem");
                return;
            }
            

            DanhSachLopListView1.Items.Clear();
            //Lấy danh sách học sinh dựa vào idLop từ tên lớp đã chọn
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach())
            {
                if (hocSinh.SubItems[2].Text == LopHoc.idLop)
                {
                    ListViewItem item = new ListViewItem((DanhSachLopListView1.Items.Count + 1).ToString());
                    item.SubItems.Add(hocSinh.SubItems[1]);
                    item.SubItems.Add(hocSinh.SubItems[3]);
                    item.SubItems.Add(hocSinh.SubItems[6].Text.Substring(hocSinh.SubItems[6].Text.Length - 4));
                    item.SubItems.Add(hocSinh.SubItems[5]);
                    item.SubItems.Add(hocSinh.Text);

                    DanhSachLopListView1.Items.Add(item);
                }
            }
            //Cập nhật sỉ số lớp đã chọn
            DanhSachLopSSLabel.Text=DanhSachLopListView1.Items.Count.ToString();
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút thêm học sinh vào danh sách lớp
        private void DanhSachLopThemHocSinhButton_Click(object sender, EventArgs e)
        {
            if (LopHoc.idLop.Length == 0)
                Error.GetInstance().Show("Vui lòng xem lớp trước khi thêm học sinh");
            else
            {
                LopHoc.ThemHocSinhVaoLop(DanhSachLopListView2.SelectedItems);
                LoadTabDanhSachLop(LopHoc.idLop, "");
            }
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút xóa học sinh ra khỏi lớp
        private void DanhSachLopXoaHocSinhButton_Click(object sender, EventArgs e)
        {
            if (LopHoc.idLop.Length == 0)
                Error.GetInstance().Show("Vui lòng xem lớp trước khi thêm học sinh");
            else
            {
                LopHoc.XoaHocSinhKhoiLop(DanhSachLopListView1.SelectedItems);
                LoadTabDanhSachLop(LopHoc.idLop, "");
            }
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
