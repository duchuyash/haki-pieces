using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public int MaHD { get; set; }
        public string TenTK { get; set; }
        public DateTime NgayLapHD { get; set; }
        public bool TrangThai { get; set; }

        public List<DTO_CT_HoaDon> CT_HoaDons { get; set; }
        public string ThuNgan { get; set; }
        public bool Hen { get; set; }
    }
}
