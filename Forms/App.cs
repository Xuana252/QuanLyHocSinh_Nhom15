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
using MetroFramework.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;



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
        MonHoc MonHoc = MonHoc.GetInstance();
        BangDiem BangDiem = BangDiem.GetInstance();
        ChiTietBangDiem chiTietBangDiem= ChiTietBangDiem.GetInstance();

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
        //Sự kiện khi kích thước cửa sổ thay đổi
        private void App_SizeChanged(object sender, EventArgs e)
        {
            
            if (WindowState != FormWindowState.Maximized)
                MaximizeRestoreButton.Image = Properties.Resources.MaximizeIcon;
            else
                MaximizeRestoreButton.Image = Properties.Resources.RestoreIcon;
            if (WindowState != FormWindowState.Minimized)
            {
                SuspendLayout();
                AppTabControl.ItemSize = new Size((AppTabControl.Width - 10) / AppTabControl.TabCount, 0);
                ResumeLayout();
            }

        }
        //Sự kiện khi bấm nút MinimizeWindow
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Sự kiện khi bấm nút Maximize/RestoreWindow
        private void MaximizeRestoreButton_Click(object sender, EventArgs e)
        {

            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
           
        }

        //Sự kiện khi bấm nút ExitWindow
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        //Sự kiện khi kéo thả thanh panel của app (Kéo cửa sổ app theo chuột)
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                if (MousePosition.Y <= 0)
                {
                    // Maximize the form
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        //Khối sự kiện dành cho việc vẽ các item dành cho listview
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (sender is MetroListView listView)
            {
                e.NewWidth = listView.Columns[e.ColumnIndex].Width;
                e.Cancel = true;
            }
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = false;
            if (sender is MetroListView listView)
            {
                using (System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular))
                {
                    System.Drawing.Rectangle headerBounds = e.Bounds;

                    e.Graphics.FillRectangle(Brushes.Teal, e.Bounds);

                    TextRenderer.DrawText(e.Graphics, listView.Columns[e.ColumnIndex].Text, headerFont, headerBounds, Color.White, Color.Empty, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                    e.Graphics.DrawLine(Pens.DarkGray, headerBounds.Left, headerBounds.Bottom - 1, headerBounds.Right, headerBounds.Bottom - 1);
                }
            }

        }
        //Sự kiện xử lý thay đổi kích thước cho các cột trong listview khi thay đổi kích thước cửa sổ
        private void ListView_SizeChanged(object sender, EventArgs e)
        {
            MetroListView listView = (MetroListView)sender;
            int hiddenColCounts = 0;
            foreach (ColumnHeader columnHeader in listView.Columns)
            {
                if(columnHeader.Width==0)
                    hiddenColCounts++;
            }
            foreach (ColumnHeader columnHeader in listView.Columns)
            {
                if (columnHeader.Index != 0)
                {
                    if (columnHeader.Width != 0)
                        columnHeader.Width = (listView.Width - listView.Columns[0].Width) / (listView.Columns.Count - 1 - hiddenColCounts);
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //Sự kiện khi App load lần đầu
        private void App_Load(object sender, EventArgs e)
        {
            //Cập nhật kích thước cửa sổ người dùng
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            //Cập nhật các thông số ban đầu của app
            AppTabControl.SelectedIndex = 0;
            UserIDLabel.Text = user.idGiaoVien;
            UserNameLabel.Text = user.hoTen;
            UserDateofBirthLabel.Text = user.ngaySinh;
            UserSubjectLabel.Text = user.monHoc;
            UserRoleLabel.Text = user.vaiTro;
            UserAddressLabel.Text = user.diaChi;
            UserGenderLabel.Text = user.gioiTinh;
            if (user.gioiTinh == "Nam")
                pictureBox1.Image = Properties.Resources.Male;
            else
                pictureBox1.Image= Properties.Resources.Female;

            //Tạo Form cần thiết 
            monHocForm = new MonHocForm();
            dangKiForm = new DangKi();
            diemForm = new DiemForm(this);
            giaoVienForm = new GiaoVienForm(dangKiForm);
            studentForm = new HocSinhForm(this);
            lopForm = new LopForm(this);
            dangKiForm.giaoVien = giaoVienForm;

            //--------------------------Điều chỉnh các control tùy thuộc vào quyền hạn (vai trò) của User----------------------------------------------------------
            if (user.idVaiTro != "QL")
            {
                AppTabControl.TabPages.Remove(TabTiepNhan); //Không hiển thị tab tiếp nhận

                AppTabControl.ItemSize =new Size( (AppTabControl.Width-10) / AppTabControl.TabCount,0);

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
                columnHeader37.Text = "Mã học sinh";
                //---------------------------------------------------------------

                //Điều chỉnh chiều rộng của listview danh sách học sinh lớp và các cột của nó
                DanhSachLopListView1.Dock = DockStyle.None;
                DanhSachLopListView1.Anchor= AnchorStyles.Bottom | AnchorStyles.Right |AnchorStyles.Left|AnchorStyles.Top;
                splitContainer1.Panel1.Controls.Remove(DanhSachLopListView1);
                this.TabDanhSachLop.Controls.Add(DanhSachLopListView1);
                DanhSachLopListView1.Location = new System.Drawing.Point(splitContainer1.Location.X,splitContainer1.Location.Y);
                splitContainer1.Parent.Controls.Remove(splitContainer1 );
                DanhSachLopListView1.Width = 1070;
                foreach (ColumnHeader header in DanhSachLopListView1.Columns)
                {
                    if (header.Index != 0)
                        header.Width = 1037 / 5;
                }
                DanhSachLopListView1.Refresh();
                //TAB TÀI KHOẢN
                TaiKhoanQuanLiTaiKhoanButton.Visible=false;//Không hiển thị nút quản lí tài khoản
                TaiKhoanDangKiButton.Visible=false;//Không hiển thị nút đăng kí

                //TAB BÁO CÁO MÔN


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

            TiepNhanListView.Items.Clear();
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach().OrderBy(item => item.SubItems[1].Text.Split(' ').Last()).ToList())
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

        }

        //Hàm load Tab Danh sách lớp
        public void LoadTabDanhSachLop(string idLop,string hoTenTimKiem)
        {
            List<ListViewItem> DanhSachHocSinh = HocSinh.LayDanhSach().OrderBy(item => item.SubItems[1].Text.Split(' ').Last()).ToList();
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
        //Hàm load Tab báo cáo môn
        public void LoadTabBaoCaoMon()
        {
            string tempTenLop=BaoCaoLopComboBox.Text;
            string tempTenMon=BaoCaoMonHocComboBox.Text;
            BaoCaoLopComboBox.Items.Clear();
            foreach (ListViewItem item in LopHoc.LayDanhSach())
            {
                BaoCaoLopComboBox.Items.Add(item.SubItems[1].Text);
            }
            BaoCaoLopComboBox.Text = tempTenLop;
            BaoCaoMonHocComboBox.Items.Clear();
            foreach (ListViewItem item in MonHoc.LayDanhSach())
            {
                BaoCaoMonHocComboBox.Items.Add(item.SubItems[1].Text);
            }
            BaoCaoMonHocComboBox.Text = tempTenMon;
            BaoCaoListView.Items.Clear();
            foreach(ListViewItem item in BangDiem.LayDanhSach(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value).OrderBy(item => item.SubItems[1].Text.Split(' ').Last()).ToList())
            {
                BaoCaoListView.Items.Add(item);
            }    
        }

        //Hàm load Tab tổng kết
        public void LoadTabTongKet()
        {
            //Load điểm qua môn 
            QuiDinh.LoadDiemQuaMon();
            TongKetDiemDatNumericBox.ValueChanged -= TongKetDiemDatNumericBox_ValueChanged;
            TongKetDiemDatNumericBox.Value = QuiDinh.DiemQuaMon;
            TongKetDiemDatNumericBox.ValueChanged += TongKetDiemDatNumericBox_ValueChanged;

            //Load năm học
            TongKetNamHoc.Value = decimal.Parse(DateTime.Today.ToString("yyyy"));

            //Reset các cấu hình mặc định cho tab
            MonHocRadioButton.Checked = true;
            HocKi1RadioButton.Checked = true;

            //Load danh sách môn học
            TongKetMonComboBox.Items.Clear();
            foreach (ListViewItem item in MonHoc.LayDanhSach())
            {
                TongKetMonComboBox.Items.Add(item.SubItems[1].Text);
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
                    LoadTabBaoCaoMon();
                    break;
                case "TabTongKet":
                    LoadTabTongKet();
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

        //Sự kiện liên quan đến resize Splitter cho tab Danh sách lớp
        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                splitContainer1.SplitterWidth = metroPanel1.Width;
                splitContainer1.SplitterDistance = (splitContainer1.Width - metroPanel1.Width) / 2 + 1;
            }
        }

        //Sự kiện khi chọn combobox tên lớp
        private void DanhSachLopTenLopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhSachLopTenLopComboBox.Text = DanhSachLopTenLopComboBox.SelectedItem.ToString();
        }
       
        //TAB TRA CỨU: Sự kiên khi bấm nút tìm kiếm
        private void TraCuuTimKiemButton_Click(object sender, EventArgs e)
        {
            TraCuuListView.Items.Clear();
            foreach (ListViewItem item in HocSinh.TraCuu(TraCuuTextBox.Text, TraCuuNamHoc.Value))
            {
                TraCuuListView.Items.Add(item);
            }

        }
        //TAB BÁO CÁO MÔN: Sư kiện khi bấm nút quản lí môn học
        private void QuanLyMonHocButton_Click(object sender, EventArgs e)
        {
            monHocForm.ShowDialog();
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
            studentForm.ShowDialog();
            TiepNhanListView.SelectedItems.Clear();
        }

        //TAB BÁO CÁO: Sự kiện khi bấm nút thêm sửa điểm
        private void BaoCaoThemSuaDiemButton_Click(object sender, EventArgs e)
        {
            if (BaoCaoListView.SelectedItems.Count > 0)
            {
                diemForm.idbangdiem = BangDiem.getIdBangDiem(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value);
                diemForm.idhocsinh = BaoCaoListView.SelectedItems[0].SubItems[5].Text;
                diemForm.flagSua = false;
                if (BaoCaoListView.SelectedItems[0].SubItems[3].Text != "0")
                {
                    diemForm.flagSua = true;
                    chiTietBangDiem.Diem15p = decimal.Parse(BaoCaoListView.SelectedItems[0].SubItems[2].Text);
                    chiTietBangDiem.Diem1Tiet = decimal.Parse(BaoCaoListView.SelectedItems[0].SubItems[3].Text);
                    chiTietBangDiem.DiemTB = decimal.Parse(BaoCaoListView.SelectedItems[0].SubItems[4].Text);
                }    
                diemForm.ShowDialog();
                BaoCaoListView.SelectedItems.Clear();
            }
            else
            {
                BaoCaoListView.SelectedItems.Clear();
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn học sinh cần thêm điểm");   
            }    
        }

        //TAB DANH SÁCH LỚP: Sự kiện khi bấm nút quản lí danh sách lớp
        private void DanhSachLopQuanLiButton_Click(object sender, EventArgs e)
        {
            lopForm.ShowDialog();
        }

        //TAB TÀI KHOẢN: Sự kiện khi bấm nút đăng kí
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            dangKiForm.ShowDialog();
        }

        //TAB TÀI KHOẢN: Sự kiện khi bấm nút đăng xuất
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        //TAB TÀI KHOẢN: Sự kiện khi bấm nút quản lí danh sách tài khoản
        private void QuanLiTaiKhoanButton_Click(object sender, EventArgs e)
        {
            giaoVienForm.ShowDialog();
        }

        //TAB BÁO CÁO MÔN: Sự kiện khi bấm nút Xem bảng điểm
        private void BaoCaoXemBangDiemButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BaoCaoListView.Items.Clear();
            BangDiem.tenLop = BaoCaoLopComboBox.Text;
            BangDiem.tenMonHoc = BaoCaoMonHocComboBox.Text;
            BangDiem.HocKy = int.Parse(BaoCaoHocKiComboBox.Text == ""?"1": BaoCaoHocKiComboBox.Text);
            BangDiem.NamHoc = (int)BaoCaoNamHocNumericUpDown.Value;
            foreach (ListViewItem item in BangDiem.LayDanhSach(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value))
            {
                BaoCaoListView.Items.Add(item);
            }
            if(BaoCaoListView.Items.Count == 0)
                ThongBaoForm.GetInstance().LogError("Chưa có thông tin của bảng điểm này, bạn có thể tạo bảng điểm mới");
            Cursor.Current = Cursors.Default;
        }
        //TAB BÁO CÁO MÔN: Sự kiện khi bấm nút Xóa bảng điểm
        private void BaoCaoXoaBangDiemButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BangDiem.XoaBangDiem(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value);
            LoadTabBaoCaoMon();
            Cursor.Current = Cursors.Default;
        }

        //TAB BÁO CÁO MÔN: Sự kiện khi bấm nút Thêm bảng điểm
        private void BaoCaoThemBangDiemButton_Click(object sender, EventArgs e)
        {
            if (BaoCaoHocKiComboBox.Text == "" || BaoCaoLopComboBox.Text == "" || BaoCaoMonHocComboBox.Text == "")
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            BangDiem.ThemBangDiem(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value);
        }

        //TAB BÁO CÁO MÔN: Sự kiện khi bấm nút Xóa điểm
        private void BaoCaoXoaDiemButton_Click(object sender, EventArgs e)
        {
            if (BaoCaoListView.SelectedItems.Count > 0)
            {
                string idbangdiem = BangDiem.getIdBangDiem(BaoCaoLopComboBox.Text, BaoCaoMonHocComboBox.Text, BaoCaoHocKiComboBox.Text, BaoCaoNamHocNumericUpDown.Value);
                foreach (ListViewItem item in BaoCaoListView.SelectedItems)
                {
                    chiTietBangDiem.XoaDiem(idbangdiem, item.SubItems[5].Text);
                }
                this.LoadTabBaoCaoMon();
            }
            else
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn học sinh cần xóa điểm");

        }

        //TAB TỔNG KẾT: Sự kiện khi bấm chọn nút Môn học
        private void MonHocRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MonHocRadioButton.Checked == true)
                TongKetMonComboBox.Enabled = true;
            else
                TongKetMonComboBox.Enabled = false;
        }

        //TAB TIẾP NHẬN: Sự kiện khi bấm nút xóa học sinh
        private void TiepNhanXoaHocSinhButton_Click(object sender, EventArgs e)
        {
            if (TiepNhanListView.SelectedItems.Count > 0)
            {
                List<ListViewItem> list = new List<ListViewItem>();
                foreach (ListViewItem item in TiepNhanListView.SelectedItems)
                {
                    list.Add(item);
                }
                HocSinh.XoaHocSinh(list);
            }
            else
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn học sinh muốn xóa");
            LoadTabTiepNhan("");

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
                LopHoc.TenLop = DanhSachLopTenLopComboBox.Text.Split(' ')[0];
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn lớp muốn xem");
                return;
            }
            

            DanhSachLopListView1.Items.Clear();
            //Lấy danh sách học sinh dựa vào idLop từ tên lớp đã chọn
            foreach (ListViewItem hocSinh in HocSinh.LayDanhSach().OrderBy(item => item.SubItems[1].Text.Split(' ').Last()).ToList())
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
            Cursor.Current = Cursors.WaitCursor;
            if (LopHoc.idLop.Length == 0)
                ThongBaoForm.GetInstance().LogError("Vui lòng xem lớp trước khi thêm học sinh");
            else
            {
                if (DanhSachLopListView2.SelectedItems.Count > 0)
                {
                    List<ListViewItem> list = new List<ListViewItem>();
                    foreach (ListViewItem item in DanhSachLopListView2.SelectedItems)
                    {
                        list.Add(item);
                    }
                    LopHoc.ThemHocSinhVaoLop(list);
                }
                else
                    ThongBaoForm.GetInstance().LogError("Vui lòng chọn học sinh muốn thêm vào lớp");
                LoadTabDanhSachLop(LopHoc.idLop, "");
            }
            Cursor.Current = Cursors.Default;
        }

        //TAB DANH SÁCH LỚP: Sự kiện xảy ra khi bấm nút xóa học sinh ra khỏi lớp
        private void DanhSachLopXoaHocSinhButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (LopHoc.idLop.Length == 0)
                ThongBaoForm.GetInstance().LogError("Vui lòng xem lớp trước khi xóa học sinh");
            else
            {
                if (DanhSachLopListView1.SelectedItems.Count > 0)
                {
                    List<ListViewItem> list = new List<ListViewItem>();
                    foreach (ListViewItem item in DanhSachLopListView1.SelectedItems)
                    {
                        list.Add(item);
                    }
                    LopHoc.XoaHocSinhKhoiLop(list);
                }
                else
                    ThongBaoForm.GetInstance().LogError("Vui lòng chọn học sinh muốn xóa khỏi lớp");
                LoadTabDanhSachLop(LopHoc.idLop, "");
            }
            Cursor.Current = Cursors.Default;
        }
        //TAB TỔNG KẾT: Sự kiện khi bấm nút thay đổi điểm đạt/qua môn
        private void TongKetDiemDatNumericBox_ValueChanged(object sender, EventArgs e)
        {
            QuiDinh.GetInstance().ThayDoiDiemQuaMon(TongKetDiemDatNumericBox.Value);
        }
        //TAB TỔNG KẾT: Sự kiện xảy ra khi bấm nút Xem
        private void TongKetXem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TongKetListView.Items.Clear();
            if (MonHocRadioButton.Checked)
            {
                int i = 1;
                SQLConnect db = SQLConnect.GetInstance();
                db.Open();
                

                db.sqlCmd.CommandText = "declare @idmon char(2), @diemquamon decimal(4,2); " +
                    "SELECT @idmon = idMonHoc FROM MONHOC WHERE TenMonHoc = @tenmon; " +
                    "SELECT @diemquamon = DiemQuaMon FROM QUIDINH;"+
                    "SELECT LOPHOC.tenlop, LOPHOC.siso, COUNT(CASE WHEN CHITIETBANGDIEM.DiemTB >= @diemquamon  THEN CHITIETBANGDIEM.idHocSinh ELSE NULL END) FROM LOPHOC " +
                    "JOIN BANGDIEM ON LOPHOC.idLop = BANGDIEM.idLop JOIN CHITIETBANGDIEM ON BANGDIEM.idBangDiem = CHITIETBANGDIEM.idBangDiem " +
                    "WHERE BANGDIEM.idMonHoc = @idmon AND BANGDIEM.HocKy = @hocky AND BANGDIEM.NamHoc = @namhoc " +
                    "GROUP BY LOPHOC.tenlop, LOPHOC.siso;";

                db.sqlCmd.Parameters.AddWithValue("@tenmon", TongKetMonComboBox.Text);
                db.sqlCmd.Parameters.AddWithValue("@namhoc", TongKetNamHoc.Value);
                db.sqlCmd.Parameters.AddWithValue("@hocky", TongKetMonHocKiGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

    

                db.reader = db.sqlCmd.ExecuteReader();
                if(db.reader.HasRows)
                {
                    while (db.reader.Read())
                    {
                        string tenlop = db.reader.GetString(0);
                        int siso = db.reader.GetInt32(1);
                        int shocsinhdat = db.reader.GetInt32(2);
                        float tile = ((float)shocsinhdat / siso) * 100;
                        string tile1 = tile.ToString() + "%";

                        ListViewItem item = new ListViewItem();
                        item.Text = i.ToString();
                        item.SubItems.Add(tenlop);
                        item.SubItems.Add(siso.ToString());
                        item.SubItems.Add(shocsinhdat.ToString());
                        item.SubItems.Add(tile1);

                        TongKetListView.Items.Add(item);
                    }
                }
                else
                {
                    ThongBaoForm.GetInstance().LogError("Chưa có thông tin cho bảng tổng kết này, nguyên nhân có thể do chưa có bảng điểm phù hợp");
                }
               
                db.reader.Close();
                db.Close();
            }
            else
            {
                int i = 1;
                SQLConnect db = SQLConnect.GetInstance();
                 db.Open();
                

                db.sqlCmd.CommandText = @"WITH DiemTBHocSinh AS (
                                        SELECT 
                                            CHITIETBANGDIEM.idhocsinh,
                                            AVG(CHITIETBANGDIEM.diemtb) AS diemtbhocky
                                        FROM 
                                            CHITIETBANGDIEM 
                                        JOIN 
                                            BANGDIEM ON CHITIETBANGDIEM.idbangdiem = BANGDIEM.idbangdiem 
                                        WHERE 
                                            BANGDIEM.hocky = @hocky
                                            AND BANGDIEM.namhoc = @namhoc
                                        GROUP BY 
                                            CHITIETBANGDIEM.idhocsinh
                                        HAVING 
                                            AVG(CHITIETBANGDIEM.diemtb) >= 5
                                        )
                                        SELECT 
                                            LOPHOC.tenlop, 
                                            LOPHOC.siso,
                                            COUNT(DISTINCT DiemTBHocSinh.idhocsinh) AS NumStudentsAbove5
                                        FROM 
                                            LOPHOC
                                        JOIN 
                                            BANGDIEM ON LOPHOC.idLop = BANGDIEM.idLop 
                                        JOIN 
                                            CHITIETBANGDIEM ON BANGDIEM.idBangDiem = CHITIETBANGDIEM.idBangDiem
                                        JOIN 
                                            DiemTBHocSinh ON CHITIETBANGDIEM.idhocsinh = DiemTBHocSinh.idhocsinh
                                        WHERE 
                                            BANGDIEM.HocKy = @hocky
                                            AND BANGDIEM.NamHoc = @namhoc
                                        GROUP BY 
                                            LOPHOC.tenlop, 
                                            LOPHOC.siso;";

                db.sqlCmd.Parameters.AddWithValue("@namhoc", TongKetNamHoc.Value);
                db.sqlCmd.Parameters.AddWithValue("@hocky", TongKetMonHocKiGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

    

                db.reader = db.sqlCmd.ExecuteReader();

                while (db.reader.Read())
                {
                    string tenlop = db.reader.GetString(0);
                    int siso = db.reader.GetInt32(1);
                    int shocsinhdat = db.reader.GetInt32(2);
                    float tile = ((float)shocsinhdat / siso) * 100;
                    string tile1 = tile.ToString() + "%";

                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(tenlop);
                    item.SubItems.Add(siso.ToString());
                    item.SubItems.Add(shocsinhdat.ToString());
                    item.SubItems.Add(tile1);

                    TongKetListView.Items.Add(item);
                }
                db.reader.Close();
                db.Close();
            }
            BangDiem.loaiTongKet = TongKetMonHocCaHocKiGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            BangDiem.namTongKet = TongKetNamHoc.Value;
            BangDiem.hocKiTongKet = TongKetMonHocKiGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            if (BangDiem.loaiTongKet == "Môn học")
                BangDiem.tenMonTongKet = TongKetMonComboBox.Text;
            else
                BangDiem.tenMonTongKet = "Tong hop";
            Cursor.Current = Cursors.Default;

        }

        //TAB BÁO CÁO MÔN: Sự kiện khi bấm nút xuất file 
        private void BaoCaoMonXuatButton_Click(object sender, EventArgs e)
        {
            if (BaoCaoListView.Items.Count > 0)
            {
                try
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook| *.xls", ValidateNames = true })
                    {
                        sfd.FileName = "Bao_cao_lop_"+ BangDiem.tenLop.Trim()+"_Mon_"+ BangDiem.tenMonHoc + "_Nam_hoc_"+ BangDiem.NamHoc.ToString() + " - " + (BangDiem.NamHoc + 1).ToString() + "_Hoc_ki_" + BangDiem.HocKy.ToString();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[2, 1] = "Lớp:";
                            ws.Cells[2, 2] = BangDiem.tenLop;
                            ws.Cells[2, 4] = "Môn học:";
                            ws.Cells[2, 5] = BangDiem.tenMonHoc;
                            ws.Cells[3, 1] = "Học kì:";
                            ws.Cells[3, 2] = BangDiem.HocKy.ToString();
                            ws.Cells[3, 4] = "Năm học:";
                            ws.Cells[3, 5] = BangDiem.NamHoc.ToString() + " - " + (BangDiem.NamHoc + 1).ToString();
                            ws.Cells[5, 1] = "STT";
                            ws.Cells[5, 2] = "Họ tên";
                            ws.Cells[5, 3] = "Điểm 15p";
                            ws.Cells[5, 4] = "Điểm 1 tiết";
                            ws.Cells[5, 5] = "Điểm TB";

                            int i = 6;
                            foreach (ListViewItem item in BaoCaoListView.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                i++;
                            }

                            wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                            ThongBaoForm.GetInstance().Inform("Xuất file thành công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ThongBaoForm.GetInstance().LogError($"Xảy ra lỗi trong quá trình xuất file: {ex.Message}");
                }
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn xem bảng điểm mong muốn trước khi xuất file");
            }
        }
        //TAB TỔNG KẾT: sự kiên khi bấm nút xuất file excel
        private void TongKetXuatButton_Click(object sender, EventArgs e)
        {
            if (TongKetListView.Items.Count > 0)
            {
                try
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook| *.xls", ValidateNames = true })
                    {
                        sfd.FileName = "Tong_ket_" + BangDiem.loaiTongKet + "_Nam_" + BangDiem.namTongKet.ToString() + " - " + (BangDiem.namTongKet + 1).ToString() + "_Hoc ki_" + BangDiem.hocKiTongKet + "_Mon_" + BangDiem.tenMonTongKet;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[2, 1] = "Loại tổng kết:";
                            ws.Cells[2, 2] = BangDiem.loaiTongKet;
                            ws.Cells[2, 4] = "Môn học:";
                            ws.Cells[2, 5] = BangDiem.tenMonTongKet;
                            ws.Cells[3, 1] = "Học kì:";
                            ws.Cells[3, 2] = BangDiem.hocKiTongKet;
                            ws.Cells[3, 4] = "Năm học:";
                            ws.Cells[3, 5] = BangDiem.namTongKet.ToString() + " - " + (BangDiem.namTongKet + 1).ToString();
                            ws.Cells[5, 1] = "STT";
                            ws.Cells[5, 2] = "Lớp";
                            ws.Cells[5, 3] = "Sĩ số";
                            ws.Cells[5, 4] = "Số lượng đạt";
                            ws.Cells[5, 5] = "Tỉ lệ";

                            int i = 6;
                            foreach (ListViewItem item in TongKetListView.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                i++;
                            }

                            wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                            ThongBaoForm.GetInstance().Inform("Xuất file thành công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ThongBaoForm.GetInstance().LogError($"Xảy ra lỗi trong quá trình xuất file: {ex.Message}");
                }
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn xem bảng tổng kết mong muốn trước khi xuất file");
            }
        }

        //TAB DANH SÁCH LỚP: Sự kiện khi bấm nút xuất file excel
        private void DanhSachLopXuatButton_Click(object sender, EventArgs e)
        {
            if (DanhSachLopListView1.Items.Count > 0)
            {
                try
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook| *.xls", ValidateNames = true })
                    {
                        sfd.FileName = "danh_sach_lop_" + LopHoc.GetInstance().TenLop.Trim();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[2, 1] = "Lớp:";
                            ws.Cells[2, 2] = LopHoc.GetInstance().TenLop;

                            ws.Cells[5, 1] = "STT";
                            ws.Cells[5, 2] = "Họ tên";
                            ws.Cells[5, 3] = "Giới tính";
                            ws.Cells[5, 4] = "Năm sinh";
                            ws.Cells[5, 5] = "Địa chỉ";

                            int i = 6;
                            foreach (ListViewItem item in DanhSachLopListView1.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                i++;
                            }

                            wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                            ThongBaoForm.GetInstance().Inform("Xuất file thành công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ThongBaoForm.GetInstance().LogError($"Xảy ra lỗi trong quá trình xuất file: {ex.Message}");
                }
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn xem lớp mong muốn trước khi xuất file");
            }
        }
    }

}
