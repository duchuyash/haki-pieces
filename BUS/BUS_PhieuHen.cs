using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuHen
    {
        DAO_PhieuHen phs = new DAO_PhieuHen();

        public List<DTO_PhieuHen> DSPhieuHen()
        {
            return phs.DSPhieuHen().ToList() ;
        }

        public DTO_PhieuHen PhieuHenHD(int mahd)
        {
            return phs.DSPhieuHen().SingleOrDefault(u=>u.MaHD==mahd);
        }

        public List<DTO_PhieuHen> PhieuHenNgay(DateTime ngayhen)
        {
            return phs.DSPhieuHen().Where(u => u.TrangThai == false && u.NgayHen.ToString("dd/MM/yyyy") == ngayhen.ToString("dd/MM/yyyy")).ToList();
        }

        public bool Them(DTO_PhieuHen phieuHen)
        {
            return phs.Them(phieuHen);
        }

        public bool HoanThanh(int maph)
        {
            return phs.HoanThanh(maph);
        }
    }
}
