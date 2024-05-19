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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Siso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDGVCN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ThemLopButton = new System.Windows.Forms.Button();
            this.XoalopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classes list";
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.MintCream;
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDLop,
            this.TenLop,
            this.Siso,
            this.IDGVCN});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView1.Location = new System.Drawing.Point(28, 74);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(353, 438);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroListView1.TabIndex = 9;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.UseStyleColors = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(438, 146);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Tên lớp";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(82, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Tên lớp";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(461, 492);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // ThemLopButton
            // 
            this.ThemLopButton.BackColor = System.Drawing.Color.Teal;
            this.ThemLopButton.FlatAppearance.BorderSize = 0;
            this.ThemLopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemLopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemLopButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ThemLopButton.Location = new System.Drawing.Point(438, 342);
            this.ThemLopButton.Name = "ThemLopButton";
            this.ThemLopButton.Size = new System.Drawing.Size(82, 32);
            this.ThemLopButton.TabIndex = 12;
            this.ThemLopButton.Text = "Thêm lớp";
            this.ThemLopButton.UseVisualStyleBackColor = false;
            // 
            // XoalopButton
            // 
            this.XoalopButton.BackColor = System.Drawing.Color.Teal;
            this.XoalopButton.FlatAppearance.BorderSize = 0;
            this.XoalopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoalopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoalopButton.ForeColor = System.Drawing.SystemColors.Window;
            this.XoalopButton.Location = new System.Drawing.Point(438, 401);
            this.XoalopButton.Name = "XoalopButton";
            this.XoalopButton.Size = new System.Drawing.Size(82, 32);
            this.XoalopButton.TabIndex = 13;
            this.XoalopButton.Text = "Xóa lớp";
            this.XoalopButton.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(438, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(438, 194);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "GVCN";
            this.metroComboBox1.Size = new System.Drawing.Size(82, 29);
            this.metroComboBox1.TabIndex = 27;
            this.metroComboBox1.UseSelectable = true;
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
            this.ExitButton.Size = new System.Drawing.Size(30, 29);
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
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XoalopButton);
            this.Controls.Add(this.ThemLopButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroListView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader IDLop;
        private System.Windows.Forms.ColumnHeader TenLop;
        private System.Windows.Forms.ColumnHeader Siso;
        private System.Windows.Forms.ColumnHeader IDGVCN;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ThemLopButton;
        private System.Windows.Forms.Button XoalopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Button ExitButton;
    }
}