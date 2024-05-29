using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class MonHoc
    {
        private static MonHoc _instance;
        public string idMonHoc;
        public string TenMonHoc;

        public static MonHoc GetInstance()
        {
            if (_instance == null)
                _instance = new MonHoc();
            return _instance;
        }

        //Hàm lấy danh sách môn học
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT * FROM MONHOC WHERE idMonHoc <> 'NO'";


            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idMonHoc = db.reader.GetString(0);
                string tenMonHoc = db.reader.GetString(1);

                ListViewItem item = new ListViewItem();
                item.Text = (idMonHoc);
                item.SubItems.Add(tenMonHoc);

                itemList.Add(item);

            }
            db.reader.Close();
            return itemList;
        }

        //Hàm thêm môn học

        //Hàm sửa môn học

        //Hàm xóa môn học
    }
}
