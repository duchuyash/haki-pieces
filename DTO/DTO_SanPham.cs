using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DTO
{
    public class DTO_SanPham
    {
        public string HinhAnh { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HangSX { get; set; }
        public string MoTa { get; set; }
        public DateTime HSD { get; set; }
        public decimal DonGiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public bool TrangThai { get; set; }
    }
}
