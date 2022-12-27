using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAO_HoaDon hds = new DAO_HoaDon();
        public List<DTO_HoaDon> DSHoaDon()
        {
            return hds.DSHoaDon();
        }

        public List<DTO_HoaDon> DSHoaDonNgay(DateTime ngaylaphd)
        {
            return hds.DSHoaDon().Where(u => u.NgayLapHD.ToString("dd/MM/yyyy") == ngaylaphd.ToString("dd/MM/yyyy")).ToList();
        }

        public bool Them(DTO_HoaDon hoaDon)
        {
            return hds.Them(hoaDon);
        }
    }
}
