using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThanhVien
    {
        DAO_ThanhVien list = new DAO_ThanhVien();

        public List<DTO_ThanhVien> DSThanhVien()
        {
            return list.DSThanhVien();
        }

        public List<DTO_ThanhVien> TimKiem(string keyword)
        {
            return list.DSThanhVien().Where(u =>
                    u.MaTV.ToString().ToLower().Contains(keyword.ToLower()) ||
                    u.TenKH.ToLower().Contains(keyword.ToLower()) ||
                    u.DiaChi.ToLower().Contains(keyword.ToLower()) ||
                    u.SDT.ToLower().Contains(keyword.ToLower())).ToList();

        }

        public bool KT_TonTai(string matv)
        {
            DTO_ThanhVien thanhvien = list.DSThanhVien().SingleOrDefault(u => u.MaTV == int.Parse(matv));
            return thanhvien != null;
        }

        public bool Them(DTO_ThanhVien thanhvien)
        {
            return list.Them(thanhvien);
        }

    }

}
