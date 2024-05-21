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

        private void GiaoVienForm_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                SQLConnect db = SQLConnect.GetInstance();
                db.Open();
                db.sqlCmd.CommandType = CommandType.Text;
                db.sqlCmd.CommandText = "SELECT GIAOVIEN.idGiaoVien, TenTaiKhoan, MatKhau, tenVaiTro,HoTen,TenMonHoc, CONVERT(VARCHAR(10),NgaySinh,103),DiaChi FROM TAIKHOAN JOIN GIAOVIEN ON TAIKHOAN.idGiaoVien=GIAOVIEN.idGiaoVien JOIN MONHOC ON GIAOVIEN.idMonHoc=MONHOC.idMonHoc JOIN VAITRO ON VAITRO.idVaiTro=TAIKHOAN.idVaiTro";

                db.sqlCmd.Connection = db.sqlCon;

                db.reader = db.sqlCmd.ExecuteReader();

                metroListView1.Items.Clear();

                while (db.reader.Read())
                {
                    string idGiaoVien = db.reader.GetString(0);
                    string tenTaiKhoan = db.reader.GetString(1);
                    string matKhau = db.reader.GetString(2);  
                    string vaiTro =db.reader.GetString(3);
                    string tenGiaoVien =db.reader.GetString(4).Trim();
                    string monHoc=db.reader.GetString(5);
                    string ngaySinh=db.reader.GetString(6);
                    string diaChi=db.reader.GetString(7);

                    ListViewItem item = new ListViewItem();
                    item.Text = (metroListView1.Items.Count + 1).ToString();
                    item.SubItems.Add(idGiaoVien);
                    item.SubItems.Add(tenTaiKhoan);
                    item.SubItems.Add(matKhau);
                    item.SubItems.Add(vaiTro);
                    item.SubItems.Add(tenGiaoVien);
                    item.SubItems.Add(monHoc);
                    item.SubItems.Add(ngaySinh);
                    item.SubItems.Add(diaChi);

                    metroListView1.Items.Add(item);
                    
                }
                db.reader.Close();
            }
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
    }
}
