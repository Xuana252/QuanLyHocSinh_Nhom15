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
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachLopHocNumericUpDown1)).BeginInit();
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
            this.DanhSachLopHocListView.Size = new System.Drawing.Size(353, 438);
            this.DanhSachLopHocListView.Style = MetroFramework.MetroColorStyle.Teal;
            this.DanhSachLopHocListView.TabIndex = 9;
            this.DanhSachLopHocListView.UseCompatibleStateImageBehavior = false;
            this.DanhSachLopHocListView.UseCustomBackColor = true;
            this.DanhSachLopHocListView.UseCustomForeColor = true;
            this.DanhSachLopHocListView.UseSelectable = true;
            this.DanhSachLopHocListView.UseStyleColors = true;
            this.DanhSachLopHocListView.View = System.Windows.Forms.View.Details;
            this.DanhSachLopHocListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.metroListView1_ColumnWidthChanging);
            this.DanhSachLopHocListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.metroListView1_DrawItem);
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
            this.DanhSachLopHocTenLopTextBox.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.DanhSachLopHocTenLopTextBox.CustomButton.Name = "";
            this.DanhSachLopHocTenLopTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DanhSachLopHocTenLopTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DanhSachLopHocTenLopTextBox.CustomButton.TabIndex = 1;
            this.DanhSachLopHocTenLopTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DanhSachLopHocTenLopTextBox.CustomButton.UseSelectable = true;
            this.DanhSachLopHocTenLopTextBox.CustomButton.Visible = false;
            this.DanhSachLopHocTenLopTextBox.Lines = new string[0];
            this.DanhSachLopHocTenLopTextBox.Location = new System.Drawing.Point(438, 146);
            this.DanhSachLopHocTenLopTextBox.MaxLength = 32767;
            this.DanhSachLopHocTenLopTextBox.Name = "DanhSachLopHocTenLopTextBox";
            this.DanhSachLopHocTenLopTextBox.PasswordChar = '\0';
            this.DanhSachLopHocTenLopTextBox.PromptText = "Tên lớp";
            this.DanhSachLopHocTenLopTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DanhSachLopHocTenLopTextBox.SelectedText = "";
            this.DanhSachLopHocTenLopTextBox.SelectionLength = 0;
            this.DanhSachLopHocTenLopTextBox.SelectionStart = 0;
            this.DanhSachLopHocTenLopTextBox.ShortcutsEnabled = true;
            this.DanhSachLopHocTenLopTextBox.Size = new System.Drawing.Size(82, 23);
            this.DanhSachLopHocTenLopTextBox.TabIndex = 10;
            this.DanhSachLopHocTenLopTextBox.UseSelectable = true;
            this.DanhSachLopHocTenLopTextBox.WaterMark = "Tên lớp";
            this.DanhSachLopHocTenLopTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DanhSachLopHocTenLopTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DanhSachLopHocNumericUpDown1
            // 
            this.DanhSachLopHocNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DanhSachLopHocNumericUpDown1.Location = new System.Drawing.Point(461, 492);
            this.DanhSachLopHocNumericUpDown1.Name = "DanhSachLopHocNumericUpDown1";
            this.DanhSachLopHocNumericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.DanhSachLopHocNumericUpDown1.TabIndex = 11;
            this.DanhSachLopHocNumericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // DanhSachLopHocThemSuaLopButton
            // 
            this.DanhSachLopHocThemSuaLopButton.BackColor = System.Drawing.Color.Teal;
            this.DanhSachLopHocThemSuaLopButton.FlatAppearance.BorderSize = 0;
            this.DanhSachLopHocThemSuaLopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopHocThemSuaLopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopHocThemSuaLopButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DanhSachLopHocThemSuaLopButton.Location = new System.Drawing.Point(438, 265);
            this.DanhSachLopHocThemSuaLopButton.Name = "DanhSachLopHocThemSuaLopButton";
            this.DanhSachLopHocThemSuaLopButton.Size = new System.Drawing.Size(82, 32);
            this.DanhSachLopHocThemSuaLopButton.TabIndex = 12;
            this.DanhSachLopHocThemSuaLopButton.Text = "Thêm lớp";
            this.DanhSachLopHocThemSuaLopButton.UseVisualStyleBackColor = false;
            // 
            // DanhSachLopHocXoalopButton
            // 
            this.DanhSachLopHocXoalopButton.BackColor = System.Drawing.Color.Teal;
            this.DanhSachLopHocXoalopButton.FlatAppearance.BorderSize = 0;
            this.DanhSachLopHocXoalopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DanhSachLopHocXoalopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachLopHocXoalopButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DanhSachLopHocXoalopButton.Location = new System.Drawing.Point(438, 326);
            this.DanhSachLopHocXoalopButton.Name = "DanhSachLopHocXoalopButton";
            this.DanhSachLopHocXoalopButton.Size = new System.Drawing.Size(82, 32);
            this.DanhSachLopHocXoalopButton.TabIndex = 13;
            this.DanhSachLopHocXoalopButton.Text = "Xóa lớp";
            this.DanhSachLopHocXoalopButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(458, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sĩ số tối đa";
            // 
            // DanhSachLopHocGVCNComboBox
            // 
            this.DanhSachLopHocGVCNComboBox.FormattingEnabled = true;
            this.DanhSachLopHocGVCNComboBox.ItemHeight = 23;
            this.DanhSachLopHocGVCNComboBox.Location = new System.Drawing.Point(438, 194);
            this.DanhSachLopHocGVCNComboBox.Name = "DanhSachLopHocGVCNComboBox";
            this.DanhSachLopHocGVCNComboBox.PromptText = "GVCN";
            this.DanhSachLopHocGVCNComboBox.Size = new System.Drawing.Size(82, 29);
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
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(582, 535);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DanhSachLopHocGVCNComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DanhSachLopHocXoalopButton);
            this.Controls.Add(this.DanhSachLopHocThemSuaLopButton);
            this.Controls.Add(this.DanhSachLopHocNumericUpDown1);
            this.Controls.Add(this.DanhSachLopHocTenLopTextBox);
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
            this.Shown += new System.EventHandler(this.LopForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachLopHocNumericUpDown1)).EndInit();
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
    }
}