using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    sealed class HocSinh
    {
        private static HocSinh _instance;
        public string idHocSinh;
        public string HoTen;
        public string idLop;
        public string GioiTinh;
        public string Email;
        public string DiaChi;
        public string NgaySinh;

        public bool flagSua=false;//Biến cờ hiệu dùng để xác định nút Thêm Sửa thực hiện chức năng gì
        public static HocSinh GetInstance()
        {
            if (_instance == null)
                _instance = new HocSinh();
            return _instance;
        }

        //Hàm thêm học sinh
        public void ThemHocSinh(string hoTen,string gioiTinh,string diaChi,string ngaySinh,string email)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;


            db.sqlCmd.CommandText = "SET DATEFORMAT DMY;" +
               "DECLARE @idHocSinh Char(7);" +
               "SELECT @idHocSinh = RIGHT(YEAR(GETDATE()),4)+ RIGHT('000' + CAST(ISNULL((SELECT MAX(CAST(RIGHT(idHocSinh, 3) AS INT)) + 1 FROM HOCSINH WHERE idHocSinh LIKE (CAST(YEAR(GETDATE()) AS VARCHAR(4))) + '%'), 1) AS VARCHAR(3)), 3);" +
               "INSERT INTO HOCSINH VALUES (@idHocSinh,@hoTen,Null,@gioiTinh,@email,@diaChi,@ngaySinh);";


            db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTen);
            db.sqlCmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            db.sqlCmd.Parameters.AddWithValue("@diaChi", diaChi);
            db.sqlCmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            db.sqlCmd.Parameters.AddWithValue("@email", email);



            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show(ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
            }
        }

        //Hàm sửa học sinh
        public void SuaHocSinh(string hoTen, string gioiTinh, string diaChi, string ngaySinh, string email)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;


            db.sqlCmd.CommandText = "SET DATEFORMAT DMY;" +
               "UPDATE HOCSINH SET HoTen=@hoTen, GioiTinh =@gioiTinh , DiaChi =@diaChi ,NgaySinh =@ngaySinh,Email=@email WHERE idHocSinh =@idHocSinh ";


            db.sqlCmd.Parameters.AddWithValue("@idHocSinh", idHocSinh);
            db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTen);
            db.sqlCmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            db.sqlCmd.Parameters.AddWithValue("@diaChi", diaChi);
            db.sqlCmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            db.sqlCmd.Parameters.AddWithValue("@email", email);



            db.sqlCmd.Connection = db.sqlCon;

            try
            {
                db.sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error.GetInstance().Show(ex.Message/*.Substring(ex.Message.IndexOf('\n'))*/);
            }

            flagSua = false;
        }


        //Hàm xóa học sinh
        public void XoaHocSinh(ListView.SelectedListViewItemCollection items)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            foreach (ListViewItem item in items)
            {
                db.sqlCmd.CommandText = "DELETE FROM HOCSINH WHERE idHocSinh=@idHocSinh";


                db.sqlCmd.Parameters.AddWithValue("@idHocSinh", item.Text);


                db.sqlCmd.Connection = db.sqlCon;

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Error.GetInstance().Show(ex.Message.Substring(ex.Message.IndexOf('\n')));
                }
            }
        }

        //Hàm lấy danh sách học sinh dành cho tab tiếp nhận
        public void LayDanhSach(ListView lv,string hoTenTimKiem)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            if (hoTenTimKiem.Length == 0)
                db.sqlCmd.CommandText = "SELECT idHocSinh,HoTen,GioiTinh,Email,DiaChi,CONVERT(VARCHAR(10),NgaySinh,103) FROM HOCSINH WHERE idLop IS NULL";
            else
            {
                db.sqlCmd.CommandText = "SELECT idHocSinh,HoTen,GioiTinh,Email,DiaChi,CONVERT(VARCHAR(10),NgaySinh,103) FROM HOCSINH WHERE idLop IS NULL AND hoTen=@hoTen";
                db.sqlCmd.Parameters.AddWithValue("@hoTen", hoTenTimKiem);
            }

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            lv.Items.Clear();

            while (db.reader.Read())
            {
                string idHocSinh = db.reader.GetString(0);
                string hoTen = db.reader.GetString(1);
                string gioiTinh = db.reader.GetString(2);
                string email = db.reader.GetString(3);
                string diaChi = db.reader.GetString(4);
                string ngaySinh = db.reader.GetString(5);

                ListViewItem item = new ListViewItem();
                item.Text = (idHocSinh);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(ngaySinh);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(email);

                lv.Items.Add(item);

            }
            db.reader.Close();
        }

        //Hàm lấy danh sách tiếp nhận dành cho tab danh sách lớp
        public void LayDanhSach2(ListView lv)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "SELECT HoTen,GioiTinh,CAST(YEAR(NgaySinh) AS CHAR(4)),DiaChi FROM HOCSINH WHERE idLop IS NULL";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            lv.Items.Clear();

            while (db.reader.Read())
            {
                string hoTen = db.reader.GetString(0);
                string gioiTinh = db.reader.GetString(1);
                string namSinh = db.reader.GetString(2);
                string diaChi = db.reader.GetString(3);

                ListViewItem item = new ListViewItem();
                item.Text = ((lv.Items.Count + 1).ToString());
                item.SubItems.Add(hoTen);
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(namSinh);
                item.SubItems.Add(diaChi);

                lv.Items.Add(item);

            }
            db.reader.Close();
        }
    }
}
