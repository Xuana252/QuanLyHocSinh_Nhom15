using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyHocSinh_Nhom15
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeRestoreButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.AppTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabTraCuu = new MetroFramework.Controls.MetroTabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TraCuuNamHoc = new System.Windows.Forms.NumericUpDown();
            this.TraCuuTimKiemButton = new System.Windows.Forms.Button();
            this.TraCuuTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TraCuuListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TabBaoCao = new MetroFramework.Controls.MetroTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BaoCaoXoaBangDiem = new System.Windows.Forms.Button();
            this.BaoCaoXemBangDiem = new System.Windows.Forms.Button();
            this.BaoCaoXoaDiem = new System.Windows.Forms.Button();
            this.BaoCaoThemSuaDiem = new System.Windows.Forms.Button();
            this.BaoCaoThemBangDiem = new System.Windows.Forms.Button();
            this.BaoCaoNamHocNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BaoCaoLopComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BaoCaoHocKiComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BaoCaoMonHocComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BaoCaoListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.BaoCaoMonXuatButton = new System.Windows.Forms.Button();
            this.QuanLyMonHocButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TabTongKet = new MetroFramework.Controls.MetroTabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TongKetNamHoc = new System.Windows.Forms.NumericUpDown();
            this.TongKetMonHocKiGroupBox = new System.Windows.Forms.GroupBox();
            this.HocKi2RadioButton = new System.Windows.Forms.RadioButton();
            this.HocKi1RadioButton = new System.Windows.Forms.RadioButton();
            this.TongKetMonHocCaHocKiGroupBox = new System.Windows.Forms.GroupBox();
            this.CaHocKiRadioButton = new System.Windows.Forms.RadioButton();
            this.MonHocRadioButton = new System.Windows.Forms.RadioButton();
            this.TongKetXem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TongKetDiemDatNumericBox = new System.Windows.Forms.NumericUpDown();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TongKetMonComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TongKetListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.TongKetXuatButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabTiepNhan = new MetroFramework.Controls.MetroTabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TiepNhanXoaHocSinh = new System.Windows.Forms.Button();
            this.TiepNhanTimKiemHocSinh = new System.Windows.Forms.Button();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.TiepNhanMaxAgeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.TiepNhanMinAgeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.TiepNhanThemSuaHocSinh = new System.Windows.Forms.Button();
            this.TiepNhanSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TiepNhanListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TabDanhSachLop = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DanhSachLopThemHocSinhButton = new MetroFramework.Controls.MetroButton();
            this.DanhSachLopXoaHocSinhButton = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DanhSachLopListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DanhSachLopListView2 = new MetroFramework.Controls.MetroListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel10 = new System.Windows.Forms.Panel();
            this.DanhSachLopTimKiemButton = new System.Windows.Forms.Button();
            this.DanhSachLopXemLopButton = new System.Windows.Forms.Button();
            this.DanhSachLopSSLabel = new MetroFramework.Controls.MetroLabel();
            this.DanhSachLopSiSoLabel = new System.Windows.Forms.Label();
            this.DanhSachLopTenLopComboBox = new MetroFramework.Controls.MetroComboBox();
            this.DanhSachLopSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DanhSachLopXuatButton = new System.Windows.Forms.Button();
            this.DanhSachLopQuanLiButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TabUser = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserAddressLabel = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.UserRoleLabel = new System.Windows.Forms.Label();
            this.UserSubjectLabel = new System.Windows.Forms.Label();
            this.UserDateofBirthLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.TaiKhoanDangKiButton = new System.Windows.Forms.Button();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.TaiKhoanDangXuatButton = new System.Windows.Forms.Button();
            this.TaiKhoanQuanLiTaiKhoanButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AppTabControl.SuspendLayout();
            this.TabTraCuu.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuNamHoc)).BeginInit();
            this.panel5.SuspendLayout();
            this.TabBaoCao.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoNamHocNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.TabTongKet.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TongKetNamHoc)).BeginInit();
            this.TongKetMonHocKiGroupBox.SuspendLayout();
            this.TongKetMonHocCaHocKiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TongKetDiemDatNumericBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.TabTiepNhan.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanMaxAgeNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanMinAgeNumericBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.TabDanhSachLop.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.TabUser.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.MaximizeRestoreButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AppNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.MinimizeIcon;
            this.MinimizeButton.Location = new System.Drawing.Point(901, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(56, 48);
            this.MinimizeButton.TabIndex = 34;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeRestoreButton
            // 
            this.MaximizeRestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeRestoreButton.FlatAppearance.BorderSize = 0;
            this.MaximizeRestoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.MaximizeRestoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeRestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeRestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeRestoreButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeRestoreButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.MaximizeIcon;
            this.MaximizeRestoreButton.Location = new System.Drawing.Point(963, -1);
            this.MaximizeRestoreButton.Name = "MaximizeRestoreButton";
            this.MaximizeRestoreButton.Size = new System.Drawing.Size(56, 48);
            this.MaximizeRestoreButton.TabIndex = 34;
            this.MaximizeRestoreButton.UseVisualStyleBackColor = true;
            this.MaximizeRestoreButton.Click += new System.EventHandler(this.MaximizeRestoreButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.AppIcon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ExitIcon;
            this.ExitButton.Location = new System.Drawing.Point(1025, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 48);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AppNameLabel.Location = new System.Drawing.Point(55, 9);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(231, 31);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "Quản lý học sinh";
            // 
            // AppTabControl
            // 
            this.AppTabControl.Controls.Add(this.TabTraCuu);
            this.AppTabControl.Controls.Add(this.TabBaoCao);
            this.AppTabControl.Controls.Add(this.TabTongKet);
            this.AppTabControl.Controls.Add(this.TabTiepNhan);
            this.AppTabControl.Controls.Add(this.TabDanhSachLop);
            this.AppTabControl.Controls.Add(this.TabUser);
            this.AppTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.AppTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.AppTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.AppTabControl.ItemSize = new System.Drawing.Size(179, 0);
            this.AppTabControl.Location = new System.Drawing.Point(1, 48);
            this.AppTabControl.Multiline = true;
            this.AppTabControl.Name = "AppTabControl";
            this.AppTabControl.SelectedIndex = 5;
            this.AppTabControl.Size = new System.Drawing.Size(1079, 606);
            this.AppTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AppTabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.AppTabControl.TabIndex = 0;
            this.AppTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppTabControl.UseCustomForeColor = true;
            this.AppTabControl.UseSelectable = true;
            this.AppTabControl.UseStyleColors = true;
            this.AppTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.AppTabControl_Selecting);
            // 
            // TabTraCuu
            // 
            this.TabTraCuu.Controls.Add(this.panel11);
            this.TabTraCuu.Controls.Add(this.TraCuuListView);
            this.TabTraCuu.Controls.Add(this.panel5);
            this.TabTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTraCuu.HorizontalScrollbarBarColor = true;
            this.TabTraCuu.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTraCuu.HorizontalScrollbarSize = 10;
            this.TabTraCuu.Location = new System.Drawing.Point(4, 38);
            this.TabTraCuu.Name = "TabTraCuu";
            this.TabTraCuu.Size = new System.Drawing.Size(1071, 564);
            this.TabTraCuu.TabIndex = 6;
            this.TabTraCuu.Text = "🔬 TRA CỨU";
            this.TabTraCuu.VerticalScrollbarBarColor = true;
            this.TabTraCuu.VerticalScrollbarHighlightOnWheel = false;
            this.TabTraCuu.VerticalScrollbarSize = 10;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.LightCyan;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.metroLabel6);
            this.panel11.Controls.Add(this.TraCuuNamHoc);
            this.panel11.Controls.Add(this.TraCuuTimKiemButton);
            this.panel11.Controls.Add(this.TraCuuTextBox);
            this.panel11.Controls.Add(this.metroLabel7);
            this.panel11.ForeColor = System.Drawing.Color.Teal;
            this.panel11.Location = new System.Drawing.Point(3, 65);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1066, 59);
            this.panel11.TabIndex = 17;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(430, 20);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 25);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Năm học:";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // TraCuuNamHoc
            // 
            this.TraCuuNamHoc.Location = new System.Drawing.Point(535, 20);
            this.TraCuuNamHoc.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TraCuuNamHoc.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TraCuuNamHoc.Name = "TraCuuNamHoc";
            this.TraCuuNamHoc.Size = new System.Drawing.Size(202, 26);
            this.TraCuuNamHoc.TabIndex = 15;
            this.TraCuuNamHoc.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // TraCuuTimKiemButton
            // 
            this.TraCuuTimKiemButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TraCuuTimKiemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TraCuuTimKiemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraCuuTimKiemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraCuuTimKiemButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.search;
            this.TraCuuTimKiemButton.Location = new System.Drawing.Point(777, 15);
            this.TraCuuTimKiemButton.Name = "TraCuuTimKiemButton";
            this.TraCuuTimKiemButton.Size = new System.Drawing.Size(132, 35);
            this.TraCuuTimKiemButton.TabIndex = 14;
            this.TraCuuTimKiemButton.Text = "Tìm kiếm";
            this.TraCuuTimKiemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TraCuuTimKiemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TraCuuTimKiemButton.UseVisualStyleBackColor = false;
            this.TraCuuTimKiemButton.Click += new System.EventHandler(this.TraCuuTimKiemButton_Click);
            // 
            // TraCuuTextBox
            // 
            // 
            // 
            // 
            this.TraCuuTextBox.CustomButton.Image = null;
            this.TraCuuTextBox.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.TraCuuTextBox.CustomButton.Name = "";
            this.TraCuuTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TraCuuTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TraCuuTextBox.CustomButton.TabIndex = 1;
            this.TraCuuTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TraCuuTextBox.CustomButton.UseSelectable = true;
            this.TraCuuTextBox.CustomButton.Visible = false;
            this.TraCuuTextBox.Lines = new string[0];
            this.TraCuuTextBox.Location = new System.Drawing.Point(121, 22);
            this.TraCuuTextBox.MaxLength = 32767;
            this.TraCuuTextBox.Name = "TraCuuTextBox";
            this.TraCuuTextBox.PasswordChar = '\0';
            this.TraCuuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TraCuuTextBox.SelectedText = "";
            this.TraCuuTextBox.SelectionLength = 0;
            this.TraCuuTextBox.SelectionStart = 0;
            this.TraCuuTextBox.ShortcutsEnabled = true;
            this.TraCuuTextBox.Size = new System.Drawing.Size(241, 23);
            this.TraCuuTextBox.TabIndex = 11;
            this.TraCuuTextBox.UseSelectable = true;
            this.TraCuuTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TraCuuTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(46, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 25);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Họ tên";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // TraCuuListView
            // 
            this.TraCuuListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TraCuuListView.BackColor = System.Drawing.Color.MintCream;
            this.TraCuuListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraCuuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.TraCuuListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.TraCuuListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TraCuuListView.FullRowSelect = true;
            this.TraCuuListView.GridLines = true;
            this.TraCuuListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TraCuuListView.Location = new System.Drawing.Point(3, 130);
            this.TraCuuListView.Name = "TraCuuListView";
            this.TraCuuListView.OwnerDraw = true;
            this.TraCuuListView.Size = new System.Drawing.Size(1067, 432);
            this.TraCuuListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.TraCuuListView.TabIndex = 9;
            this.TraCuuListView.UseCompatibleStateImageBehavior = false;
            this.TraCuuListView.UseSelectable = true;
            this.TraCuuListView.View = System.Windows.Forms.View.Details;
            this.TraCuuListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.TraCuuListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.TraCuuListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.TraCuuListView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "STT";
            this.columnHeader18.Width = 57;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Họ tên";
            this.columnHeader19.Width = 352;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Lớp";
            this.columnHeader20.Width = 101;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "TB Học Kỳ 1";
            this.columnHeader21.Width = 237;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "TB Học Kỳ 2";
            this.columnHeader22.Width = 318;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1074, 55);
            this.panel5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "TRA CỨU HỌC SINH";
            // 
            // TabBaoCao
            // 
            this.TabBaoCao.BackColor = System.Drawing.SystemColors.Control;
            this.TabBaoCao.Controls.Add(this.panel8);
            this.TabBaoCao.Controls.Add(this.BaoCaoListView);
            this.TabBaoCao.Controls.Add(this.panel3);
            this.TabBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabBaoCao.HorizontalScrollbarBarColor = true;
            this.TabBaoCao.HorizontalScrollbarHighlightOnWheel = false;
            this.TabBaoCao.HorizontalScrollbarSize = 10;
            this.TabBaoCao.Location = new System.Drawing.Point(4, 38);
            this.TabBaoCao.Name = "TabBaoCao";
            this.TabBaoCao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabBaoCao.Size = new System.Drawing.Size(1071, 564);
            this.TabBaoCao.TabIndex = 3;
            this.TabBaoCao.Text = "📝 BÁO CÁO MÔN";
            this.TabBaoCao.VerticalScrollbarBarColor = true;
            this.TabBaoCao.VerticalScrollbarHighlightOnWheel = false;
            this.TabBaoCao.VerticalScrollbarSize = 10;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.LightCyan;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.BaoCaoXoaBangDiem);
            this.panel8.Controls.Add(this.BaoCaoXemBangDiem);
            this.panel8.Controls.Add(this.BaoCaoXoaDiem);
            this.panel8.Controls.Add(this.BaoCaoThemSuaDiem);
            this.panel8.Controls.Add(this.BaoCaoThemBangDiem);
            this.panel8.Controls.Add(this.BaoCaoNamHocNumericUpDown);
            this.panel8.Controls.Add(this.BaoCaoLopComboBox);
            this.panel8.Controls.Add(this.metroLabel2);
            this.panel8.Controls.Add(this.metroLabel5);
            this.panel8.Controls.Add(this.metroLabel4);
            this.panel8.Controls.Add(this.BaoCaoHocKiComboBox);
            this.panel8.Controls.Add(this.metroLabel3);
            this.panel8.Controls.Add(this.BaoCaoMonHocComboBox);
            this.panel8.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel8.Location = new System.Drawing.Point(832, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 497);
            this.panel8.TabIndex = 29;
            // 
            // BaoCaoXoaBangDiem
            // 
            this.BaoCaoXoaBangDiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoXoaBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoXoaBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoXoaBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoXoaBangDiem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DeleteIcon;
            this.BaoCaoXoaBangDiem.Location = new System.Drawing.Point(18, 428);
            this.BaoCaoXoaBangDiem.Name = "BaoCaoXoaBangDiem";
            this.BaoCaoXoaBangDiem.Size = new System.Drawing.Size(202, 40);
            this.BaoCaoXoaBangDiem.TabIndex = 28;
            this.BaoCaoXoaBangDiem.Text = "Xóa bảng điểm";
            this.BaoCaoXoaBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoXoaBangDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoXoaBangDiem.UseVisualStyleBackColor = false;
            this.BaoCaoXoaBangDiem.Click += new System.EventHandler(this.BaoCaoXoaBangDiemButton_Click);
            // 
            // BaoCaoXemBangDiem
            // 
            this.BaoCaoXemBangDiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoXemBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoXemBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoXemBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoXemBangDiem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ViewIcon;
            this.BaoCaoXemBangDiem.Location = new System.Drawing.Point(18, 358);
            this.BaoCaoXemBangDiem.Name = "BaoCaoXemBangDiem";
            this.BaoCaoXemBangDiem.Size = new System.Drawing.Size(202, 40);
            this.BaoCaoXemBangDiem.TabIndex = 27;
            this.BaoCaoXemBangDiem.Text = "Xem bảng điểm";
            this.BaoCaoXemBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoXemBangDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoXemBangDiem.UseVisualStyleBackColor = false;
            this.BaoCaoXemBangDiem.Click += new System.EventHandler(this.BaoCaoXemBangDiemButton_Click);
            // 
            // BaoCaoXoaDiem
            // 
            this.BaoCaoXoaDiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoXoaDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoXoaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoXoaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoXoaDiem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DeleteIcon;
            this.BaoCaoXoaDiem.Location = new System.Drawing.Point(18, 132);
            this.BaoCaoXoaDiem.Name = "BaoCaoXoaDiem";
            this.BaoCaoXoaDiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaoCaoXoaDiem.Size = new System.Drawing.Size(202, 40);
            this.BaoCaoXoaDiem.TabIndex = 26;
            this.BaoCaoXoaDiem.Text = "Xóa điểm";
            this.BaoCaoXoaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoXoaDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoXoaDiem.UseVisualStyleBackColor = false;
            this.BaoCaoXoaDiem.Click += new System.EventHandler(this.BaoCaoXoaDiemButton_Click);
            // 
            // BaoCaoThemSuaDiem
            // 
            this.BaoCaoThemSuaDiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoThemSuaDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoThemSuaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoThemSuaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoThemSuaDiem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.AddIcon;
            this.BaoCaoThemSuaDiem.Location = new System.Drawing.Point(18, 72);
            this.BaoCaoThemSuaDiem.Name = "BaoCaoThemSuaDiem";
            this.BaoCaoThemSuaDiem.Size = new System.Drawing.Size(202, 40);
            this.BaoCaoThemSuaDiem.TabIndex = 25;
            this.BaoCaoThemSuaDiem.Text = "Thêm/Sửa điểm";
            this.BaoCaoThemSuaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoThemSuaDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoThemSuaDiem.UseVisualStyleBackColor = false;
            this.BaoCaoThemSuaDiem.Click += new System.EventHandler(this.BaoCaoThemSuaDiemButton_Click);
            // 
            // BaoCaoThemBangDiem
            // 
            this.BaoCaoThemBangDiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoThemBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoThemBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoThemBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoThemBangDiem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.AddIcon;
            this.BaoCaoThemBangDiem.Location = new System.Drawing.Point(18, 11);
            this.BaoCaoThemBangDiem.Name = "BaoCaoThemBangDiem";
            this.BaoCaoThemBangDiem.Size = new System.Drawing.Size(202, 40);
            this.BaoCaoThemBangDiem.TabIndex = 24;
            this.BaoCaoThemBangDiem.Text = "Thêm bảng điểm";
            this.BaoCaoThemBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoThemBangDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoThemBangDiem.UseVisualStyleBackColor = false;
            this.BaoCaoThemBangDiem.Click += new System.EventHandler(this.BaoCaoThemBangDiemButton_Click);
            // 
            // BaoCaoNamHocNumericUpDown
            // 
            this.BaoCaoNamHocNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaoCaoNamHocNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoNamHocNumericUpDown.Location = new System.Drawing.Point(92, 312);
            this.BaoCaoNamHocNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BaoCaoNamHocNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.BaoCaoNamHocNumericUpDown.Name = "BaoCaoNamHocNumericUpDown";
            this.BaoCaoNamHocNumericUpDown.Size = new System.Drawing.Size(128, 27);
            this.BaoCaoNamHocNumericUpDown.TabIndex = 23;
            this.BaoCaoNamHocNumericUpDown.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // BaoCaoLopComboBox
            // 
            this.BaoCaoLopComboBox.FormattingEnabled = true;
            this.BaoCaoLopComboBox.ItemHeight = 23;
            this.BaoCaoLopComboBox.Location = new System.Drawing.Point(91, 200);
            this.BaoCaoLopComboBox.Name = "BaoCaoLopComboBox";
            this.BaoCaoLopComboBox.Size = new System.Drawing.Size(129, 29);
            this.BaoCaoLopComboBox.TabIndex = 18;
            this.BaoCaoLopComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(18, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Lớp :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(18, 312);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 25);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Năm : ";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(18, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 25);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Học kì :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // BaoCaoHocKiComboBox
            // 
            this.BaoCaoHocKiComboBox.FormattingEnabled = true;
            this.BaoCaoHocKiComboBox.ItemHeight = 23;
            this.BaoCaoHocKiComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.BaoCaoHocKiComboBox.Location = new System.Drawing.Point(91, 270);
            this.BaoCaoHocKiComboBox.Name = "BaoCaoHocKiComboBox";
            this.BaoCaoHocKiComboBox.Size = new System.Drawing.Size(129, 29);
            this.BaoCaoHocKiComboBox.TabIndex = 12;
            this.BaoCaoHocKiComboBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(18, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Môn:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // BaoCaoMonHocComboBox
            // 
            this.BaoCaoMonHocComboBox.FormattingEnabled = true;
            this.BaoCaoMonHocComboBox.ItemHeight = 23;
            this.BaoCaoMonHocComboBox.Location = new System.Drawing.Point(91, 235);
            this.BaoCaoMonHocComboBox.Name = "BaoCaoMonHocComboBox";
            this.BaoCaoMonHocComboBox.Size = new System.Drawing.Size(129, 29);
            this.BaoCaoMonHocComboBox.TabIndex = 4;
            this.BaoCaoMonHocComboBox.UseSelectable = true;
            // 
            // BaoCaoListView
            // 
            this.BaoCaoListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaoCaoListView.BackColor = System.Drawing.Color.MintCream;
            this.BaoCaoListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaoCaoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.id});
            this.BaoCaoListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BaoCaoListView.FullRowSelect = true;
            this.BaoCaoListView.GridLines = true;
            this.BaoCaoListView.Location = new System.Drawing.Point(6, 64);
            this.BaoCaoListView.Name = "BaoCaoListView";
            this.BaoCaoListView.OwnerDraw = true;
            this.BaoCaoListView.Size = new System.Drawing.Size(820, 497);
            this.BaoCaoListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.BaoCaoListView.TabIndex = 22;
            this.BaoCaoListView.UseCompatibleStateImageBehavior = false;
            this.BaoCaoListView.UseCustomBackColor = true;
            this.BaoCaoListView.UseSelectable = true;
            this.BaoCaoListView.View = System.Windows.Forms.View.Details;
            this.BaoCaoListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.BaoCaoListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.BaoCaoListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.BaoCaoListView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Họ tên";
            this.columnHeader7.Width = 432;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Điểm 15p";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Điểm 1 tiết";
            this.columnHeader11.Width = 97;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Điểm TB";
            this.columnHeader12.Width = 147;
            // 
            // id
            // 
            this.id.Text = "";
            this.id.Width = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.BaoCaoMonXuatButton);
            this.panel3.Controls.Add(this.QuanLyMonHocButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 55);
            this.panel3.TabIndex = 7;
            // 
            // BaoCaoMonXuatButton
            // 
            this.BaoCaoMonXuatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaoCaoMonXuatButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BaoCaoMonXuatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoMonXuatButton.FlatAppearance.BorderSize = 0;
            this.BaoCaoMonXuatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCaoMonXuatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoMonXuatButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ExcelExportIcon;
            this.BaoCaoMonXuatButton.Location = new System.Drawing.Point(892, 12);
            this.BaoCaoMonXuatButton.Name = "BaoCaoMonXuatButton";
            this.BaoCaoMonXuatButton.Size = new System.Drawing.Size(158, 33);
            this.BaoCaoMonXuatButton.TabIndex = 26;
            this.BaoCaoMonXuatButton.Text = "Xuất file Excel";
            this.BaoCaoMonXuatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BaoCaoMonXuatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BaoCaoMonXuatButton.UseVisualStyleBackColor = false;
            this.BaoCaoMonXuatButton.Click += new System.EventHandler(this.BaoCaoMonXuatButton_Click);
            // 
            // QuanLyMonHocButton
            // 
            this.QuanLyMonHocButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuanLyMonHocButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuanLyMonHocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuanLyMonHocButton.FlatAppearance.BorderSize = 0;
            this.QuanLyMonHocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuanLyMonHocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyMonHocButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DatabaseIcon;
            this.QuanLyMonHocButton.Location = new System.Drawing.Point(714, 12);
            this.QuanLyMonHocButton.Name = "QuanLyMonHocButton";
            this.QuanLyMonHocButton.Size = new System.Drawing.Size(160, 33);
            this.QuanLyMonHocButton.TabIndex = 25;
            this.QuanLyMonHocButton.Text = "Quản lí môn học";
            this.QuanLyMonHocButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuanLyMonHocButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuanLyMonHocButton.UseVisualStyleBackColor = false;
            this.QuanLyMonHocButton.Click += new System.EventHandler(this.QuanLyMonHocButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // TabTongKet
            // 
            this.TabTongKet.BackColor = System.Drawing.SystemColors.Control;
            this.TabTongKet.Controls.Add(this.panel7);
            this.TabTongKet.Controls.Add(this.TongKetListView);
            this.TabTongKet.Controls.Add(this.panel4);
            this.TabTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTongKet.HorizontalScrollbarBarColor = true;
            this.TabTongKet.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTongKet.HorizontalScrollbarSize = 10;
            this.TabTongKet.Location = new System.Drawing.Point(4, 38);
            this.TabTongKet.Name = "TabTongKet";
            this.TabTongKet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTongKet.Size = new System.Drawing.Size(1071, 564);
            this.TabTongKet.TabIndex = 4;
            this.TabTongKet.Text = "📖 TỔNG KẾT";
            this.TabTongKet.VerticalScrollbarBarColor = true;
            this.TabTongKet.VerticalScrollbarHighlightOnWheel = false;
            this.TabTongKet.VerticalScrollbarSize = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.LightCyan;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TongKetNamHoc);
            this.panel7.Controls.Add(this.TongKetMonHocKiGroupBox);
            this.panel7.Controls.Add(this.TongKetMonHocCaHocKiGroupBox);
            this.panel7.Controls.Add(this.TongKetXem);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.TongKetDiemDatNumericBox);
            this.panel7.Controls.Add(this.metroLabel14);
            this.panel7.Controls.Add(this.TongKetMonComboBox);
            this.panel7.Controls.Add(this.metroLabel12);
            this.panel7.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(839, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 500);
            this.panel7.TabIndex = 30;
            // 
            // TongKetNamHoc
            // 
            this.TongKetNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TongKetNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetNamHoc.Location = new System.Drawing.Point(8, 288);
            this.TongKetNamHoc.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TongKetNamHoc.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TongKetNamHoc.Name = "TongKetNamHoc";
            this.TongKetNamHoc.Size = new System.Drawing.Size(202, 26);
            this.TongKetNamHoc.TabIndex = 31;
            this.TongKetNamHoc.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // TongKetMonHocKiGroupBox
            // 
            this.TongKetMonHocKiGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TongKetMonHocKiGroupBox.Controls.Add(this.HocKi2RadioButton);
            this.TongKetMonHocKiGroupBox.Controls.Add(this.HocKi1RadioButton);
            this.TongKetMonHocKiGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetMonHocKiGroupBox.ForeColor = System.Drawing.Color.Teal;
            this.TongKetMonHocKiGroupBox.Location = new System.Drawing.Point(8, 91);
            this.TongKetMonHocKiGroupBox.Name = "TongKetMonHocKiGroupBox";
            this.TongKetMonHocKiGroupBox.Size = new System.Drawing.Size(200, 85);
            this.TongKetMonHocKiGroupBox.TabIndex = 30;
            this.TongKetMonHocKiGroupBox.TabStop = false;
            this.TongKetMonHocKiGroupBox.Text = "Học kì:";
            // 
            // HocKi2RadioButton
            // 
            this.HocKi2RadioButton.AutoSize = true;
            this.HocKi2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocKi2RadioButton.Location = new System.Drawing.Point(10, 56);
            this.HocKi2RadioButton.Name = "HocKi2RadioButton";
            this.HocKi2RadioButton.Size = new System.Drawing.Size(33, 20);
            this.HocKi2RadioButton.TabIndex = 1;
            this.HocKi2RadioButton.Text = "2";
            this.HocKi2RadioButton.UseVisualStyleBackColor = true;
            // 
            // HocKi1RadioButton
            // 
            this.HocKi1RadioButton.AutoSize = true;
            this.HocKi1RadioButton.Checked = true;
            this.HocKi1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocKi1RadioButton.Location = new System.Drawing.Point(10, 26);
            this.HocKi1RadioButton.Name = "HocKi1RadioButton";
            this.HocKi1RadioButton.Size = new System.Drawing.Size(33, 20);
            this.HocKi1RadioButton.TabIndex = 0;
            this.HocKi1RadioButton.TabStop = true;
            this.HocKi1RadioButton.Text = "1";
            this.HocKi1RadioButton.UseVisualStyleBackColor = true;
            // 
            // TongKetMonHocCaHocKiGroupBox
            // 
            this.TongKetMonHocCaHocKiGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TongKetMonHocCaHocKiGroupBox.Controls.Add(this.CaHocKiRadioButton);
            this.TongKetMonHocCaHocKiGroupBox.Controls.Add(this.MonHocRadioButton);
            this.TongKetMonHocCaHocKiGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetMonHocCaHocKiGroupBox.ForeColor = System.Drawing.Color.Teal;
            this.TongKetMonHocCaHocKiGroupBox.Location = new System.Drawing.Point(8, 2);
            this.TongKetMonHocCaHocKiGroupBox.Name = "TongKetMonHocCaHocKiGroupBox";
            this.TongKetMonHocCaHocKiGroupBox.Size = new System.Drawing.Size(200, 83);
            this.TongKetMonHocCaHocKiGroupBox.TabIndex = 29;
            this.TongKetMonHocCaHocKiGroupBox.TabStop = false;
            this.TongKetMonHocCaHocKiGroupBox.Text = "Môn học/ cả học kì:";
            // 
            // CaHocKiRadioButton
            // 
            this.CaHocKiRadioButton.AutoSize = true;
            this.CaHocKiRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaHocKiRadioButton.Location = new System.Drawing.Point(10, 56);
            this.CaHocKiRadioButton.Name = "CaHocKiRadioButton";
            this.CaHocKiRadioButton.Size = new System.Drawing.Size(89, 20);
            this.CaHocKiRadioButton.TabIndex = 1;
            this.CaHocKiRadioButton.Tag = "";
            this.CaHocKiRadioButton.Text = "Cả học kì";
            this.CaHocKiRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonHocRadioButton
            // 
            this.MonHocRadioButton.AutoSize = true;
            this.MonHocRadioButton.Checked = true;
            this.MonHocRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocRadioButton.Location = new System.Drawing.Point(10, 26);
            this.MonHocRadioButton.Name = "MonHocRadioButton";
            this.MonHocRadioButton.Size = new System.Drawing.Size(83, 20);
            this.MonHocRadioButton.TabIndex = 0;
            this.MonHocRadioButton.TabStop = true;
            this.MonHocRadioButton.Tag = "";
            this.MonHocRadioButton.Text = "Môn học";
            this.MonHocRadioButton.UseVisualStyleBackColor = true;
            this.MonHocRadioButton.CheckedChanged += new System.EventHandler(this.MonHocRadioButton_CheckedChanged);
            // 
            // TongKetXem
            // 
            this.TongKetXem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TongKetXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TongKetXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TongKetXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetXem.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ViewIcon;
            this.TongKetXem.Location = new System.Drawing.Point(8, 334);
            this.TongKetXem.Name = "TongKetXem";
            this.TongKetXem.Size = new System.Drawing.Size(200, 50);
            this.TongKetXem.TabIndex = 28;
            this.TongKetXem.Text = "Xem";
            this.TongKetXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TongKetXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TongKetXem.UseVisualStyleBackColor = false;
            this.TongKetXem.Click += new System.EventHandler(this.TongKetXem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(47, 443);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Điểm đạt môn/đạt";
            // 
            // TongKetDiemDatNumericBox
            // 
            this.TongKetDiemDatNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongKetDiemDatNumericBox.DecimalPlaces = 2;
            this.TongKetDiemDatNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetDiemDatNumericBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TongKetDiemDatNumericBox.Location = new System.Drawing.Point(51, 466);
            this.TongKetDiemDatNumericBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TongKetDiemDatNumericBox.Name = "TongKetDiemDatNumericBox";
            this.TongKetDiemDatNumericBox.Size = new System.Drawing.Size(131, 27);
            this.TongKetDiemDatNumericBox.TabIndex = 19;
            this.TongKetDiemDatNumericBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TongKetDiemDatNumericBox.ValueChanged += new System.EventHandler(this.TongKetDiemDatNumericBox_ValueChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.ForeColor = System.Drawing.Color.Teal;
            this.metroLabel14.Location = new System.Drawing.Point(8, 260);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(54, 25);
            this.metroLabel14.TabIndex = 17;
            this.metroLabel14.Text = "Năm:";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // TongKetMonComboBox
            // 
            this.TongKetMonComboBox.FormattingEnabled = true;
            this.TongKetMonComboBox.ItemHeight = 23;
            this.TongKetMonComboBox.Location = new System.Drawing.Point(8, 228);
            this.TongKetMonComboBox.Name = "TongKetMonComboBox";
            this.TongKetMonComboBox.Size = new System.Drawing.Size(200, 29);
            this.TongKetMonComboBox.TabIndex = 16;
            this.TongKetMonComboBox.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.ForeColor = System.Drawing.Color.Teal;
            this.metroLabel12.Location = new System.Drawing.Point(8, 194);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(58, 25);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "Môn :";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // TongKetListView
            // 
            this.TongKetListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TongKetListView.BackColor = System.Drawing.Color.MintCream;
            this.TongKetListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongKetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.TongKetListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TongKetListView.FullRowSelect = true;
            this.TongKetListView.GridLines = true;
            this.TongKetListView.Location = new System.Drawing.Point(3, 64);
            this.TongKetListView.Name = "TongKetListView";
            this.TongKetListView.OwnerDraw = true;
            this.TongKetListView.Size = new System.Drawing.Size(830, 500);
            this.TongKetListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.TongKetListView.TabIndex = 10;
            this.TongKetListView.UseCompatibleStateImageBehavior = false;
            this.TongKetListView.UseSelectable = true;
            this.TongKetListView.View = System.Windows.Forms.View.Details;
            this.TongKetListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.TongKetListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.TongKetListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.TongKetListView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STT";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Lớp";
            this.columnHeader9.Width = 141;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Sĩ số";
            this.columnHeader23.Width = 125;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Số lượng đạt";
            this.columnHeader24.Width = 211;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Tỉ lệ";
            this.columnHeader25.Width = 220;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.TongKetXuatButton);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 55);
            this.panel4.TabIndex = 9;
            // 
            // TongKetXuatButton
            // 
            this.TongKetXuatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TongKetXuatButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TongKetXuatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TongKetXuatButton.FlatAppearance.BorderSize = 0;
            this.TongKetXuatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TongKetXuatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongKetXuatButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ExcelExportIcon;
            this.TongKetXuatButton.Location = new System.Drawing.Point(887, 12);
            this.TongKetXuatButton.Name = "TongKetXuatButton";
            this.TongKetXuatButton.Size = new System.Drawing.Size(158, 33);
            this.TongKetXuatButton.TabIndex = 27;
            this.TongKetXuatButton.Text = "Xuất file Excel";
            this.TongKetXuatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TongKetXuatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TongKetXuatButton.UseVisualStyleBackColor = false;
            this.TongKetXuatButton.Click += new System.EventHandler(this.TongKetXuatButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "BÁO CÁO TỔNG KẾT";
            // 
            // TabTiepNhan
            // 
            this.TabTiepNhan.BackColor = System.Drawing.SystemColors.Control;
            this.TabTiepNhan.Controls.Add(this.panel9);
            this.TabTiepNhan.Controls.Add(this.TiepNhanListView);
            this.TabTiepNhan.Controls.Add(this.panel2);
            this.TabTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTiepNhan.HorizontalScrollbarBarColor = true;
            this.TabTiepNhan.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTiepNhan.HorizontalScrollbarSize = 10;
            this.TabTiepNhan.Location = new System.Drawing.Point(4, 38);
            this.TabTiepNhan.Name = "TabTiepNhan";
            this.TabTiepNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTiepNhan.Size = new System.Drawing.Size(1071, 564);
            this.TabTiepNhan.TabIndex = 1;
            this.TabTiepNhan.Text = "➕ TIẾP NHẬN";
            this.TabTiepNhan.VerticalScrollbarBarColor = true;
            this.TabTiepNhan.VerticalScrollbarHighlightOnWheel = false;
            this.TabTiepNhan.VerticalScrollbarSize = 10;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.LightCyan;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.TiepNhanXoaHocSinh);
            this.panel9.Controls.Add(this.TiepNhanTimKiemHocSinh);
            this.panel9.Controls.Add(this.metroLabel16);
            this.panel9.Controls.Add(this.TiepNhanMaxAgeNumericBox);
            this.panel9.Controls.Add(this.metroLabel15);
            this.panel9.Controls.Add(this.TiepNhanMinAgeNumericBox);
            this.panel9.Controls.Add(this.metroLabel13);
            this.panel9.Controls.Add(this.TiepNhanThemSuaHocSinh);
            this.panel9.Controls.Add(this.TiepNhanSearchTextBox);
            this.panel9.Controls.Add(this.metroLabel1);
            this.panel9.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel9.Location = new System.Drawing.Point(3, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1065, 50);
            this.panel9.TabIndex = 29;
            // 
            // TiepNhanXoaHocSinh
            // 
            this.TiepNhanXoaHocSinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TiepNhanXoaHocSinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TiepNhanXoaHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TiepNhanXoaHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiepNhanXoaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepNhanXoaHocSinh.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DeleteIcon;
            this.TiepNhanXoaHocSinh.Location = new System.Drawing.Point(625, 6);
            this.TiepNhanXoaHocSinh.Name = "TiepNhanXoaHocSinh";
            this.TiepNhanXoaHocSinh.Size = new System.Drawing.Size(150, 37);
            this.TiepNhanXoaHocSinh.TabIndex = 28;
            this.TiepNhanXoaHocSinh.Text = "Xóa học sinh";
            this.TiepNhanXoaHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TiepNhanXoaHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TiepNhanXoaHocSinh.UseVisualStyleBackColor = false;
            this.TiepNhanXoaHocSinh.Click += new System.EventHandler(this.TiepNhanXoaHocSinhButton_Click);
            // 
            // TiepNhanTimKiemHocSinh
            // 
            this.TiepNhanTimKiemHocSinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TiepNhanTimKiemHocSinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TiepNhanTimKiemHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TiepNhanTimKiemHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiepNhanTimKiemHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepNhanTimKiemHocSinh.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.search;
            this.TiepNhanTimKiemHocSinh.Location = new System.Drawing.Point(506, 6);
            this.TiepNhanTimKiemHocSinh.Name = "TiepNhanTimKiemHocSinh";
            this.TiepNhanTimKiemHocSinh.Size = new System.Drawing.Size(113, 37);
            this.TiepNhanTimKiemHocSinh.TabIndex = 27;
            this.TiepNhanTimKiemHocSinh.Text = "Tìm kiếm";
            this.TiepNhanTimKiemHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TiepNhanTimKiemHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TiepNhanTimKiemHocSinh.UseVisualStyleBackColor = false;
            this.TiepNhanTimKiemHocSinh.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(956, 12);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(58, 25);
            this.metroLabel16.TabIndex = 15;
            this.metroLabel16.Text = "tối đa";
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // TiepNhanMaxAgeNumericBox
            // 
            this.TiepNhanMaxAgeNumericBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TiepNhanMaxAgeNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiepNhanMaxAgeNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepNhanMaxAgeNumericBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TiepNhanMaxAgeNumericBox.Location = new System.Drawing.Point(1020, 12);
            this.TiepNhanMaxAgeNumericBox.Name = "TiepNhanMaxAgeNumericBox";
            this.TiepNhanMaxAgeNumericBox.Size = new System.Drawing.Size(40, 27);
            this.TiepNhanMaxAgeNumericBox.TabIndex = 13;
            this.TiepNhanMaxAgeNumericBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TiepNhanMaxAgeNumericBox.ValueChanged += new System.EventHandler(this.TiepNhanMaxAgeNumericBox_ValueChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(779, 13);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(116, 25);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Tuổi tối thiểu";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // TiepNhanMinAgeNumericBox
            // 
            this.TiepNhanMinAgeNumericBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TiepNhanMinAgeNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiepNhanMinAgeNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepNhanMinAgeNumericBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TiepNhanMinAgeNumericBox.Location = new System.Drawing.Point(899, 12);
            this.TiepNhanMinAgeNumericBox.Name = "TiepNhanMinAgeNumericBox";
            this.TiepNhanMinAgeNumericBox.Size = new System.Drawing.Size(40, 27);
            this.TiepNhanMinAgeNumericBox.TabIndex = 12;
            this.TiepNhanMinAgeNumericBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.TiepNhanMinAgeNumericBox.ValueChanged += new System.EventHandler(this.TiepCanMinAgeNumericBox_ValueChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(182, 11);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(70, 25);
            this.metroLabel13.TabIndex = 11;
            this.metroLabel13.Text = "Họ tên:";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // TiepNhanThemSuaHocSinh
            // 
            this.TiepNhanThemSuaHocSinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TiepNhanThemSuaHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TiepNhanThemSuaHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiepNhanThemSuaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepNhanThemSuaHocSinh.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.AddIcon;
            this.TiepNhanThemSuaHocSinh.Location = new System.Drawing.Point(7, 6);
            this.TiepNhanThemSuaHocSinh.Name = "TiepNhanThemSuaHocSinh";
            this.TiepNhanThemSuaHocSinh.Size = new System.Drawing.Size(172, 37);
            this.TiepNhanThemSuaHocSinh.TabIndex = 26;
            this.TiepNhanThemSuaHocSinh.Text = "Thêm học sinh";
            this.TiepNhanThemSuaHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TiepNhanThemSuaHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TiepNhanThemSuaHocSinh.UseVisualStyleBackColor = false;
            this.TiepNhanThemSuaHocSinh.Click += new System.EventHandler(this.TiepNhanThemHocSinhButton_Click);
            // 
            // TiepNhanSearchTextBox
            // 
            this.TiepNhanSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TiepNhanSearchTextBox.CustomButton.Image = null;
            this.TiepNhanSearchTextBox.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.TiepNhanSearchTextBox.CustomButton.Name = "";
            this.TiepNhanSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TiepNhanSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TiepNhanSearchTextBox.CustomButton.TabIndex = 1;
            this.TiepNhanSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TiepNhanSearchTextBox.CustomButton.UseSelectable = true;
            this.TiepNhanSearchTextBox.CustomButton.Visible = false;
            this.TiepNhanSearchTextBox.Lines = new string[0];
            this.TiepNhanSearchTextBox.Location = new System.Drawing.Point(254, 13);
            this.TiepNhanSearchTextBox.MaxLength = 32767;
            this.TiepNhanSearchTextBox.Name = "TiepNhanSearchTextBox";
            this.TiepNhanSearchTextBox.PasswordChar = '\0';
            this.TiepNhanSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TiepNhanSearchTextBox.SelectedText = "";
            this.TiepNhanSearchTextBox.SelectionLength = 0;
            this.TiepNhanSearchTextBox.SelectionStart = 0;
            this.TiepNhanSearchTextBox.ShortcutsEnabled = true;
            this.TiepNhanSearchTextBox.Size = new System.Drawing.Size(241, 23);
            this.TiepNhanSearchTextBox.TabIndex = 8;
            this.TiepNhanSearchTextBox.UseSelectable = true;
            this.TiepNhanSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TiepNhanSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(179, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 7;
            // 
            // TiepNhanListView
            // 
            this.TiepNhanListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TiepNhanListView.BackColor = System.Drawing.Color.MintCream;
            this.TiepNhanListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiepNhanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader36,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30});
            this.TiepNhanListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TiepNhanListView.FullRowSelect = true;
            this.TiepNhanListView.GridLines = true;
            this.TiepNhanListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TiepNhanListView.Location = new System.Drawing.Point(4, 107);
            this.TiepNhanListView.Name = "TiepNhanListView";
            this.TiepNhanListView.OwnerDraw = true;
            this.TiepNhanListView.Size = new System.Drawing.Size(1064, 454);
            this.TiepNhanListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.TiepNhanListView.TabIndex = 10;
            this.TiepNhanListView.UseCompatibleStateImageBehavior = false;
            this.TiepNhanListView.UseSelectable = true;
            this.TiepNhanListView.View = System.Windows.Forms.View.Details;
            this.TiepNhanListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.TiepNhanListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.TiepNhanListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.TiepNhanListView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Mã học sinh";
            this.columnHeader36.Width = 102;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Họ và tên";
            this.columnHeader26.Width = 210;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Giới tính";
            this.columnHeader27.Width = 70;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Ngày sinh";
            this.columnHeader28.Width = 154;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Địa chỉ";
            this.columnHeader29.Width = 319;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Email";
            this.columnHeader30.Width = 284;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 55);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(23, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "TIẾP NHẬN HỌC SINH";
            // 
            // TabDanhSachLop
            // 
            this.TabDanhSachLop.BackColor = System.Drawing.SystemColors.Control;
            this.TabDanhSachLop.Controls.Add(this.metroPanel1);
            this.TabDanhSachLop.Controls.Add(this.splitContainer1);
            this.TabDanhSachLop.Controls.Add(this.panel10);
            this.TabDanhSachLop.Controls.Add(this.label14);
            this.TabDanhSachLop.Controls.Add(this.label7);
            this.TabDanhSachLop.Controls.Add(this.panel6);
            this.TabDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDanhSachLop.HorizontalScrollbarBarColor = true;
            this.TabDanhSachLop.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDanhSachLop.HorizontalScrollbarSize = 10;
            this.TabDanhSachLop.Location = new System.Drawing.Point(4, 38);
            this.TabDanhSachLop.Name = "TabDanhSachLop";
            this.TabDanhSachLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabDanhSachLop.Size = new System.Drawing.Size(1071, 564);
            this.TabDanhSachLop.TabIndex = 2;
            this.TabDanhSachLop.Text = "📃 DANH SÁCH LỚP";
            this.TabDanhSachLop.VerticalScrollbarBarColor = true;
            this.TabDanhSachLop.VerticalScrollbarHighlightOnWheel = false;
            this.TabDanhSachLop.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.DanhSachLopThemHocSinhButton);
            this.metroPanel1.Controls.Add(this.DanhSachLopXoaHocSinhButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(514, 188);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(43, 380);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DanhSachLopThemHocSinhButton
            // 
            this.DanhSachLopThemHocSinhButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DanhSachLopThemHocSinhButton.BackColor = System.Drawing.Color.Honeydew;
            this.DanhSachLopThemHocSinhButton.BackgroundImage = global::QuanLyHocSinh_Nhom15.Properties.Resources.ImportIcon;
            this.DanhSachLopThemHocSinhButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DanhSachLopThemHocSinhButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopThemHocSinhButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DanhSachLopThemHocSinhButton.ForeColor = System.Drawing.Color.Black;
            this.DanhSachLopThemHocSinhButton.Location = new System.Drawing.Point(-2, 125);
            this.DanhSachLopThemHocSinhButton.Name = "DanhSachLopThemHocSinhButton";
            this.DanhSachLopThemHocSinhButton.Size = new System.Drawing.Size(45, 40);
            this.DanhSachLopThemHocSinhButton.TabIndex = 13;
            this.DanhSachLopThemHocSinhButton.UseCustomBackColor = true;
            this.DanhSachLopThemHocSinhButton.UseCustomForeColor = true;
            this.DanhSachLopThemHocSinhButton.UseSelectable = true;
            this.DanhSachLopThemHocSinhButton.Click += new System.EventHandler(this.DanhSachLopThemHocSinhButton_Click);
            // 
            // DanhSachLopXoaHocSinhButton
            // 
            this.DanhSachLopXoaHocSinhButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DanhSachLopXoaHocSinhButton.BackColor = System.Drawing.Color.Honeydew;
            this.DanhSachLopXoaHocSinhButton.BackgroundImage = global::QuanLyHocSinh_Nhom15.Properties.Resources.ExportIcon;
            this.DanhSachLopXoaHocSinhButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DanhSachLopXoaHocSinhButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopXoaHocSinhButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DanhSachLopXoaHocSinhButton.ForeColor = System.Drawing.Color.Black;
            this.DanhSachLopXoaHocSinhButton.Location = new System.Drawing.Point(-2, 201);
            this.DanhSachLopXoaHocSinhButton.Name = "DanhSachLopXoaHocSinhButton";
            this.DanhSachLopXoaHocSinhButton.Size = new System.Drawing.Size(45, 40);
            this.DanhSachLopXoaHocSinhButton.TabIndex = 14;
            this.DanhSachLopXoaHocSinhButton.UseCustomBackColor = true;
            this.DanhSachLopXoaHocSinhButton.UseCustomForeColor = true;
            this.DanhSachLopXoaHocSinhButton.UseSelectable = true;
            this.DanhSachLopXoaHocSinhButton.Click += new System.EventHandler(this.DanhSachLopXoaHocSinhButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 188);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DanhSachLopListView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DanhSachLopListView2);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 377);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.SplitterWidth = 43;
            this.splitContainer1.TabIndex = 33;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // DanhSachLopListView1
            // 
            this.DanhSachLopListView1.BackColor = System.Drawing.Color.MintCream;
            this.DanhSachLopListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DanhSachLopListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader37});
            this.DanhSachLopListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachLopListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DanhSachLopListView1.FullRowSelect = true;
            this.DanhSachLopListView1.GridLines = true;
            this.DanhSachLopListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DanhSachLopListView1.Location = new System.Drawing.Point(0, 0);
            this.DanhSachLopListView1.Margin = new System.Windows.Forms.Padding(0);
            this.DanhSachLopListView1.Name = "DanhSachLopListView1";
            this.DanhSachLopListView1.OwnerDraw = true;
            this.DanhSachLopListView1.Size = new System.Drawing.Size(514, 377);
            this.DanhSachLopListView1.Style = MetroFramework.MetroColorStyle.Teal;
            this.DanhSachLopListView1.TabIndex = 0;
            this.DanhSachLopListView1.UseCompatibleStateImageBehavior = false;
            this.DanhSachLopListView1.UseSelectable = true;
            this.DanhSachLopListView1.View = System.Windows.Forms.View.Details;
            this.DanhSachLopListView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.DanhSachLopListView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.DanhSachLopListView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.DanhSachLopListView1.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "STT";
            this.columnHeader13.Width = 39;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Họ tên";
            this.columnHeader14.Width = 210;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Giới tính";
            this.columnHeader15.Width = 70;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Năm sinh";
            this.columnHeader16.Width = 83;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Địa chỉ";
            this.columnHeader17.Width = 159;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "";
            this.columnHeader37.Width = 0;
            // 
            // DanhSachLopListView2
            // 
            this.DanhSachLopListView2.BackColor = System.Drawing.Color.MintCream;
            this.DanhSachLopListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DanhSachLopListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader35,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34});
            this.DanhSachLopListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachLopListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DanhSachLopListView2.FullRowSelect = true;
            this.DanhSachLopListView2.GridLines = true;
            this.DanhSachLopListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DanhSachLopListView2.Location = new System.Drawing.Point(0, 0);
            this.DanhSachLopListView2.Margin = new System.Windows.Forms.Padding(0);
            this.DanhSachLopListView2.Name = "DanhSachLopListView2";
            this.DanhSachLopListView2.OwnerDraw = true;
            this.DanhSachLopListView2.Size = new System.Drawing.Size(514, 377);
            this.DanhSachLopListView2.Style = MetroFramework.MetroColorStyle.Teal;
            this.DanhSachLopListView2.TabIndex = 0;
            this.DanhSachLopListView2.UseCompatibleStateImageBehavior = false;
            this.DanhSachLopListView2.UseSelectable = true;
            this.DanhSachLopListView2.View = System.Windows.Forms.View.Details;
            this.DanhSachLopListView2.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.DanhSachLopListView2.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.DanhSachLopListView2.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.DanhSachLopListView2.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "STT";
            this.columnHeader31.Width = 39;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Mã học sinh";
            this.columnHeader35.Width = 100;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Họ tên";
            this.columnHeader32.Width = 210;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Giới tính";
            this.columnHeader33.Width = 70;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Năm sinh";
            this.columnHeader34.Width = 83;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.LightCyan;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.DanhSachLopTimKiemButton);
            this.panel10.Controls.Add(this.DanhSachLopXemLopButton);
            this.panel10.Controls.Add(this.DanhSachLopSSLabel);
            this.panel10.Controls.Add(this.DanhSachLopSiSoLabel);
            this.panel10.Controls.Add(this.DanhSachLopTenLopComboBox);
            this.panel10.Controls.Add(this.DanhSachLopSearchTextBox);
            this.panel10.Controls.Add(this.metroLabel11);
            this.panel10.Controls.Add(this.metroLabel9);
            this.panel10.Controls.Add(this.metroLabel8);
            this.panel10.ForeColor = System.Drawing.Color.Teal;
            this.panel10.Location = new System.Drawing.Point(7, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1062, 91);
            this.panel10.TabIndex = 32;
            // 
            // DanhSachLopTimKiemButton
            // 
            this.DanhSachLopTimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhSachLopTimKiemButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopTimKiemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopTimKiemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopTimKiemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopTimKiemButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.search;
            this.DanhSachLopTimKiemButton.Location = new System.Drawing.Point(846, 12);
            this.DanhSachLopTimKiemButton.Name = "DanhSachLopTimKiemButton";
            this.DanhSachLopTimKiemButton.Size = new System.Drawing.Size(114, 35);
            this.DanhSachLopTimKiemButton.TabIndex = 31;
            this.DanhSachLopTimKiemButton.Text = "Tìm kiếm";
            this.DanhSachLopTimKiemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopTimKiemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopTimKiemButton.UseVisualStyleBackColor = false;
            this.DanhSachLopTimKiemButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DanhSachLopXemLopButton
            // 
            this.DanhSachLopXemLopButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopXemLopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopXemLopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopXemLopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopXemLopButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ViewIcon;
            this.DanhSachLopXemLopButton.Location = new System.Drawing.Point(238, 12);
            this.DanhSachLopXemLopButton.Name = "DanhSachLopXemLopButton";
            this.DanhSachLopXemLopButton.Size = new System.Drawing.Size(114, 35);
            this.DanhSachLopXemLopButton.TabIndex = 30;
            this.DanhSachLopXemLopButton.Text = "Xem lớp";
            this.DanhSachLopXemLopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopXemLopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopXemLopButton.UseVisualStyleBackColor = false;
            this.DanhSachLopXemLopButton.Click += new System.EventHandler(this.DanhSachLopXemLopButton_Click);
            // 
            // DanhSachLopSSLabel
            // 
            this.DanhSachLopSSLabel.AutoSize = true;
            this.DanhSachLopSSLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DanhSachLopSSLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DanhSachLopSSLabel.Location = new System.Drawing.Point(68, 59);
            this.DanhSachLopSSLabel.Name = "DanhSachLopSSLabel";
            this.DanhSachLopSSLabel.Size = new System.Drawing.Size(22, 25);
            this.DanhSachLopSSLabel.TabIndex = 29;
            this.DanhSachLopSSLabel.Text = "0";
            this.DanhSachLopSSLabel.UseCustomBackColor = true;
            this.DanhSachLopSSLabel.UseCustomForeColor = true;
            // 
            // DanhSachLopSiSoLabel
            // 
            this.DanhSachLopSiSoLabel.AutoSize = true;
            this.DanhSachLopSiSoLabel.BackColor = System.Drawing.Color.Transparent;
            this.DanhSachLopSiSoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopSiSoLabel.Location = new System.Drawing.Point(59, 59);
            this.DanhSachLopSiSoLabel.Name = "DanhSachLopSiSoLabel";
            this.DanhSachLopSiSoLabel.Size = new System.Drawing.Size(0, 16);
            this.DanhSachLopSiSoLabel.TabIndex = 27;
            // 
            // DanhSachLopTenLopComboBox
            // 
            this.DanhSachLopTenLopComboBox.FormatString = "Sub";
            this.DanhSachLopTenLopComboBox.FormattingEnabled = true;
            this.DanhSachLopTenLopComboBox.ItemHeight = 23;
            this.DanhSachLopTenLopComboBox.Location = new System.Drawing.Point(59, 12);
            this.DanhSachLopTenLopComboBox.Name = "DanhSachLopTenLopComboBox";
            this.DanhSachLopTenLopComboBox.PromptText = "Tên Lớp";
            this.DanhSachLopTenLopComboBox.Size = new System.Drawing.Size(158, 29);
            this.DanhSachLopTenLopComboBox.TabIndex = 26;
            this.DanhSachLopTenLopComboBox.UseSelectable = true;
            this.DanhSachLopTenLopComboBox.SelectedIndexChanged += new System.EventHandler(this.DanhSachLopTenLopComboBox_SelectedIndexChanged);
            // 
            // DanhSachLopSearchTextBox
            // 
            this.DanhSachLopSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.DanhSachLopSearchTextBox.CustomButton.Image = null;
            this.DanhSachLopSearchTextBox.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.DanhSachLopSearchTextBox.CustomButton.Name = "";
            this.DanhSachLopSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DanhSachLopSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DanhSachLopSearchTextBox.CustomButton.TabIndex = 1;
            this.DanhSachLopSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DanhSachLopSearchTextBox.CustomButton.UseSelectable = true;
            this.DanhSachLopSearchTextBox.CustomButton.Visible = false;
            this.DanhSachLopSearchTextBox.Lines = new string[0];
            this.DanhSachLopSearchTextBox.Location = new System.Drawing.Point(630, 18);
            this.DanhSachLopSearchTextBox.MaxLength = 32767;
            this.DanhSachLopSearchTextBox.Name = "DanhSachLopSearchTextBox";
            this.DanhSachLopSearchTextBox.PasswordChar = '\0';
            this.DanhSachLopSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DanhSachLopSearchTextBox.SelectedText = "";
            this.DanhSachLopSearchTextBox.SelectionLength = 0;
            this.DanhSachLopSearchTextBox.SelectionStart = 0;
            this.DanhSachLopSearchTextBox.ShortcutsEnabled = true;
            this.DanhSachLopSearchTextBox.Size = new System.Drawing.Size(192, 23);
            this.DanhSachLopSearchTextBox.TabIndex = 12;
            this.DanhSachLopSearchTextBox.UseSelectable = true;
            this.DanhSachLopSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DanhSachLopSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(550, 16);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 25);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "Họ tên :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(8, 12);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 25);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "Lớp :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(8, 59);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 25);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Sĩ số :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(2, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Danh sách lớp :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(554, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Danh sách học sinh tiếp nhận :";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.DanhSachLopXuatButton);
            this.panel6.Controls.Add(this.DanhSachLopQuanLiButton);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1066, 55);
            this.panel6.TabIndex = 10;
            // 
            // DanhSachLopXuatButton
            // 
            this.DanhSachLopXuatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhSachLopXuatButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopXuatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopXuatButton.FlatAppearance.BorderSize = 0;
            this.DanhSachLopXuatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopXuatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopXuatButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ExcelExportIcon;
            this.DanhSachLopXuatButton.Location = new System.Drawing.Point(889, 12);
            this.DanhSachLopXuatButton.Name = "DanhSachLopXuatButton";
            this.DanhSachLopXuatButton.Size = new System.Drawing.Size(158, 33);
            this.DanhSachLopXuatButton.TabIndex = 28;
            this.DanhSachLopXuatButton.Text = "Xuất file Excel";
            this.DanhSachLopXuatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopXuatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopXuatButton.UseVisualStyleBackColor = false;
            // 
            // DanhSachLopQuanLiButton
            // 
            this.DanhSachLopQuanLiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhSachLopQuanLiButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopQuanLiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DanhSachLopQuanLiButton.FlatAppearance.BorderSize = 0;
            this.DanhSachLopQuanLiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopQuanLiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopQuanLiButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DatabaseIcon;
            this.DanhSachLopQuanLiButton.Location = new System.Drawing.Point(733, 12);
            this.DanhSachLopQuanLiButton.Name = "DanhSachLopQuanLiButton";
            this.DanhSachLopQuanLiButton.Size = new System.Drawing.Size(150, 33);
            this.DanhSachLopQuanLiButton.TabIndex = 27;
            this.DanhSachLopQuanLiButton.Text = "Quản lí lớp học";
            this.DanhSachLopQuanLiButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopQuanLiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopQuanLiButton.UseVisualStyleBackColor = false;
            this.DanhSachLopQuanLiButton.Click += new System.EventHandler(this.DanhSachLopQuanLiButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "LẬP DANH SÁCH LỚP";
            // 
            // TabUser
            // 
            this.TabUser.Controls.Add(this.metroPanel5);
            this.TabUser.Controls.Add(this.metroPanel4);
            this.TabUser.Controls.Add(this.metroPanel2);
            this.TabUser.Controls.Add(this.TaiKhoanQuanLiTaiKhoanButton);
            this.TabUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TabUser.HorizontalScrollbarBarColor = true;
            this.TabUser.HorizontalScrollbarHighlightOnWheel = false;
            this.TabUser.HorizontalScrollbarSize = 10;
            this.TabUser.Location = new System.Drawing.Point(4, 38);
            this.TabUser.Name = "TabUser";
            this.TabUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabUser.Size = new System.Drawing.Size(1071, 564);
            this.TabUser.TabIndex = 5;
            this.TabUser.Text = "👤 TÀI KHOẢN";
            this.TabUser.VerticalScrollbarBarColor = true;
            this.TabUser.VerticalScrollbarHighlightOnWheel = false;
            this.TabUser.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel5.BackColor = System.Drawing.Color.LightCyan;
            this.metroPanel5.Controls.Add(this.metroPanel6);
            this.metroPanel5.Controls.Add(this.UserAddressLabel);
            this.metroPanel5.Controls.Add(this.UserGenderLabel);
            this.metroPanel5.Controls.Add(this.UserRoleLabel);
            this.metroPanel5.Controls.Add(this.UserSubjectLabel);
            this.metroPanel5.Controls.Add(this.UserDateofBirthLabel);
            this.metroPanel5.Controls.Add(this.UserNameLabel);
            this.metroPanel5.Controls.Add(this.UserIDLabel);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(450, 32);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(603, 465);
            this.metroPanel5.TabIndex = 32;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanel6.Controls.Add(this.label16);
            this.metroPanel6.Controls.Add(this.label8);
            this.metroPanel6.Controls.Add(this.label13);
            this.metroPanel6.Controls.Add(this.label12);
            this.metroPanel6.Controls.Add(this.label11);
            this.metroPanel6.Controls.Add(this.label10);
            this.metroPanel6.Controls.Add(this.label9);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 0);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(167, 465);
            this.metroPanel6.TabIndex = 32;
            this.metroPanel6.UseCustomBackColor = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(69, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 24);
            this.label16.TabIndex = 29;
            this.label16.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(56, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Giới tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(56, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "Chức vụ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(51, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Môn học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(40, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ngày sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(44, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Họ và tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(14, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã giáo viên:";
            // 
            // UserAddressLabel
            // 
            this.UserAddressLabel.AutoSize = true;
            this.UserAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAddressLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserAddressLabel.Location = new System.Drawing.Point(212, 262);
            this.UserAddressLabel.Name = "UserAddressLabel";
            this.UserAddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserAddressLabel.Size = new System.Drawing.Size(98, 16);
            this.UserAddressLabel.TabIndex = 31;
            this.UserAddressLabel.Text = "UserAddress";
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.AutoSize = true;
            this.UserGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGenderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserGenderLabel.Location = new System.Drawing.Point(213, 133);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserGenderLabel.Size = new System.Drawing.Size(91, 16);
            this.UserGenderLabel.TabIndex = 30;
            this.UserGenderLabel.Text = "UserGender";
            // 
            // UserRoleLabel
            // 
            this.UserRoleLabel.AutoSize = true;
            this.UserRoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserRoleLabel.Location = new System.Drawing.Point(212, 219);
            this.UserRoleLabel.Name = "UserRoleLabel";
            this.UserRoleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserRoleLabel.Size = new System.Drawing.Size(73, 16);
            this.UserRoleLabel.TabIndex = 13;
            this.UserRoleLabel.Text = "UserRole";
            // 
            // UserSubjectLabel
            // 
            this.UserSubjectLabel.AutoSize = true;
            this.UserSubjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSubjectLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserSubjectLabel.Location = new System.Drawing.Point(212, 175);
            this.UserSubjectLabel.Name = "UserSubjectLabel";
            this.UserSubjectLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserSubjectLabel.Size = new System.Drawing.Size(92, 16);
            this.UserSubjectLabel.TabIndex = 12;
            this.UserSubjectLabel.Text = "UserSubject";
            // 
            // UserDateofBirthLabel
            // 
            this.UserDateofBirthLabel.AutoSize = true;
            this.UserDateofBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserDateofBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDateofBirthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserDateofBirthLabel.Location = new System.Drawing.Point(212, 303);
            this.UserDateofBirthLabel.Name = "UserDateofBirthLabel";
            this.UserDateofBirthLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserDateofBirthLabel.Size = new System.Drawing.Size(117, 16);
            this.UserDateofBirthLabel.TabIndex = 11;
            this.UserDateofBirthLabel.Text = "UserDateofBirth";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserNameLabel.Location = new System.Drawing.Point(212, 90);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserNameLabel.Size = new System.Drawing.Size(81, 16);
            this.UserNameLabel.TabIndex = 10;
            this.UserNameLabel.Text = "UserName";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserIDLabel.Location = new System.Drawing.Point(212, 45);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserIDLabel.Size = new System.Drawing.Size(55, 16);
            this.UserIDLabel.TabIndex = 9;
            this.UserIDLabel.Text = "UserID";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.pictureBox1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(158, 116);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(134, 131);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.UseCustomForeColor = true;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.Male;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel2.BackColor = System.Drawing.Color.DarkCyan;
            this.metroPanel2.Controls.Add(this.TaiKhoanDangKiButton);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.TaiKhoanDangXuatButton);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(25, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(396, 566);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // TaiKhoanDangKiButton
            // 
            this.TaiKhoanDangKiButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TaiKhoanDangKiButton.BackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangKiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaiKhoanDangKiButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.TaiKhoanDangKiButton.FlatAppearance.BorderSize = 0;
            this.TaiKhoanDangKiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangKiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangKiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaiKhoanDangKiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanDangKiButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaiKhoanDangKiButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.SignUpIcon;
            this.TaiKhoanDangKiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaiKhoanDangKiButton.Location = new System.Drawing.Point(0, 435);
            this.TaiKhoanDangKiButton.Name = "TaiKhoanDangKiButton";
            this.TaiKhoanDangKiButton.Size = new System.Drawing.Size(396, 37);
            this.TaiKhoanDangKiButton.TabIndex = 4;
            this.TaiKhoanDangKiButton.Text = "  Đăng kí";
            this.TaiKhoanDangKiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaiKhoanDangKiButton.UseVisualStyleBackColor = false;
            this.TaiKhoanDangKiButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(396, 181);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // TaiKhoanDangXuatButton
            // 
            this.TaiKhoanDangXuatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TaiKhoanDangXuatButton.BackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangXuatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaiKhoanDangXuatButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.TaiKhoanDangXuatButton.FlatAppearance.BorderSize = 0;
            this.TaiKhoanDangXuatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangXuatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TaiKhoanDangXuatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaiKhoanDangXuatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanDangXuatButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaiKhoanDangXuatButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.SignOutIcon;
            this.TaiKhoanDangXuatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaiKhoanDangXuatButton.Location = new System.Drawing.Point(0, 478);
            this.TaiKhoanDangXuatButton.Name = "TaiKhoanDangXuatButton";
            this.TaiKhoanDangXuatButton.Size = new System.Drawing.Size(396, 37);
            this.TaiKhoanDangXuatButton.TabIndex = 2;
            this.TaiKhoanDangXuatButton.Text = "  Đăng xuất";
            this.TaiKhoanDangXuatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaiKhoanDangXuatButton.UseVisualStyleBackColor = false;
            this.TaiKhoanDangXuatButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // TaiKhoanQuanLiTaiKhoanButton
            // 
            this.TaiKhoanQuanLiTaiKhoanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaiKhoanQuanLiTaiKhoanButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaiKhoanQuanLiTaiKhoanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaiKhoanQuanLiTaiKhoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaiKhoanQuanLiTaiKhoanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanQuanLiTaiKhoanButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DatabaseIcon;
            this.TaiKhoanQuanLiTaiKhoanButton.Location = new System.Drawing.Point(883, 517);
            this.TaiKhoanQuanLiTaiKhoanButton.Name = "TaiKhoanQuanLiTaiKhoanButton";
            this.TaiKhoanQuanLiTaiKhoanButton.Size = new System.Drawing.Size(170, 33);
            this.TaiKhoanQuanLiTaiKhoanButton.TabIndex = 33;
            this.TaiKhoanQuanLiTaiKhoanButton.Text = "Quản lí tài khoản";
            this.TaiKhoanQuanLiTaiKhoanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaiKhoanQuanLiTaiKhoanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaiKhoanQuanLiTaiKhoanButton.UseVisualStyleBackColor = false;
            this.TaiKhoanQuanLiTaiKhoanButton.Click += new System.EventHandler(this.QuanLiTaiKhoanButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Họ và tên";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Giới tính";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 184;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1081, 655);
            this.ControlBox = false;
            this.Controls.Add(this.AppTabControl);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Padding = new System.Windows.Forms.Padding(1, 48, 1, 1);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.App_Load);
            this.SizeChanged += new System.EventHandler(this.App_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AppTabControl.ResumeLayout(false);
            this.TabTraCuu.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuNamHoc)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TabBaoCao.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoNamHocNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TabTongKet.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TongKetNamHoc)).EndInit();
            this.TongKetMonHocKiGroupBox.ResumeLayout(false);
            this.TongKetMonHocKiGroupBox.PerformLayout();
            this.TongKetMonHocCaHocKiGroupBox.ResumeLayout(false);
            this.TongKetMonHocCaHocKiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TongKetDiemDatNumericBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.TabTiepNhan.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanMaxAgeNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanMinAgeNumericBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabDanhSachLop.ResumeLayout(false);
            this.TabDanhSachLop.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.TabUser.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private MetroFramework.Controls.MetroTabControl AppTabControl;
        private MetroFramework.Controls.MetroTabPage TabBaoCao;
        private MetroFramework.Controls.MetroTabPage TabTongKet;
        private MetroFramework.Controls.MetroTabPage TabDanhSachLop;
        private MetroFramework.Controls.MetroTabPage TabUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox BaoCaoMonHocComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox BaoCaoHocKiComboBox;
        private MetroFramework.Controls.MetroTabPage TabTraCuu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox TraCuuTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroListView TraCuuListView;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox BaoCaoLopComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroListView TongKetListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton DanhSachLopXoaHocSinhButton;
        private MetroFramework.Controls.MetroTextBox DanhSachLopSearchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTabPage TabTiepNhan;
        private MetroFramework.Controls.MetroTextBox TiepNhanSearchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView DanhSachLopListView2;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private MetroFramework.Controls.MetroListView DanhSachLopListView1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroListView TiepNhanListView;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private MetroFramework.Controls.MetroListView BaoCaoListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private MetroFramework.Controls.MetroComboBox TongKetMonComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button TaiKhoanDangXuatButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label UserDateofBirthLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label UserRoleLabel;
        private System.Windows.Forms.Label UserSubjectLabel;
        private System.Windows.Forms.Button TaiKhoanDangKiButton;
        private System.Windows.Forms.NumericUpDown BaoCaoNamHocNumericUpDown;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.NumericUpDown TiepNhanMaxAgeNumericBox;
        private System.Windows.Forms.NumericUpDown TiepNhanMinAgeNumericBox;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroComboBox DanhSachLopTenLopComboBox;
        private System.Windows.Forms.Label DanhSachLopSiSoLabel;
        private System.Windows.Forms.NumericUpDown TongKetDiemDatNumericBox;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroButton DanhSachLopThemHocSinhButton;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private MetroFramework.Controls.MetroLabel DanhSachLopSSLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label UserAddressLabel;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button TraCuuTimKiemButton;
        private System.Windows.Forms.Button BaoCaoThemBangDiem;
        private System.Windows.Forms.Button BaoCaoXoaBangDiem;
        private System.Windows.Forms.Button BaoCaoXemBangDiem;
        private System.Windows.Forms.Button BaoCaoXoaDiem;
        private System.Windows.Forms.Button BaoCaoThemSuaDiem;
        private System.Windows.Forms.Button TongKetXem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.GroupBox TongKetMonHocCaHocKiGroupBox;
        private System.Windows.Forms.RadioButton CaHocKiRadioButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox TongKetMonHocKiGroupBox;
        private System.Windows.Forms.RadioButton HocKi2RadioButton;
        private System.Windows.Forms.RadioButton HocKi1RadioButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button TiepNhanThemSuaHocSinh;
        private System.Windows.Forms.Button TiepNhanTimKiemHocSinh;
        private System.Windows.Forms.Button TiepNhanXoaHocSinh;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button DanhSachLopXemLopButton;
        private System.Windows.Forms.Button DanhSachLopTimKiemButton;
        private Button QuanLyMonHocButton;
        private Button DanhSachLopQuanLiButton;
        private Button TaiKhoanQuanLiTaiKhoanButton;
        private Panel panel10;
        private NumericUpDown TraCuuNamHoc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Button MaximizeRestoreButton;
        private Button MinimizeButton;
        private SplitContainer splitContainer1;
        private NumericUpDown TongKetNamHoc;
        private RadioButton MonHocRadioButton;
        private Button BaoCaoMonXuatButton;
        private Button TongKetXuatButton;
        private Button DanhSachLopXuatButton;
        private Panel panel11;
    }
}

