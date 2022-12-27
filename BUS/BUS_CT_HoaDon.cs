using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CT_HoaDon
    {
        DAO_CT_HoaDon chitiets = new DAO_CT_HoaDon();

        public List<DTO_CT_HoaDon> DSCT_TheoHD(string mahd)
        {
            return chitiets.DSCT_HoaDon().Where(u => u.MaHD == int.Parse(mahd)).ToList();
        }

        public decimal TongDT(DateTime ngay)
        {
            List<DTO_HoaDon> hoaDons = new DAO_HoaDon().DSHoaDon().Where(u => u.NgayLapHD.ToString("dd/MM/yyyy") == ngay.ToString("dd/MM/yyyy")).ToList();
            decimal sum = 0;
            foreach (var hd in hoaDons)
                foreach (var ct in DSCT_TheoHD(hd.MaHD.ToString()))
                    sum += ct.DonGia * ct.SoLuong - ct.GiamGia;
            return sum;
        }
    }
}
