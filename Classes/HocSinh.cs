using MetroFramework.Controls;
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

        public bool flagSua = false;//Biến cờ hiệu dùng để xác định nút Thêm Sửa thực hiện chức năng gì
        public static HocSinh GetInstance()
        {
            if (_instance == null)
                _instance = new HocSinh();
            return _instance;
        }

        //Hàm thêm học sinh
        public void ThemHocSinh(string hoTen, string gioiTinh, string diaChi, string ngaySinh, string email)
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
                Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message.Substring(ex.Message.IndexOf('\n')));
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
                Error.GetInstance().Show("Xảy ra lỗi:\n"+ex.Message.Substring(ex.Message.IndexOf('\n')));
            }

            flagSua = false;
        }

        //Hàm thêm học sinh vào danh sách lớp
        public void ThemHocSinhVaoLop(ListView.SelectedListViewItemCollection items, string idLop)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            SqlParameter idHocSinhParam = new SqlParameter("@idHocSinh", SqlDbType.Char, 7);
            SqlParameter idLopParam = new SqlParameter("@idLop", SqlDbType.Char, 3);

            db.sqlCmd.Parameters.Add(idHocSinhParam);
            db.sqlCmd.Parameters.Add(idLopParam);

            idLopParam.Value = idLop;

            foreach (ListViewItem item in items)
            {

                idHocSinhParam.Value = item.SubItems[1].Text;

                db.sqlCmd.CommandText = "UPDATE HOCSINH SET idLop = @idLop WHERE idHocSinh=@idHocSinh";

                db.sqlCmd.Connection = db.sqlCon;

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message.Substring(ex.Message.IndexOf('\n')));
                }
            }
        }

        //Hàm xóa học sinh khỏi lớp

        public void XoaHocSinhKhoiLop(ListView.SelectedListViewItemCollection items)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            SqlParameter idHocSinhParam = new SqlParameter("@idHocSinh", SqlDbType.Char, 7);

            db.sqlCmd.Parameters.Add(idHocSinhParam);


            foreach (ListViewItem item in items)
            {

                idHocSinhParam.Value = item.SubItems[5].Text;

                db.sqlCmd.CommandText = "UPDATE HOCSINH SET idLop = null WHERE idHocSinh=@idHocSinh";

                db.sqlCmd.Connection = db.sqlCon;

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message.Substring(ex.Message.IndexOf('\n')));
                }
            }
        }

        //Hàm xóa học sinh
        public void XoaHocSinh(ListView.SelectedListViewItemCollection items)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            SqlParameter idHocSinhParam = new SqlParameter("@idHocSinh", SqlDbType.Char, 7);

            db.sqlCmd.Parameters.Add(idHocSinhParam);

            foreach (ListViewItem item in items)
            {

                idHocSinhParam.Value = item.SubItems[0].Text;

                db.sqlCmd.CommandText = "DELETE FROM HOCSINH WHERE idHocSinh=@idHocSinh";

                db.sqlCmd.Connection = db.sqlCon;

                try
                {
                    db.sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Error.GetInstance().Show("Xảy ra lỗi:\n" + ex.Message.Substring(ex.Message.IndexOf('\n')));
                }
            }
        }

        //Hàm lấy danh sách học sinh 
        public List<ListViewItem> LayDanhSach()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;

            db.sqlCmd.CommandText = "SELECT idHocSinh,HoTen,idLop,GioiTinh,Email,DiaChi,CONVERT(VARCHAR(10),NgaySinh,103) FROM HOCSINH";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            while (db.reader.Read())
            {
                string idHocSinh = db.reader.GetString(0);
                string hoTen = db.reader.GetString(1);
                string idLop = !db.reader.IsDBNull(2) ? db.reader.GetString(2) : "NULL";
                string gioiTinh = db.reader.GetString(3);
                string email = db.reader.GetString(4);
                string diaChi = db.reader.GetString(5);
                string ngaySinh = db.reader.GetString(6);

                ListViewItem item = new ListViewItem();
                item.Text = (idHocSinh);
                item.SubItems.Add(hoTen);
                item.SubItems.Add(idLop);
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(email);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(ngaySinh);

                itemList.Add(item);

            }
            db.reader.Close();
            return itemList;
        }

        public List<ListViewItem> TraCuu(string hoten, decimal namhoc)
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            SQLConnect db = SQLConnect.GetInstance();

            db.Open();
                db.sqlCmd.CommandType = CommandType.Text;
                db.sqlCmd.CommandText = @"
                               WITH TraCuuResult AS (
                        SELECT 
                            hoten,
                            tenlop,
                            idhocsinh
                        FROM 
                            HOCSINH 
                        JOIN 
                            LOPHOC ON HOCSINH.idlop = LOPHOC.idlop
                        WHERE 
                            hoten LIKE '%'+@hoten+'%'
                    ),
                    DiemTBHocKy AS (
                        SELECT 
                            idhocsinh,
                            AVG(CASE WHEN hocky = '1' THEN diemtb ELSE NULL END) AS diemtb_hocky_1,
                            AVG(CASE WHEN hocky = '2' THEN diemtb ELSE NULL END) AS diemtb_hocky_2
                        FROM 
                            CHITIETBANGDIEM 
                        JOIN 
                            BANGDIEM ON CHITIETBANGDIEM.idbangdiem = BANGDIEM.idbangdiem
                        WHERE 
                            hocky IN ('1', '2') 
                            AND namhoc = @namhoc
                        GROUP BY 
                            idhocsinh
                    )
                    SELECT 
                        ROW_NUMBER() OVER(ORDER BY hoten) AS STT,
                        hoten,
                        tenlop,
                        ISNULL(CONVERT(DECIMAL(18, 2), diemtb_hocky_1), 0) AS diemtb_hocky_1,
                        ISNULL(CONVERT(DECIMAL(18, 2), diemtb_hocky_2), 0) AS diemtb_hocky_2,
                        TraCuuResult.idhocsinh
                    FROM 
                        TraCuuResult 
                    LEFT JOIN 
                        DiemTBHocKy ON TraCuuResult.idhocsinh = DiemTBHocKy.idhocsinh;";

                db.sqlCmd.Parameters.AddWithValue("@hoten", hoten);
                db.sqlCmd.Parameters.AddWithValue("@namhoc", namhoc);
                db.sqlCmd.Connection = db.sqlCon;

                using (db.reader = db.sqlCmd.ExecuteReader())
                {
                    int i = 1;
                    while (db.reader.Read())
                    {
                        string hotenhocsinh = db.reader.GetString(1);
                        string tenlop = db.reader.GetString(2);
                        string idhocsinh = db.reader.GetString(5);

                        ListViewItem item = new ListViewItem();
                        item.Text = i.ToString();
                        item.SubItems.Add(hotenhocsinh);
                        item.SubItems.Add(tenlop);
                        item.SubItems.Add(db.reader.GetDecimal(3).ToString()); // DiemTB Hoc Ky 1
                        item.SubItems.Add(db.reader.GetDecimal(4).ToString()); // DiemTB Hoc Ky 2
                        item.SubItems.Add(idhocsinh);

                        itemList.Add(item);
                        i++;
                    }
                }
            return itemList;
        }

            
        

    }
}
