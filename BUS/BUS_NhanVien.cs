using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAO_NhanVien list = new DAO_NhanVien();

        public List<DTO_NhanVien> DSNhanVien()
        {
            return list.DSNhanVien();
        }

        public DTO_NhanVien NhanVien(string manv)
        {
            return list.DSNhanVien().SingleOrDefault(u => u.MaNV == manv);
        }

        public List<DTO_NhanVien> TimKiem(string keyword)
        {
            return list.DSNhanVien().Where(u =>
                    u.MaNV.ToString().ToLower().Contains(keyword.ToLower()) ||
                    u.HoTen.ToLower().Contains(keyword.ToLower()) ||
                    u.CMND.ToLower().Contains(keyword.ToLower()) ||
                    u.DiaChi.ToLower().Contains(keyword.ToLower()) ||
                    u.SDT.ToLower().Contains(keyword.ToLower())
                    ).ToList();

        }

        public bool Them(DTO_NhanVien nhanVien)
        {
            return list.Them(nhanVien);
        }

        public bool CapNhat(DTO_NhanVien nhanVien)
        {
            return list.CapNhat(nhanVien);
        }

        public bool Khoa(string manv)
        {
            return list.Khoa(manv);
        }
    }
}
