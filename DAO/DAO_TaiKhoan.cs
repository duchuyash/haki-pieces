using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_TaiKhoan> DSTaiKhoan()
        {
            return _database.TaiKhoans.Select(u => new DTO_TaiKhoan { 
                TenNV=u.NhanVien.HoTen,
                TenTK = u.TenTK, 
                MatKhau = u.MatKhau,
                Email = u.Email, 
                TrangThai = u.TrangThai.Value }).ToList();
        }

    }
}
