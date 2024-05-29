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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyHocSinh_Nhom15
{
    public partial class GiaoVienForm : MetroFramework.Forms.MetroForm
    {
        public GiaoVienForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void metroListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.metroListView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void metroListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }
        //Sự kiện xảy ra khi biểu mẩu xuất hiện và biến mất
        private void GiaoVienForm_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                metroListView1.Items.Clear();
                List<ListViewItem> MergedTaiKhoans = TaiKhoan.GetInstance().LayDanhSach();
                List<ListViewItem> GiaoViens = GiaoVien.GetInstance().LayDanhSach();
                List<ListViewItem> MonHocs = MonHoc.GetInstance().LayDanhSach();
                List<ListViewItem> VaiTros = VaiTro.GetInstance().LayDanhSach();

                MergeDanhSach(MergedTaiKhoans, GiaoViens, MonHocs, VaiTros);
                foreach (ListViewItem taiKhoan in MergedTaiKhoans)
                {
                    ListViewItem item = new ListViewItem(metroListView1.Items.Count.ToString());
                    item.SubItems.Add(taiKhoan.SubItems[1]);//IDGiaoVien
                    item.SubItems.Add(taiKhoan.SubItems[2]);//TenTaiKhoan
                    item.SubItems.Add(taiKhoan.SubItems[3]);//MatKhau
                    item.SubItems.Add(taiKhoan.SubItems[14]);//VaiTro
                    item.SubItems.Add(taiKhoan.SubItems[6]);//HoTen
                    item.SubItems.Add(taiKhoan.SubItems[12]);//GioiTinh
                    item.SubItems.Add(taiKhoan.SubItems[7]);//MonHoc
                    item.SubItems.Add(taiKhoan.SubItems[8]);//NgaySinh
                    item.SubItems.Add(taiKhoan.SubItems[10]);//DiaChi

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

       
    }
}
