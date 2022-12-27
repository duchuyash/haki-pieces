using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        public string TenNV { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public bool TrangThai { get; set; }
    }
}
