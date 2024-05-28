using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    public partial class LopForm : MetroFramework.Forms.MetroForm
    {
        App mainApp;

        LopHoc lopHoc = LopHoc.GetInstance();
        GiaoVien giaoVien = GiaoVien.GetInstance();
        
        public LopForm(App MainApp)
        {
            InitializeComponent();
            mainApp = MainApp;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Sự kiện xảy ra khi bấm nút thêm sửa
        private void DanhSachLopHocThemSuaLopButton_Click(object sender, EventArgs e)
        {
            if(DienDayDu())
            {
                string tenLop = DanhSachLopHocTenLopTextBox.Text.Trim();
                string idGVCN = DanhSachLopHocGVCNComboBox.Text;
                string khoiLop = DanhSachLopHocKhoiComboBox.Text;
                if (DanhSachLopHocListView.SelectedItems.Count > 0)
                    lopHoc.SuaLop(DanhSachLopHocListView.SelectedItems[0].SubItems[1].Text, tenLop, idGVCN);
                else
                    lopHoc.ThemLop(khoiLop,tenLop, idGVCN);
            }
            else
            {
                Error.GetInstance().Show("Vui lòng điền đầy đủ thông tin.");
            }
            LoadForm();
        }

      

        //Sự kiện xảy ra khi bấm nút xóa lớp
        private void DanhSachLopHocXoalopButton_Click(object sender, EventArgs e)
        {
            lopHoc.XoaLop(DanhSachLopHocListView.SelectedItems);
            LoadForm();
        }


        //Sự kiện xảy ra khi form xuất hiện hoặc biến mất
        private void LopForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
                LoadForm();
            else
                mainApp.LoadTabDanhSachLop("","");
            ClearForm();
        }

        //hàm load form 

        void LoadForm()
        {
            //lấy danh sách giáo viên vào combobox
            DanhSachLopHocGVCNComboBox.Items.Clear();
            foreach (ListViewItem item in giaoVien.LayDanhSach())
            {
                DanhSachLopHocGVCNComboBox.Items.Add(item.Text);
            }

            //lấy danh sách lớp học vào listview
            DanhSachLopHocListView.Items.Clear();
            foreach (ListViewItem item in lopHoc.LayDanhSach())
            {
                ListViewItem lop = new ListViewItem();
                lop.Text = (DanhSachLopHocListView.Items.Count + 1).ToString();
                lop.SubItems.Add(item.SubItems[0].Text);
                lop.SubItems.Add(item.SubItems[1].Text);
                lop.SubItems.Add(item.SubItems[2].Text);
                lop.SubItems.Add(item.SubItems[3].Text);

                DanhSachLopHocListView.Items.Add(lop);
            }

        }

        //hàm clearform
        void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MetroTextBox || control is RichTextBox || control is MetroDateTime)
                {
                    control.Text = null;
                }
            }
        }

        //Sự kiện xảy ra khi người dùng nhấn chọn lớp trong danh sách
        private void DanhSachLopHocListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DanhSachLopHocListView.SelectedItems.Count > 0)
            {
                DanhSachLopHocTenLopTextBox.Text = DanhSachLopHocListView.SelectedItems[0].SubItems[2].Text;
                DanhSachLopHocGVCNComboBox.Text = DanhSachLopHocListView.SelectedItems[0].SubItems[4].Text;
                DanhSachLopHocKhoiComboBox.Text = DanhSachLopHocListView.SelectedItems[0].SubItems[1].Text.Substring(0, 2);
                DanhSachLopHocKhoiComboBox.Enabled = false;
            }
            else
                DanhSachLopHocKhoiComboBox.Enabled = true;
        }

        //Sự kiện xảy ra khi chọn sỉ số tối đa
        private void DanhSachLopHocNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "UPDATE QUIDINH SET SiSoToiDa = @SiSoToiDa;";

            db.sqlCmd.Parameters.AddWithValue("@SiSoToiDa", (int)DanhSachLopHocNumericUpDown1.Value);

            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu" + ex.Message);
            }
        }

        //hàm kiểm tra điền đầy đủ
        bool DienDayDu()
        {
            foreach (Control control in this.Controls)
            {
                if ( control.Text.Length == 0&&(control is MetroComboBox||control is MetroTextBox) )
                    return false;
            }
            return true;
        }

        //Khối sự kiện dành cho việc vẽ các item dành cho listview
        //---------------------------------------------------------------------------------------------------------------------------------
        private void metroListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void metroListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.DanhSachLopHocListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
