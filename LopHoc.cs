using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class LopHoc
    {
        private static LopHoc _instance;
        public string idLop;
        public string TenLop;
        public string SiSo;
        public string idGiaoVien;
        public static LopHoc GetInstance()
        {
            if (_instance == null)
                _instance = new LopHoc();
            return _instance;
        }

        public void ThemLop()
        {

        }
        public void XoaLop()
        {

        }

        public void SuaLop()
        {

        }

        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT * FROM LOPHOC";


            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idLop = db.reader.GetString(0);
                string tenLop = db.reader.GetString(1);
                string siSo = db.reader.GetInt32(2).ToString();
                string idGiaoVien = !db.reader.IsDBNull(3) ? db.reader.GetString(3) : null;

                ListViewItem item = new ListViewItem();
                item.Text = (idLop);
                item.SubItems.Add(tenLop);
                item.SubItems.Add(siSo);
                item.SubItems.Add(idGiaoVien);

                itemList.Add(item);

            }
            db.reader.Close();
            return itemList;
        }
    }
}
