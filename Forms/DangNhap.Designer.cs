namespace QuanLyHocSinh_Nhom15
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button LoginButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.LoginNoteLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = System.Drawing.Color.Teal;
            LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoginButton.ForeColor = System.Drawing.SystemColors.Window;
            LoginButton.Location = new System.Drawing.Point(179, 176);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(114, 32);
            LoginButton.TabIndex = 2;
            LoginButton.TabStop = false;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // UserNameTextBox
            // 
            // 
            // 
            // 
            this.UserNameTextBox.CustomButton.Image = null;
            this.UserNameTextBox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.UserNameTextBox.CustomButton.Name = "";
            this.UserNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.CustomButton.TabIndex = 1;
            this.UserNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextBox.CustomButton.UseSelectable = true;
            this.UserNameTextBox.CustomButton.Visible = false;
            this.UserNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UserNameTextBox.Lines = new string[0];
            this.UserNameTextBox.Location = new System.Drawing.Point(33, 80);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.PromptText = "Tên tài khoản";
            this.UserNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.ShortcutsEnabled = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(260, 23);
            this.UserNameTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.UseSelectable = true;
            this.UserNameTextBox.WaterMark = "Tên tài khoản";
            this.UserNameTextBox.WaterMarkColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(33, 126);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PromptText = "Mật khẩu";
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(260, 23);
            this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMark = "Mật khẩu";
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.Teal;
            this.SignInLabel.Location = new System.Drawing.Point(28, 25);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignInLabel.Size = new System.Drawing.Size(182, 29);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Chào mừng bạn";
            // 
            // LoginNoteLabel
            // 
            this.LoginNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNoteLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginNoteLabel.Location = new System.Drawing.Point(30, 224);
            this.LoginNoteLabel.Name = "LoginNoteLabel";
            this.LoginNoteLabel.Size = new System.Drawing.Size(263, 26);
            this.LoginNoteLabel.TabIndex = 4;
            this.LoginNoteLabel.Text = "nếu bạn không có tài khoản vui lòng liên hệ thành viên ban quản lý nhà trường";
            this.LoginNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Teal;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(289, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginNoteLabel);
            this.Controls.Add(LoginButton);
            this.Controls.Add(this.SignInLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 30);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label LoginNoteLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}