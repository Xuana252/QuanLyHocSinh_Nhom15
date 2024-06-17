using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
     public sealed class VaiTro
    {
        private static VaiTro _instance;

        public string idVaiTro;
        public string tenVaiTro;
        public static VaiTro GetInstance()
        {
            if(_instance == null)
                _instance = new VaiTro();
            return _instance;
        }

        //Lấy danh sách vai trò
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "SELECT * FROM VAITRO";




            db.reader = db.sqlCmd.ExecuteReader();


            while (db.reader.Read())
            {
                string idVaiTro = db.reader.GetString(0);
                string tenVaiTro = db.reader.GetString(1);
                

                ListViewItem item = new ListViewItem();
                item.Text = (idVaiTro);
                item.SubItems.Add(tenVaiTro);

                itemList.Add(item);

            }
            db.reader.Close();
            db.Close();
            return itemList;
        }
    }
}
