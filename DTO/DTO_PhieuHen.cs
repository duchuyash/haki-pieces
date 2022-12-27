using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuHen
    {
        public int MaPH { get; set; }
        public int MaHD { get; set; }
        public int MaTV { get; set; }
        public string DiaChiGiao { get; set; }
        public DateTime NgayHen { get; set; }
        public bool TrangThai { get; set; }

        public string ThanhVien { get; set; }
    }
}
