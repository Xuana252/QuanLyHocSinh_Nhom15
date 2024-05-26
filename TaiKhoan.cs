using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Nhom15
{
    sealed class TaiKhoan
    {
        private static TaiKhoan _instance;
        public string idTaiKhoan;
        public string idGiaoVien;
        public string idMonHoc;
        public string idVaiTro;
        public string tenTaiKhoan;
        public string matKhau;
        public string hoTen;
        public string ngaySinh;
        public string monHoc;
        public string vaiTro;
        public static TaiKhoan GetInstance()
        {
            if(_instance == null )
                _instance = new TaiKhoan();
            return _instance;
        }

    }
}
