namespace QuanLyHocSinh_Nhom15
{
    partial class MonHocForm
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.STTMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThemMonButton = new System.Windows.Forms.Button();
            this.XoaMonButton = new System.Windows.Forms.Button();
            this.IDMonTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TenMonTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.MintCream;
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STTMon,
            this.IDMon,
            this.TenMon});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(23, 63);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(215, 375);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.UseStyleColors = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // STTMon
            // 
            this.STTMon.Text = "STT";
            // 
            // IDMon
            // 
            this.IDMon.Text = "ID";
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên môn";
            this.TenMon.Width = 92;
            // 
            // ThemMonButton
            // 
            this.ThemMonButton.BackColor = System.Drawing.Color.Teal;
            this.ThemMonButton.FlatAppearance.BorderSize = 0;
            this.ThemMonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemMonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemMonButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ThemMonButton.Location = new System.Drawing.Point(276, 224);
            this.ThemMonButton.Name = "ThemMonButton";
            this.ThemMonButton.Size = new System.Drawing.Size(82, 32);
            this.ThemMonButton.TabIndex = 3;
            this.ThemMonButton.Text = "Thêm";
            this.ThemMonButton.UseVisualStyleBackColor = false;
            // 
            // XoaMonButton
            // 
            this.XoaMonButton.BackColor = System.Drawing.Color.Teal;
            this.XoaMonButton.FlatAppearance.BorderSize = 0;
            this.XoaMonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaMonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaMonButton.ForeColor = System.Drawing.SystemColors.Window;
            this.XoaMonButton.Location = new System.Drawing.Point(276, 282);
            this.XoaMonButton.Name = "XoaMonButton";
            this.XoaMonButton.Size = new System.Drawing.Size(82, 32);
            this.XoaMonButton.TabIndex = 4;
            this.XoaMonButton.Text = "Xóa";
            this.XoaMonButton.UseVisualStyleBackColor = false;
            // 
            // IDMonTextBox
            // 
            // 
            // 
            // 
            this.IDMonTextBox.CustomButton.Image = null;
            this.IDMonTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.IDMonTextBox.CustomButton.Name = "";
            this.IDMonTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IDMonTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDMonTextBox.CustomButton.TabIndex = 1;
            this.IDMonTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDMonTextBox.CustomButton.UseSelectable = true;
            this.IDMonTextBox.CustomButton.Visible = false;
            this.IDMonTextBox.Lines = new string[0];
            this.IDMonTextBox.Location = new System.Drawing.Point(264, 105);
            this.IDMonTextBox.MaxLength = 32767;
            this.IDMonTextBox.Name = "IDMonTextBox";
            this.IDMonTextBox.PasswordChar = '\0';
            this.IDMonTextBox.PromptText = "ID";
            this.IDMonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDMonTextBox.SelectedText = "";
            this.IDMonTextBox.SelectionLength = 0;
            this.IDMonTextBox.SelectionStart = 0;
            this.IDMonTextBox.ShortcutsEnabled = true;
            this.IDMonTextBox.Size = new System.Drawing.Size(94, 23);
            this.IDMonTextBox.TabIndex = 5;
            this.IDMonTextBox.UseSelectable = true;
            this.IDMonTextBox.WaterMark = "ID";
            this.IDMonTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDMonTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TenMonTextBox
            // 
            // 
            // 
            // 
            this.TenMonTextBox.CustomButton.Image = null;
            this.TenMonTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TenMonTextBox.CustomButton.Name = "";
            this.TenMonTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TenMonTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TenMonTextBox.CustomButton.TabIndex = 1;
            this.TenMonTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TenMonTextBox.CustomButton.UseSelectable = true;
            this.TenMonTextBox.CustomButton.Visible = false;
            this.TenMonTextBox.Lines = new string[0];
            this.TenMonTextBox.Location = new System.Drawing.Point(264, 159);
            this.TenMonTextBox.MaxLength = 32767;
            this.TenMonTextBox.Name = "TenMonTextBox";
            this.TenMonTextBox.PasswordChar = '\0';
            this.TenMonTextBox.PromptText = "Tên môn";
            this.TenMonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TenMonTextBox.SelectedText = "";
            this.TenMonTextBox.SelectionLength = 0;
            this.TenMonTextBox.SelectionStart = 0;
            this.TenMonTextBox.ShortcutsEnabled = true;
            this.TenMonTextBox.Size = new System.Drawing.Size(94, 23);
            this.TenMonTextBox.TabIndex = 6;
            this.TenMonTextBox.UseSelectable = true;
            this.TenMonTextBox.WaterMark = "Tên môn";
            this.TenMonTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TenMonTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subjects list";
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TenMonTextBox);
            this.Controls.Add(this.IDMonTextBox);
            this.Controls.Add(this.XoaMonButton);
            this.Controls.Add(this.ThemMonButton);
            this.Controls.Add(this.metroListView1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonHocForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "MonHocForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader STTMon;
        private System.Windows.Forms.ColumnHeader IDMon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.Button ThemMonButton;
        private System.Windows.Forms.Button XoaMonButton;
        private MetroFramework.Controls.MetroTextBox IDMonTextBox;
        private MetroFramework.Controls.MetroTextBox TenMonTextBox;
        private System.Windows.Forms.Label label1;
    }
}