using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class GiaoVien
    {
        private static GiaoVien _instance;
        public string idGiaoVien;
        public string HoTen;
        public string NgaySinh;
        public string DiaChi;
        public string idMonhoc;

        public static GiaoVien GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GiaoVien();
            }
            return _instance;
        }

        //Hàm lấy danh sách giáo viên
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT idGiaoVien,HoTen,CONVERT(VARCHAR(10),NgaySinh,103),DiaChi,idMonHoc FROM GIAOVIEN";


            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idGiaoVien = db.reader.GetString(0);
                string hoTen = db.reader.GetString(1);
                string ngaySinh = db.reader.GetString(2);
                string diaChi = db.reader.GetString(3);
                string idMonHoc = db.reader.GetString(4);

                ListViewItem item = new ListViewItem();
                item.Text = (idGiaoVien);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(ngaySinh);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(idMonHoc);

                itemList.Add(item);

            }
            db.reader.Close();
            return itemList;
        }

    }
}
