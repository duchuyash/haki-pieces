using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhuyenMai
    {
        public string MaSP { get; set; }
        public int MaSK { get; set; }
        public int SLToiThieu { get; set; }
        public decimal Giam { get; set; }
        public bool PhanTram { get; set; }

        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
    }
}
