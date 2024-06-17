using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
     public sealed class MonHoc
    {
        private static MonHoc _instance;
        public string idMonHoc;
        public string TenMonHoc;

        public bool flagSua = false;

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
            

            db.sqlCmd.CommandText = "SELECT * FROM MONHOC WHERE idMonHoc <> '00'";




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
            db.Close();
            return itemList;
        }

        //Hàm thêm môn học
        public void ThemMonHoc(string id, string tenmon)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            


            db.sqlCmd.CommandText = "insert into MONHOC values(@idmon, @tenmon)";

            db.sqlCmd.Parameters.AddWithValue("@idmon", id);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);



            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
        }

        //Hàm sửa môn học
        public void SuaMonHoc(string id, string tenmon)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            


            db.sqlCmd.CommandText = "update MONHOC set TenMonHoc=@tenmon where idMonHoc=@idmon";
            
            db.sqlCmd.Parameters.AddWithValue("@idmon", id);
            db.sqlCmd.Parameters.AddWithValue("@tenmon", tenmon);




            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
            }
            db.Close();
        }

        //Hàm xóa môn học
        public void XoaMonHoc(List<ListViewItem> items)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            SqlParameter idMonHocParam = new SqlParameter("@idMonHoc", SqlDbType.Char, 2);

            db.sqlCmd.Parameters.Add(idMonHocParam);

            foreach (ListViewItem item in items)
            {

                idMonHocParam.Value = item.SubItems[1].Text;

                db.sqlCmd.CommandText = "DELETE FROM MONHOC WHERE idMonHoc=@idMonHoc";

    

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message);
                }
            }
            db.Close();
        }
    }
}
