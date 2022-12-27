using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string HinhAnh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public decimal Luong { get; set; }
        public bool TrangThai { get; set; }

        public DTO_TaiKhoan TaiKhoan {get; set;}
        public string ChucVu { get; set; }
    }
}
