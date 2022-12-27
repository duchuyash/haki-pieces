using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SuKien
    {
        public DAO_SuKien suKiens = new DAO_SuKien();
        public List<DTO_SuKien> DSSuKien()
        {
            return suKiens.DSSuKien();
        }

        public List<DTO_SuKien> DSSuKien_Filler(DateTime tu, DateTime den)
        {
            return suKiens.DSSuKien().Where(u=>
            (tu >= u.NgayBD && tu <= u.NgayKT)||
            (den >= u.NgayBD && den <= u.NgayKT) || 
            (tu <= u.NgayBD && den >= u.NgayKT)).ToList();
        }

        public List<DTO_KhuyenMai> CT_SuKien(string mask)
        {
            return suKiens.DSSuKien().SingleOrDefault(u => u.MaSK == int.Parse(mask)).KhuyenMai;
        }
    }
}
