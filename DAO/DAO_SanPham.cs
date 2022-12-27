using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using DTO;
using System.Data.SqlTypes;

namespace DAO
{
    public class DAO_SanPham
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_SanPham> DSSanPham()
        {
            return _database.SanPhams.Select(u => new DTO_SanPham { 
                MaSP = u.MaSP, 
                TenSP = u.TenSP, 
                HinhAnh = u.HinhAnh, 
                HangSX = u.HangSX,
                MoTa = u.MoTa, 
                HSD = u.HSD.Value, 
                DonGiaBan = u.DonGiaBan.Value, 
                SoLuongTon = u.SoLuongTon.Value, 
                TrangThai = u.TrangThai.Value, 
            }
            ).ToList();
        }

        public bool Them(DTO_SanPham sanPham)
        {
            try
            {
                SanPham sp = new SanPham
                {
                    MaSP = sanPham.MaSP.ToUpper(),
                    TenSP = sanPham.TenSP,
                    DonGiaBan = sanPham.DonGiaBan,
                    HSD = sanPham.HSD,
                    HinhAnh = sanPham.HinhAnh,
                    HangSX = sanPham.HangSX,
                    MoTa = sanPham.MoTa,
                    SoLuongTon = 0,
                    TrangThai = true
                };

                _database.SanPhams.Add(sp);
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
