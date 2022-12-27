using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_SanPham
    {
        public DAO_SanPham list = new DAO_SanPham();
        public List<DTO_SanPham> DSSanPham()
        {
            return list.DSSanPham();
        }

        public List<DTO_SanPham> TimKiem(string keyword)
        {
            return list.DSSanPham().Where(u =>
                    u.MaSP.ToLower().Contains(keyword.ToLower()) ||
                    u.TenSP.ToLower().Contains(keyword.ToLower()) ||
                    u.MoTa.ToLower().Contains(keyword.ToLower()) ||
                    u.HangSX.ToLower().Contains(keyword.ToLower())).ToList();

        }

        public bool KiemTraSL(string masp, int soluongmua)
        {
            return list.DSSanPham().SingleOrDefault(u => u.MaSP == masp).SoLuongTon < soluongmua ? false : true;

        }

        public bool Them(DTO_SanPham sanPham)
        {
            return list.Them(sanPham);
        }


    }
}
