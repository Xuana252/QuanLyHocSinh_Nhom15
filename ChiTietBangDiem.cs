using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Nhom15
{
    sealed class ChiTietBangDiem
    {
        private static ChiTietBangDiem _instance;
        public string idBangDiem;
        public string idHocSinh;
        public float Diem15p;
        public float Diem1Tiet;
        public float DiemTB;

        public static ChiTietBangDiem GetInstance()
        {
            if (_instance == null)
                _instance = new ChiTietBangDiem();
            return _instance;
        }

        public void ThemDiem(float diem15p,float diem1t, float diemTB)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "INSERT INTO ";
        }
    }
}
