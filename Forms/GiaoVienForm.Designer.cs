namespace QuanLyHocSinh_Nhom15
{
    partial class GiaoVienForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDGiaoVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vai_Tro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaiKhoanQuanLiTaiKhoanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách tài khoản giáo viên";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Teal;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(972, -2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.MintCream;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDGiaoVien,
            this.UserName,
            this.Password,
            this.Vai_Tro,
            this.HoTen,
            this.columnHeader1,
            this.IDMonHoc,
            this.NgaySinh,
            this.DiaChi});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(11, 68);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(980, 451);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroListView1.TabIndex = 12;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.metroListView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.metroListView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // IDGiaoVien
            // 
            this.IDGiaoVien.Text = "ID Giáo viên";
            this.IDGiaoVien.Width = 100;
            // 
            // UserName
            // 
            this.UserName.Text = "Tên tài khoản";
            this.UserName.Width = 150;
            // 
            // Password
            // 
            this.Password.Text = "Mật khẩu";
            this.Password.Width = 200;
            // 
            // Vai_Tro
            // 
            this.Vai_Tro.Text = "Vai trò";
            this.Vai_Tro.Width = 200;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ và tên";
            this.HoTen.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Giới tính";
            this.columnHeader1.Width = 80;
            // 
            // IDMonHoc
            // 
            this.IDMonHoc.Text = "Môn học";
            this.IDMonHoc.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 200;
            // 
            // TaiKhoanQuanLiTaiKhoanButton
            // 
            this.TaiKhoanQuanLiTaiKhoanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaiKhoanQuanLiTaiKhoanButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaiKhoanQuanLiTaiKhoanButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.TaiKhoanQuanLiTaiKhoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaiKhoanQuanLiTaiKhoanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanQuanLiTaiKhoanButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.SettingIcon;
            this.TaiKhoanQuanLiTaiKhoanButton.Location = new System.Drawing.Point(331, 17);
            this.TaiKhoanQuanLiTaiKhoanButton.Name = "TaiKhoanQuanLiTaiKhoanButton";
            this.TaiKhoanQuanLiTaiKhoanButton.Size = new System.Drawing.Size(199, 33);
            this.TaiKhoanQuanLiTaiKhoanButton.TabIndex = 34;
            this.TaiKhoanQuanLiTaiKhoanButton.Text = "Chỉnh sửa thông tin";
            this.TaiKhoanQuanLiTaiKhoanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaiKhoanQuanLiTaiKhoanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TaiKhoanQuanLiTaiKhoanButton.UseVisualStyleBackColor = false;
            this.TaiKhoanQuanLiTaiKhoanButton.Click += new System.EventHandler(this.TaiKhoanQuanLiTaiKhoanButton_Click);
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1002, 527);
            this.ControlBox = false;
            this.Controls.Add(this.TaiKhoanQuanLiTaiKhoanButton);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiaoVienForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "GiaoVienForm";
            this.VisibleChanged += new System.EventHandler(this.GiaoVienForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader IDGiaoVien;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Vai_Tro;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader IDMonHoc;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button TaiKhoanQuanLiTaiKhoanButton;
    }
}