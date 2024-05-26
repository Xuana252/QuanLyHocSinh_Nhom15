namespace QuanLyHocSinh_Nhom15
{
    partial class HocSinhForm
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
            this.HocSinhHoTenTextBox = new MetroFramework.Controls.MetroTextBox();
            this.HocSinhEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.HocSinhNgaySinhDateTime = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HocSinhDiaChiTextBox = new System.Windows.Forms.RichTextBox();
            this.HocSinhGioiTinhComboBox = new MetroFramework.Controls.MetroComboBox();
            this.HocSinhOKButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HocSinhHoTenTextBox
            // 
            // 
            // 
            // 
            this.HocSinhHoTenTextBox.CustomButton.Image = null;
            this.HocSinhHoTenTextBox.CustomButton.Location = new System.Drawing.Point(282, 2);
            this.HocSinhHoTenTextBox.CustomButton.Name = "";
            this.HocSinhHoTenTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.HocSinhHoTenTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HocSinhHoTenTextBox.CustomButton.TabIndex = 1;
            this.HocSinhHoTenTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HocSinhHoTenTextBox.CustomButton.UseSelectable = true;
            this.HocSinhHoTenTextBox.CustomButton.Visible = false;
            this.HocSinhHoTenTextBox.Lines = new string[0];
            this.HocSinhHoTenTextBox.Location = new System.Drawing.Point(136, 45);
            this.HocSinhHoTenTextBox.MaxLength = 32767;
            this.HocSinhHoTenTextBox.Name = "HocSinhHoTenTextBox";
            this.HocSinhHoTenTextBox.PasswordChar = '\0';
            this.HocSinhHoTenTextBox.PromptText = "Họ và tên";
            this.HocSinhHoTenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HocSinhHoTenTextBox.SelectedText = "";
            this.HocSinhHoTenTextBox.SelectionLength = 0;
            this.HocSinhHoTenTextBox.SelectionStart = 0;
            this.HocSinhHoTenTextBox.ShortcutsEnabled = true;
            this.HocSinhHoTenTextBox.Size = new System.Drawing.Size(312, 32);
            this.HocSinhHoTenTextBox.TabIndex = 0;
            this.HocSinhHoTenTextBox.UseSelectable = true;
            this.HocSinhHoTenTextBox.WaterMark = "Họ và tên";
            this.HocSinhHoTenTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HocSinhHoTenTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HocSinhEmailTextBox
            // 
            // 
            // 
            // 
            this.HocSinhEmailTextBox.CustomButton.Image = null;
            this.HocSinhEmailTextBox.CustomButton.Location = new System.Drawing.Point(282, 2);
            this.HocSinhEmailTextBox.CustomButton.Name = "";
            this.HocSinhEmailTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.HocSinhEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HocSinhEmailTextBox.CustomButton.TabIndex = 1;
            this.HocSinhEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HocSinhEmailTextBox.CustomButton.UseSelectable = true;
            this.HocSinhEmailTextBox.CustomButton.Visible = false;
            this.HocSinhEmailTextBox.Lines = new string[0];
            this.HocSinhEmailTextBox.Location = new System.Drawing.Point(136, 372);
            this.HocSinhEmailTextBox.MaxLength = 32767;
            this.HocSinhEmailTextBox.Name = "HocSinhEmailTextBox";
            this.HocSinhEmailTextBox.PasswordChar = '\0';
            this.HocSinhEmailTextBox.PromptText = "Email";
            this.HocSinhEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HocSinhEmailTextBox.SelectedText = "";
            this.HocSinhEmailTextBox.SelectionLength = 0;
            this.HocSinhEmailTextBox.SelectionStart = 0;
            this.HocSinhEmailTextBox.ShortcutsEnabled = true;
            this.HocSinhEmailTextBox.Size = new System.Drawing.Size(312, 32);
            this.HocSinhEmailTextBox.TabIndex = 1;
            this.HocSinhEmailTextBox.UseSelectable = true;
            this.HocSinhEmailTextBox.WaterMark = "Email";
            this.HocSinhEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HocSinhEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.HocSinhEmailTextBox.VisibleChanged += new System.EventHandler(this.HocSinhEmailTextBox_VisibleChanged);
            // 
            // HocSinhNgaySinhDateTime
            // 
            this.HocSinhNgaySinhDateTime.CustomFormat = "dd/MM/yyyy";
            this.HocSinhNgaySinhDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HocSinhNgaySinhDateTime.Location = new System.Drawing.Point(136, 307);
            this.HocSinhNgaySinhDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.HocSinhNgaySinhDateTime.Name = "HocSinhNgaySinhDateTime";
            this.HocSinhNgaySinhDateTime.Size = new System.Drawing.Size(312, 29);
            this.HocSinhNgaySinhDateTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(32, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(62, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // HocSinhDiaChiTextBox
            // 
            this.HocSinhDiaChiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HocSinhDiaChiTextBox.Location = new System.Drawing.Point(136, 158);
            this.HocSinhDiaChiTextBox.Name = "HocSinhDiaChiTextBox";
            this.HocSinhDiaChiTextBox.Size = new System.Drawing.Size(312, 96);
            this.HocSinhDiaChiTextBox.TabIndex = 11;
            this.HocSinhDiaChiTextBox.Text = "";
            // 
            // HocSinhGioiTinhComboBox
            // 
            this.HocSinhGioiTinhComboBox.FormattingEnabled = true;
            this.HocSinhGioiTinhComboBox.ItemHeight = 23;
            this.HocSinhGioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.HocSinhGioiTinhComboBox.Location = new System.Drawing.Point(136, 103);
            this.HocSinhGioiTinhComboBox.Name = "HocSinhGioiTinhComboBox";
            this.HocSinhGioiTinhComboBox.Size = new System.Drawing.Size(189, 29);
            this.HocSinhGioiTinhComboBox.TabIndex = 12;
            this.HocSinhGioiTinhComboBox.UseSelectable = true;
            // 
            // HocSinhOKButton
            // 
            this.HocSinhOKButton.BackColor = System.Drawing.Color.Teal;
            this.HocSinhOKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HocSinhOKButton.FlatAppearance.BorderSize = 0;
            this.HocSinhOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HocSinhOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocSinhOKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HocSinhOKButton.Location = new System.Drawing.Point(20, 432);
            this.HocSinhOKButton.Name = "HocSinhOKButton";
            this.HocSinhOKButton.Size = new System.Drawing.Size(427, 30);
            this.HocSinhOKButton.TabIndex = 13;
            this.HocSinhOKButton.Text = "OK";
            this.HocSinhOKButton.UseVisualStyleBackColor = false;
            this.HocSinhOKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Teal;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(438, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HocSinhForm
            // 
            this.AcceptButton = this.HocSinhOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(467, 482);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HocSinhOKButton);
            this.Controls.Add(this.HocSinhGioiTinhComboBox);
            this.Controls.Add(this.HocSinhDiaChiTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HocSinhNgaySinhDateTime);
            this.Controls.Add(this.HocSinhEmailTextBox);
            this.Controls.Add(this.HocSinhHoTenTextBox);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HocSinhForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox HocSinhHoTenTextBox;
        private MetroFramework.Controls.MetroTextBox HocSinhEmailTextBox;
        private MetroFramework.Controls.MetroDateTime HocSinhNgaySinhDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox HocSinhDiaChiTextBox;
        private MetroFramework.Controls.MetroComboBox HocSinhGioiTinhComboBox;
        private System.Windows.Forms.Button HocSinhOKButton;
        private System.Windows.Forms.Button ExitButton;
    }
}