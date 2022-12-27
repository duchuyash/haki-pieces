using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_NhapKho
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();
        public bool NhapKho(List<DTO_NhapKho> nhapkho)
        {
            try
            {
                int malo = _database.NhapKhoes.Select(u => u.MaLo).Distinct().Count() + 1;
                foreach (var sp in nhapkho)
                {
                    NhapKho nk = new NhapKho
                    {
                        TenTK = sp.TenTK,
                        MaLo = malo,
                        MaSP = sp.MaSP,
                        DonGiaNhap = sp.DonGiaNhap,
                        SoLuong = sp.SoLuong,
                        NgayNhap = DateTime.Now,
                        TrangThai = true,
                    };
                    _database.NhapKhoes.Add(nk);
                    SanPham sanpham = _database.SanPhams.SingleOrDefault(u => u.MaSP == sp.MaSP);
                    sanpham.SoLuongTon += sp.SoLuong;
                }
                _database.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
