namespace QuanLyHocSinh_Nhom15
{
    partial class LopForm
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
            this.DanhSachLopHocListView = new MetroFramework.Controls.MetroListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Siso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDGVCN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DanhSachLopHocTenLopTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DanhSachLopHocNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DanhSachLopHocThemSuaLopButton = new System.Windows.Forms.Button();
            this.DanhSachLopHocXoalopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DanhSachLopHocGVCNComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KhoiGroupBox = new System.Windows.Forms.GroupBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.NuRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.NamRadioButton = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachLopHocNumericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.KhoiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách lớp học";
            // 
            // DanhSachLopHocListView
            // 
            this.DanhSachLopHocListView.BackColor = System.Drawing.Color.MintCream;
            this.DanhSachLopHocListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DanhSachLopHocListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDLop,
            this.TenLop,
            this.Siso,
            this.IDGVCN});
            this.DanhSachLopHocListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DanhSachLopHocListView.FullRowSelect = true;
            this.DanhSachLopHocListView.GridLines = true;
            this.DanhSachLopHocListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DanhSachLopHocListView.Location = new System.Drawing.Point(28, 74);
            this.DanhSachLopHocListView.Name = "DanhSachLopHocListView";
            this.DanhSachLopHocListView.OwnerDraw = true;
            this.DanhSachLopHocListView.Size = new System.Drawing.Size(355, 438);
            this.DanhSachLopHocListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.DanhSachLopHocListView.TabIndex = 9;
            this.DanhSachLopHocListView.UseCompatibleStateImageBehavior = false;
            this.DanhSachLopHocListView.UseCustomBackColor = true;
            this.DanhSachLopHocListView.UseCustomForeColor = true;
            this.DanhSachLopHocListView.UseSelectable = true;
            this.DanhSachLopHocListView.UseStyleColors = true;
            this.DanhSachLopHocListView.View = System.Windows.Forms.View.Details;
            this.DanhSachLopHocListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            this.DanhSachLopHocListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.DanhSachLopHocListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.DanhSachLopHocListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DanhSachLopHocListView_ItemSelectionChanged);
            this.DanhSachLopHocListView.SelectedIndexChanged += new System.EventHandler(this.DanhSachLopHocListView_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // IDLop
            // 
            this.IDLop.Text = "ID lớp";
            // 
            // TenLop
            // 
            this.TenLop.Text = "Tên lớp";
            this.TenLop.Width = 92;
            // 
            // Siso
            // 
            this.Siso.Text = "Sĩ số";
            // 
            // IDGVCN
            // 
            this.IDGVCN.Text = "ID GVCN";
            this.IDGVCN.Width = 81;
            // 
            // DanhSachLopHocTenLopTextBox
            // 
            // 
            // 
            // 
            this.DanhSachLopHocTenLopTextBox.CustomButton.Image = null;
            this.DanhSachLopHocTenLopTextBox.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.DanhSachLopHocTenLopTextBox.CustomButton.Name = "";
            this.DanhSachLopHocTenLopTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DanhSachLopHocTenLopTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DanhSachLopHocTenLopTextBox.CustomButton.TabIndex = 1;
            this.DanhSachLopHocTenLopTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DanhSachLopHocTenLopTextBox.CustomButton.UseSelectable = true;
            this.DanhSachLopHocTenLopTextBox.CustomButton.Visible = false;
            this.DanhSachLopHocTenLopTextBox.Lines = new string[0];
            this.DanhSachLopHocTenLopTextBox.Location = new System.Drawing.Point(26, 28);
            this.DanhSachLopHocTenLopTextBox.MaxLength = 32767;
            this.DanhSachLopHocTenLopTextBox.Name = "DanhSachLopHocTenLopTextBox";
            this.DanhSachLopHocTenLopTextBox.PasswordChar = '\0';
            this.DanhSachLopHocTenLopTextBox.PromptText = "Tên lớp";
            this.DanhSachLopHocTenLopTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DanhSachLopHocTenLopTextBox.SelectedText = "";
            this.DanhSachLopHocTenLopTextBox.SelectionLength = 0;
            this.DanhSachLopHocTenLopTextBox.SelectionStart = 0;
            this.DanhSachLopHocTenLopTextBox.ShortcutsEnabled = true;
            this.DanhSachLopHocTenLopTextBox.Size = new System.Drawing.Size(121, 23);
            this.DanhSachLopHocTenLopTextBox.TabIndex = 10;
            this.DanhSachLopHocTenLopTextBox.UseSelectable = true;
            this.DanhSachLopHocTenLopTextBox.WaterMark = "Tên lớp";
            this.DanhSachLopHocTenLopTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DanhSachLopHocTenLopTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DanhSachLopHocNumericUpDown1
            // 
            this.DanhSachLopHocNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DanhSachLopHocNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopHocNumericUpDown1.Location = new System.Drawing.Point(26, 389);
            this.DanhSachLopHocNumericUpDown1.Name = "DanhSachLopHocNumericUpDown1";
            this.DanhSachLopHocNumericUpDown1.Size = new System.Drawing.Size(121, 27);
            this.DanhSachLopHocNumericUpDown1.TabIndex = 11;
            this.DanhSachLopHocNumericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.DanhSachLopHocNumericUpDown1.ValueChanged += new System.EventHandler(this.DanhSachLopHocNumericUpDown1_ValueChanged);
            // 
            // DanhSachLopHocThemSuaLopButton
            // 
            this.DanhSachLopHocThemSuaLopButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopHocThemSuaLopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopHocThemSuaLopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopHocThemSuaLopButton.ForeColor = System.Drawing.Color.Teal;
            this.DanhSachLopHocThemSuaLopButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.AddIcon;
            this.DanhSachLopHocThemSuaLopButton.Location = new System.Drawing.Point(26, 265);
            this.DanhSachLopHocThemSuaLopButton.Name = "DanhSachLopHocThemSuaLopButton";
            this.DanhSachLopHocThemSuaLopButton.Size = new System.Drawing.Size(121, 35);
            this.DanhSachLopHocThemSuaLopButton.TabIndex = 12;
            this.DanhSachLopHocThemSuaLopButton.Text = "Thêm/Sửa";
            this.DanhSachLopHocThemSuaLopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopHocThemSuaLopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopHocThemSuaLopButton.UseVisualStyleBackColor = false;
            this.DanhSachLopHocThemSuaLopButton.Click += new System.EventHandler(this.DanhSachLopHocThemSuaLopButton_Click);
            // 
            // DanhSachLopHocXoalopButton
            // 
            this.DanhSachLopHocXoalopButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachLopHocXoalopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopHocXoalopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopHocXoalopButton.ForeColor = System.Drawing.Color.Teal;
            this.DanhSachLopHocXoalopButton.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.DeleteIcon;
            this.DanhSachLopHocXoalopButton.Location = new System.Drawing.Point(26, 326);
            this.DanhSachLopHocXoalopButton.Name = "DanhSachLopHocXoalopButton";
            this.DanhSachLopHocXoalopButton.Size = new System.Drawing.Size(121, 35);
            this.DanhSachLopHocXoalopButton.TabIndex = 13;
            this.DanhSachLopHocXoalopButton.Text = "Xóa lớp";
            this.DanhSachLopHocXoalopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanhSachLopHocXoalopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DanhSachLopHocXoalopButton.UseVisualStyleBackColor = false;
            this.DanhSachLopHocXoalopButton.Click += new System.EventHandler(this.DanhSachLopHocXoalopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(41, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sĩ số tối đa";
            // 
            // DanhSachLopHocGVCNComboBox
            // 
            this.DanhSachLopHocGVCNComboBox.FormattingEnabled = true;
            this.DanhSachLopHocGVCNComboBox.ItemHeight = 23;
            this.DanhSachLopHocGVCNComboBox.Location = new System.Drawing.Point(26, 200);
            this.DanhSachLopHocGVCNComboBox.Name = "DanhSachLopHocGVCNComboBox";
            this.DanhSachLopHocGVCNComboBox.PromptText = "GVCN";
            this.DanhSachLopHocGVCNComboBox.Size = new System.Drawing.Size(121, 29);
            this.DanhSachLopHocGVCNComboBox.TabIndex = 27;
            this.DanhSachLopHocGVCNComboBox.UseSelectable = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Teal;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(553, -2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 28;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KhoiGroupBox);
            this.panel1.Controls.Add(this.DanhSachLopHocGVCNComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DanhSachLopHocXoalopButton);
            this.panel1.Controls.Add(this.DanhSachLopHocThemSuaLopButton);
            this.panel1.Controls.Add(this.DanhSachLopHocNumericUpDown1);
            this.panel1.Controls.Add(this.DanhSachLopHocTenLopTextBox);
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(389, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 438);
            this.panel1.TabIndex = 30;
            // 
            // KhoiGroupBox
            // 
            this.KhoiGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.KhoiGroupBox.Controls.Add(this.metroRadioButton1);
            this.KhoiGroupBox.Controls.Add(this.NuRadioButton);
            this.KhoiGroupBox.Controls.Add(this.NamRadioButton);
            this.KhoiGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoiGroupBox.ForeColor = System.Drawing.Color.Teal;
            this.KhoiGroupBox.Location = new System.Drawing.Point(26, 70);
            this.KhoiGroupBox.Name = "KhoiGroupBox";
            this.KhoiGroupBox.Size = new System.Drawing.Size(121, 110);
            this.KhoiGroupBox.TabIndex = 28;
            this.KhoiGroupBox.TabStop = false;
            this.KhoiGroupBox.Text = "Khối:";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.Location = new System.Drawing.Point(6, 71);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(71, 30);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton1.TabIndex = 18;
            this.metroRadioButton1.Tag = "";
            this.metroRadioButton1.Text = "12";
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseCustomForeColor = true;
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.UseStyleColors = true;
            // 
            // NuRadioButton
            // 
            this.NuRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NuRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.NuRadioButton.Location = new System.Drawing.Point(6, 44);
            this.NuRadioButton.Name = "NuRadioButton";
            this.NuRadioButton.Size = new System.Drawing.Size(71, 30);
            this.NuRadioButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.NuRadioButton.TabIndex = 17;
            this.NuRadioButton.Tag = "";
            this.NuRadioButton.Text = "11";
            this.NuRadioButton.UseCustomBackColor = true;
            this.NuRadioButton.UseCustomForeColor = true;
            this.NuRadioButton.UseSelectable = true;
            this.NuRadioButton.UseStyleColors = true;
            // 
            // NamRadioButton
            // 
            this.NamRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NamRadioButton.Checked = true;
            this.NamRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.NamRadioButton.Location = new System.Drawing.Point(6, 18);
            this.NamRadioButton.Name = "NamRadioButton";
            this.NamRadioButton.Size = new System.Drawing.Size(71, 30);
            this.NamRadioButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.NamRadioButton.TabIndex = 16;
            this.NamRadioButton.TabStop = true;
            this.NamRadioButton.Tag = "";
            this.NamRadioButton.Text = "10";
            this.NamRadioButton.UseCustomBackColor = true;
            this.NamRadioButton.UseCustomForeColor = true;
            this.NamRadioButton.UseSelectable = true;
            this.NamRadioButton.UseStyleColors = true;
            // 
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(582, 535);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DanhSachLopHocListView);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LopForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "LopForm";
            this.VisibleChanged += new System.EventHandler(this.LopForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachLopHocNumericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.KhoiGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroListView DanhSachLopHocListView;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader IDLop;
        private System.Windows.Forms.ColumnHeader TenLop;
        private System.Windows.Forms.ColumnHeader Siso;
        private System.Windows.Forms.ColumnHeader IDGVCN;
        private MetroFramework.Controls.MetroTextBox DanhSachLopHocTenLopTextBox;
        private System.Windows.Forms.NumericUpDown DanhSachLopHocNumericUpDown1;
        private System.Windows.Forms.Button DanhSachLopHocThemSuaLopButton;
        private System.Windows.Forms.Button DanhSachLopHocXoalopButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox DanhSachLopHocGVCNComboBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox KhoiGroupBox;
        private MetroFramework.Controls.MetroRadioButton NuRadioButton;
        private MetroFramework.Controls.MetroRadioButton NamRadioButton;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
    }
}