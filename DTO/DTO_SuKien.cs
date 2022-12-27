using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SuKien
    {
        public string HinhAnh { get; set; }
        public int MaSK { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }

        public List<DTO_KhuyenMai> KhuyenMai {get;set;}
        public bool TrangThai { get; set; }
    }
}
