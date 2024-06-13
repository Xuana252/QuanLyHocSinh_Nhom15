using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyHocSinh_Nhom15
{
    public partial class GiaoVienForm : MetroFramework.Forms.MetroForm
    {
        DangKi DangKi;
        public GiaoVienForm(DangKi dangki)
        {
            InitializeComponent();
            this.DangKi = dangki;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Sự kiện xảy ra khi biểu mẩu xuất hiện và biến mất
        public void GiaoVienForm_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                metroListView1.Items.Clear();
                List<ListViewItem> MergedTaiKhoans = TaiKhoan.GetInstance().LayDanhSach();
                List<ListViewItem> GiaoViens = GiaoVien.GetInstance().LayDanhSach();
                List<ListViewItem> MonHocs = QuanLyHocSinh_Nhom15.MonHoc.GetInstance().LayDanhSach();
                List<ListViewItem> VaiTros = QuanLyHocSinh_Nhom15.VaiTro.GetInstance().LayDanhSach();

                MergeDanhSach(MergedTaiKhoans, GiaoViens, MonHocs, VaiTros);
                foreach (ListViewItem taiKhoan in MergedTaiKhoans)
                {
                    ListViewItem item = new ListViewItem(metroListView1.Items.Count.ToString());
                    item.SubItems.Add(taiKhoan.SubItems[1].Text);//IDGiaoVien
                    item.SubItems.Add(taiKhoan.SubItems[2].Text);//TenTaiKhoan
                    item.SubItems.Add(taiKhoan.SubItems[3].Text);//MatKhau
                    item.SubItems.Add(taiKhoan.SubItems[14].Text);//VaiTro
                    item.SubItems.Add(taiKhoan.SubItems[6].Text);//HoTen
                    item.SubItems.Add(taiKhoan.SubItems[10].Text);//GioiTinh
                    item.SubItems.Add(taiKhoan.SubItems[12].Text);//MonHoc
                    item.SubItems.Add(taiKhoan.SubItems[7].Text);//NgaySinh
                    item.SubItems.Add(taiKhoan.SubItems[8].Text);//DiaChi

                    metroListView1.Items.Add(item);
                }
            }    

        }

        //Hàm gộp danh sách tài khoản và thông tin giáo viên tương ứng
        private void MergeDanhSach(List<ListViewItem> taiKhoans, List<ListViewItem> giaoViens, List<ListViewItem> monHocs, List<ListViewItem> vaiTros)
        {
            Dictionary<string, ListViewItem> lookupGiaoVien = new Dictionary<string, ListViewItem>();
            Dictionary<string, ListViewItem> lookupMonHoc = new Dictionary<string, ListViewItem>();
            Dictionary<string, ListViewItem> lookupVaiTro = new Dictionary<string, ListViewItem>();

            //Thêm key giáo viên vào Dictionary
            foreach (ListViewItem giaoVien in giaoViens)
            {
                string idGiaoVien = giaoVien.Text;
                if (!lookupGiaoVien.ContainsKey(idGiaoVien))
                {
                    lookupGiaoVien.Add(idGiaoVien, giaoVien);
                }
            }

            //Thêm key môn học vào Dictionary
            foreach (ListViewItem monHoc in monHocs)
            {
                string idMonHoc = monHoc.Text;
                if (!lookupMonHoc.ContainsKey(idMonHoc))
                {
                    lookupMonHoc.Add(idMonHoc, monHoc);
                }
            }

            //Thêm key vai trò vào Dictionary
            foreach (ListViewItem vaiTro in vaiTros)
            {
                string idVaiTro = vaiTro.Text;
                if (!lookupVaiTro.ContainsKey(idVaiTro))
                {
                    lookupVaiTro.Add(idVaiTro, vaiTro);
                }
            }

            //Thêm thông tin giáo viên dựa vào id
            //Thêm thông tin môn học dựa vào id
            //Thêm thông tin vai trò dựa vào id
            foreach (ListViewItem item in taiKhoans)
            {
                //Thêm thông tin giáo viên dựa vào id
                string idGiaoVien = item.SubItems[1].Text;
                if (lookupGiaoVien.ContainsKey(idGiaoVien))
                {
                    ListViewItem giaoVien = lookupGiaoVien[idGiaoVien];
                    foreach (ListViewItem.ListViewSubItem subitem in giaoVien.SubItems)
                        item.SubItems.Add(subitem);
                }

                //Thêm thông tin môn học dựa vào id
                string idMonHoc = item.SubItems[9].Text;
                if (lookupMonHoc.ContainsKey(idMonHoc))
                {
                    ListViewItem monHoc = lookupMonHoc[idMonHoc];
                    foreach (ListViewItem.ListViewSubItem subitem in monHoc.SubItems)
                        item.SubItems.Add(subitem);
                }
                else if (idMonHoc == "00")
                {
                    item.SubItems.Add("00");
                    item.SubItems.Add("Chua co");
                }
                    

                //Thêm thông tin vai trò dựa vào id
                string idVaiTro = item.SubItems[4].Text;
                if (lookupVaiTro.ContainsKey(idVaiTro))
                {
                    ListViewItem vaiTro = lookupVaiTro[idVaiTro];
                    foreach (ListViewItem.ListViewSubItem subitem in vaiTro.SubItems)
                        item.SubItems.Add(subitem);

                }
            }
        }

        //Khối sự kiện dành cho việc vẽ các item dành cho listview
        //---------------------------------------------------------------------------------------------------------------------------------

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (sender is MetroListView listView)
            {
                e.NewWidth = listView.Columns[e.ColumnIndex].Width;
                e.Cancel = true;
            }
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = false;
            if (sender is MetroListView listView)
            {
                using (Font headerFont = new Font("Arial", 12, FontStyle.Regular))
                {
                    Rectangle headerBounds = e.Bounds;

                    e.Graphics.FillRectangle(Brushes.Teal, e.Bounds);

                    TextRenderer.DrawText(e.Graphics, listView.Columns[e.ColumnIndex].Text, headerFont, headerBounds, Color.White, Color.Empty, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                    e.Graphics.DrawLine(Pens.DarkGray, headerBounds.Left, headerBounds.Bottom - 1, headerBounds.Right, headerBounds.Bottom - 1);
                }
            }

        }

        private void TaiKhoanQuanLiTaiKhoanButton_Click(object sender, EventArgs e)
        {
            if (metroListView1.SelectedItems.Count > 0)
            {
                TaiKhoan.GetInstance().flagSua = true;
                TaiKhoan.GetInstance().tenTaiKhoanSua = metroListView1.SelectedItems[0].SubItems[2].Text;
                TaiKhoan.GetInstance().matKhauSua = metroListView1.SelectedItems[0].SubItems[3].Text;
                TaiKhoan.GetInstance().vaiTroSua = metroListView1.SelectedItems[0].SubItems[4].Text;

                GiaoVien.GetInstance().idGiaoVienSua = metroListView1.SelectedItems[0].SubItems[1].Text;
                GiaoVien.GetInstance().hoTenSua = metroListView1.SelectedItems[0].SubItems[5].Text;
                GiaoVien.GetInstance().ngaySinhSua = metroListView1.SelectedItems[0].SubItems[8].Text;
                GiaoVien.GetInstance().diaChiSua = metroListView1.SelectedItems[0].SubItems[9].Text;
                GiaoVien.GetInstance().monHocSua = metroListView1.SelectedItems[0].SubItems[7].Text;
                GiaoVien.GetInstance().gioiTinhSua = metroListView1.SelectedItems[0].SubItems[6].Text;

                DangKi.ShowDialog();
            }
            else
            {
                ThongBaoForm.GetInstance().LogError("Vui lòng chọn tài khoản trước khi chỉnh sửa");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
