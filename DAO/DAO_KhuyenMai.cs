using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KhuyenMai
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();
        public List<DTO_KhuyenMai> DSKhuyenMai()
        {
            return _database.KhuyenMais.Select(u => new DTO_KhuyenMai
            {
                MaSK = u.MaSK,
                MaSP = u.MaSP,
                SLToiThieu = u.SLToiThieu.Value,
                Giam = u.Giam.Value,
                PhanTram = u.PhanTram.Value,
                TenSP = u.SanPham.TenSP,
                GiaBan=u.SanPham.DonGiaBan.Value
            }
            ).ToList();
        }
    }
}
