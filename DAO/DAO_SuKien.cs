using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_SuKien
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_SuKien> DSSuKien()
        {
            return _database.SuKiens.Select(u => new DTO_SuKien
            {
                HinhAnh = u.HinhAnh,
                MaSK = u.MaSK,
                MoTa = u.MoTa,
                NgayBD = u.NgayBD.Value,
                NgayKT = u.NgayKT.Value,

                KhuyenMai = _database.KhuyenMais.Where(v => v.MaSK == u.MaSK).Select(v => new DTO_KhuyenMai
                {
                    MaSK = v.MaSK,
                    MaSP = v.MaSP,
                    SLToiThieu = v.SLToiThieu.Value,
                    Giam = v.Giam.Value,
                    PhanTram = v.PhanTram.Value,
                    TenSP = v.SanPham.TenSP,
                    GiaBan = v.SanPham.DonGiaBan.Value

                }).ToList(),
                TrangThai = u.TrangThai.Value
            }
            ).ToList();
        }
    }
}
