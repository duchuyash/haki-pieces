using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO

{
    public class DTO_CT_HoaDon
    {
        public int MaHD { get; set; }
        public string MaSP { get; set; }
        public decimal GiamGia { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
    }
}
