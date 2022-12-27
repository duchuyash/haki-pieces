using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapKho
    {
        public int MaLo { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public string TenTK { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool TrangThai { get; set; }
    }
}
