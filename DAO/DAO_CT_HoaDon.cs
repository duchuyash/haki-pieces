using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_CT_HoaDon
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_CT_HoaDon> DSCT_HoaDon()
        {
            return _database.CT_HoaDon.Select(u => new DTO_CT_HoaDon
            {
                MaHD = u.MaHD,
                MaSP = u.MaSP,
                TenSP = _database.SanPhams.FirstOrDefault(v => v.MaSP == u.MaSP).TenSP,
                SoLuong = u.SoLuong.Value,
                DonGia = u.DonGia.Value, 
                GiamGia = u.GiamGia.Value
            }
            ).ToList();
        }
    }
}
