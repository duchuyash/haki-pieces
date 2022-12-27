using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAO_KhuyenMai khuyenMai = new DAO_KhuyenMai();
        public List<DTO_KhuyenMai> DSKhuyenMai()
        {
            return khuyenMai.DSKhuyenMai();
        }

        public DTO_KhuyenMai SPKhuyenMai(string masp)
        {
            DTO_KhuyenMai KM = khuyenMai.DSKhuyenMai().FirstOrDefault(u => u.MaSP == masp);
            return KM;
        }
    }
}
