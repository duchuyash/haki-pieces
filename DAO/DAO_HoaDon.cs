using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_HoaDon
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_HoaDon> DSHoaDon()
        {
            return _database.HoaDons.Select(u => new DTO_HoaDon
            {
                MaHD = u.MaHD,
                TenTK = u.TenTK,
                NgayLapHD = u.NgayLapHD.Value,
                TrangThai = u.TrangThai.Value,

                CT_HoaDons =_database.CT_HoaDon.Select(v => new DTO_CT_HoaDon
                {
                    MaHD = v.MaHD,
                    MaSP = v.MaSP,
                    TenSP = _database.SanPhams.FirstOrDefault(t => t.MaSP == v.MaSP).TenSP,
                    SoLuong = v.SoLuong.Value,
                    DonGia = v.DonGia.Value,
                    GiamGia=v.GiamGia.Value
                }
                ).ToList(),

                ThuNgan = _database.NhanViens.FirstOrDefault(v => v.MaNV == u.TenTK) == null ?
                    "" : _database.NhanViens.FirstOrDefault(v => v.MaNV == u.TenTK).HoTen.ToString(),

                Hen = _database.PhieuHens.FirstOrDefault(v=>v.MaHD==u.MaHD)==null ? false: true,
            }
            ).ToList();
        }

        public bool Them(DTO_HoaDon hoaDon)
        {
            try
            {            
                HoaDon hd = new HoaDon
                {
                    TenTK = hoaDon.TenTK,
                    NgayLapHD = hoaDon.NgayLapHD, 
                    TrangThai= true
                };

                _database.HoaDons.Add(hd);
                _database.SaveChanges();

                foreach (var ct in hoaDon.CT_HoaDons)
                {
                    CT_HoaDon cthd = new CT_HoaDon
                    {
                        MaHD = _database.HoaDons.Select(u => u.MaHD).Max(),
                        MaSP = ct.MaSP,
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia,
                        GiamGia = ct.GiamGia
                    };

                    _database.CT_HoaDon.Add(cthd);
                    _database.SaveChanges();
                }

                int mayc = _database.YeuCaus.Count() == 0 ? 1 : _database.YeuCaus.Select(u => u.MaYC).Max() + 1;

                foreach (var ct in hoaDon.CT_HoaDons)
                { 
                    if (hoaDon.Hen)
                    {
                        YeuCau yc = new YeuCau
                        {
                            MaYC = mayc,
                            MaSP = ct.MaSP,
                            SLYeuCau = ct.SoLuong
                        };
                        _database.YeuCaus.Add(yc);
                        _database.SaveChanges();
                    }
                    else
                    {
                        SanPham sp = _database.SanPhams.SingleOrDefault(u => u.MaSP == ct.MaSP);
                        sp.SoLuongTon -= ct.SoLuong;
                        _database.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
