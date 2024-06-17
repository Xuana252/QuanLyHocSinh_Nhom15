using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
     public sealed class LopHoc
    {
        private static LopHoc _instance;
        public string idLop="";
        public string TenLop;
        public string SiSo;
        public string idGiaoVien;
        public static LopHoc GetInstance()
        {
            if (_instance == null)
                _instance = new LopHoc();
            return _instance;
        }

        public bool flagSua = false;//Biến cờ hiệu dùng để xác định nút Thêm Sửa thực hiện chức năng gì

        //Hàm thêm lớp
        public void ThemLop(string khoiLop,string tenLop,string idGVCN)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText ="DECLARE @idLop CHAR(3);"+
                "SELECT @idLop= @khoiLop+RIGHT('00'+CAST(ISNULL((SELECT MAX(CAST(RIGHT(idLop,2) AS INT))+1 FROM LOPHOC WHERE  idLop LIKE @khoiLop + '%'),1)AS VARCHAR(2)),2);" +
                "INSERT INTO LOPHOC VALUES (@idLop,@tenLop,0,@idGiaoVien);";


            db.sqlCmd.Parameters.AddWithValue("@tenLop", tenLop);
            db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGVCN);
            db.sqlCmd.Parameters.AddWithValue("@khoiLop", khoiLop.Substring(1,1));




            try
            { 
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
            }
            db.Close();
        }

        //Hàm sửa lớp
        public void SuaLop(string idLop,string tenLop, string idGVCN)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "UPDATE LOPHOC SET tenLop=@tenLop,idGiaoVien=@idGiaoVien WHERE idLop=@idLop;";


            db.sqlCmd.Parameters.AddWithValue("@idLop", idLop);
            db.sqlCmd.Parameters.AddWithValue("@tenLop", tenLop);
            db.sqlCmd.Parameters.AddWithValue("@idGiaoVien", idGVCN);




            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
            }
            flagSua = false;
            db.Close();
        }

        //Hàm xóa lớp
        public void XoaLop(List<ListViewItem> items)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            SqlParameter idLopParam = new SqlParameter("@idLop", SqlDbType.Char,3);

            db.sqlCmd.Parameters.Add(idLopParam);

            foreach (ListViewItem item in items)
            {
                idLopParam.Value = item.SubItems[1].Text;

                db.sqlCmd.CommandText = "DELETE FROM LOPHOC WHERE idLop=@idLop";

    

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ThongBaoForm.GetInstance().LogError("Xảy ra lỗi:\n" + ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
                }
            }
            db.Close();
        }

        //Hàm thêm học sinh vào danh sách lớp
        public void ThemHocSinhVaoLop(List<ListViewItem> items)
        {
            HocSinh.GetInstance().ThemHocSinhVaoLop(items, idLop);
        }

        //Hàm xóa học sinh khỏi danh sách lớp

        public void XoaHocSinhKhoiLop(List<ListViewItem> items)
        {
            HocSinh.GetInstance().XoaHocSinhKhoiLop(items);
        }




        //Hàm lấy danh sách lớp
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            

            db.sqlCmd.CommandText = "SELECT * FROM LOPHOC";




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
            db.Close();
            return itemList;
        }

    }
}
