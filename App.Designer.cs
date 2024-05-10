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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.AppTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabTraCuu = new MetroFramework.Controls.MetroTabPage();
            this.TabTiepNhan = new MetroFramework.Controls.MetroTabPage();
            this.TabBaoCao = new MetroFramework.Controls.MetroTabPage();
            this.TabTongKet = new MetroFramework.Controls.MetroTabPage();
            this.TabDanhSachLop = new MetroFramework.Controls.MetroTabPage();
            this.TabUser = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.AppTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AppNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 48);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(1024, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 48);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AppNameLabel.Location = new System.Drawing.Point(46, 12);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(227, 24);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "QuanLyHocSinh-Nhom15";
            // 
            // AppTabControl
            // 
            this.AppTabControl.Controls.Add(this.TabTraCuu);
            this.AppTabControl.Controls.Add(this.TabTiepNhan);
            this.AppTabControl.Controls.Add(this.TabBaoCao);
            this.AppTabControl.Controls.Add(this.TabTongKet);
            this.AppTabControl.Controls.Add(this.TabDanhSachLop);
            this.AppTabControl.Controls.Add(this.TabUser);
            this.AppTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.AppTabControl.ItemSize = new System.Drawing.Size(179, 0);
            this.AppTabControl.Location = new System.Drawing.Point(0, 48);
            this.AppTabControl.Multiline = true;
            this.AppTabControl.Name = "AppTabControl";
            this.AppTabControl.SelectedIndex = 4;
            this.AppTabControl.Size = new System.Drawing.Size(1081, 607);
            this.AppTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AppTabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.AppTabControl.TabIndex = 1;
            this.AppTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppTabControl.UseCustomForeColor = true;
            this.AppTabControl.UseSelectable = true;
            this.AppTabControl.UseStyleColors = true;
            // 
            // TabTraCuu
            // 
            this.TabTraCuu.BackColor = System.Drawing.Color.Teal;
            this.TabTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTraCuu.HorizontalScrollbarBarColor = true;
            this.TabTraCuu.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTraCuu.HorizontalScrollbarSize = 10;
            this.TabTraCuu.Location = new System.Drawing.Point(4, 38);
            this.TabTraCuu.Name = "TabTraCuu";
            this.TabTraCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTraCuu.Size = new System.Drawing.Size(1073, 565);
            this.TabTraCuu.TabIndex = 0;
            this.TabTraCuu.Text = "Tra cứu";
            this.TabTraCuu.UseVisualStyleBackColor = true;
            this.TabTraCuu.VerticalScrollbarBarColor = true;
            this.TabTraCuu.VerticalScrollbarHighlightOnWheel = false;
            this.TabTraCuu.VerticalScrollbarSize = 10;
            // 
            // TabTiepNhan
            // 
            this.TabTiepNhan.BackColor = System.Drawing.Color.Teal;
            this.TabTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTiepNhan.HorizontalScrollbarBarColor = true;
            this.TabTiepNhan.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTiepNhan.HorizontalScrollbarSize = 10;
            this.TabTiepNhan.Location = new System.Drawing.Point(4, 38);
            this.TabTiepNhan.Name = "TabTiepNhan";
            this.TabTiepNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTiepNhan.Size = new System.Drawing.Size(1073, 565);
            this.TabTiepNhan.TabIndex = 1;
            this.TabTiepNhan.Text = "Tiếp nhận";
            this.TabTiepNhan.UseVisualStyleBackColor = true;
            this.TabTiepNhan.VerticalScrollbarBarColor = true;
            this.TabTiepNhan.VerticalScrollbarHighlightOnWheel = false;
            this.TabTiepNhan.VerticalScrollbarSize = 10;
            // 
            // TabBaoCao
            // 
            this.TabBaoCao.BackColor = System.Drawing.Color.Teal;
            this.TabBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabBaoCao.HorizontalScrollbarBarColor = true;
            this.TabBaoCao.HorizontalScrollbarHighlightOnWheel = false;
            this.TabBaoCao.HorizontalScrollbarSize = 10;
            this.TabBaoCao.Location = new System.Drawing.Point(4, 38);
            this.TabBaoCao.Name = "TabBaoCao";
            this.TabBaoCao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabBaoCao.Size = new System.Drawing.Size(1073, 565);
            this.TabBaoCao.TabIndex = 3;
            this.TabBaoCao.Text = "Báo cáo môn";
            this.TabBaoCao.UseVisualStyleBackColor = true;
            this.TabBaoCao.VerticalScrollbarBarColor = true;
            this.TabBaoCao.VerticalScrollbarHighlightOnWheel = false;
            this.TabBaoCao.VerticalScrollbarSize = 10;
            // 
            // TabTongKet
            // 
            this.TabTongKet.BackColor = System.Drawing.Color.Teal;
            this.TabTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTongKet.HorizontalScrollbarBarColor = true;
            this.TabTongKet.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTongKet.HorizontalScrollbarSize = 10;
            this.TabTongKet.Location = new System.Drawing.Point(4, 38);
            this.TabTongKet.Name = "TabTongKet";
            this.TabTongKet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabTongKet.Size = new System.Drawing.Size(1073, 565);
            this.TabTongKet.TabIndex = 4;
            this.TabTongKet.Text = "Tổng kết";
            this.TabTongKet.UseVisualStyleBackColor = true;
            this.TabTongKet.VerticalScrollbarBarColor = true;
            this.TabTongKet.VerticalScrollbarHighlightOnWheel = false;
            this.TabTongKet.VerticalScrollbarSize = 10;
            // 
            // TabDanhSachLop
            // 
            this.TabDanhSachLop.BackColor = System.Drawing.Color.Teal;
            this.TabDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDanhSachLop.HorizontalScrollbarBarColor = true;
            this.TabDanhSachLop.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDanhSachLop.HorizontalScrollbarSize = 10;
            this.TabDanhSachLop.Location = new System.Drawing.Point(4, 38);
            this.TabDanhSachLop.Name = "TabDanhSachLop";
            this.TabDanhSachLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabDanhSachLop.Size = new System.Drawing.Size(1073, 565);
            this.TabDanhSachLop.TabIndex = 2;
            this.TabDanhSachLop.Text = "Danh sách lớp";
            this.TabDanhSachLop.UseVisualStyleBackColor = true;
            this.TabDanhSachLop.VerticalScrollbarBarColor = true;
            this.TabDanhSachLop.VerticalScrollbarHighlightOnWheel = false;
            this.TabDanhSachLop.VerticalScrollbarSize = 10;
            // 
            // TabUser
            // 
            this.TabUser.HorizontalScrollbarBarColor = true;
            this.TabUser.HorizontalScrollbarHighlightOnWheel = false;
            this.TabUser.HorizontalScrollbarSize = 10;
            this.TabUser.Location = new System.Drawing.Point(4, 38);
            this.TabUser.Name = "TabUser";
            this.TabUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabUser.Size = new System.Drawing.Size(1073, 565);
            this.TabUser.TabIndex = 5;
            this.TabUser.Text = "Tài khoản";
            this.TabUser.VerticalScrollbarBarColor = true;
            this.TabUser.VerticalScrollbarHighlightOnWheel = false;
            this.TabUser.VerticalScrollbarSize = 10;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AppTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Button ExitButton;
        private MetroFramework.Controls.MetroTabControl AppTabControl;
        private MetroFramework.Controls.MetroTabPage TabTraCuu;
        private MetroFramework.Controls.MetroTabPage TabTiepNhan;
        private MetroFramework.Controls.MetroTabPage TabDanhSachLop;
        private MetroFramework.Controls.MetroTabPage TabBaoCao;
        private MetroFramework.Controls.MetroTabPage TabTongKet;
        private MetroFramework.Controls.MetroTabPage TabUser;
    }
}

