using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAO
{
    public class DAO_NhanVien
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_NhanVien> DSNhanVien()
        {
            return _database.NhanViens.Select(u => new DTO_NhanVien
            {
                MaNV =u.MaNV,
                HoTen=u.HoTen,
                SDT=u.SDT,
                CMND=u.CMND,
                DiaChi=u.DiaChi,
                Luong=u.Luong.Value,
                HinhAnh=u.HinhAnh,
                TrangThai = u.TrangThai.Value,
                ChucVu = u.MaNV.Substring(0,2) == "QL" ? "Quản lý" : "Bán hàng",
            }).ToList();
        }

        public bool Them(DTO_NhanVien nhanVien)
        {
            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNV = nhanVien.MaNV,
                    CMND = nhanVien.CMND,
                    DiaChi = nhanVien.DiaChi,
                    Luong = nhanVien.Luong,
                    HinhAnh = nhanVien.HinhAnh,
                    HoTen = nhanVien.HoTen,
                    SDT = nhanVien.SDT,
                    TrangThai = true
                };

                _database.NhanViens.Add(nv);
                _database.SaveChanges();

                TaiKhoan tk = new TaiKhoan
                {
                    TenTK = nhanVien.MaNV,
                    MatKhau = DTO_Function.MaHoa(nhanVien.TaiKhoan.MatKhau),
                    Email = nhanVien.TaiKhoan.Email + "@gmail.com",
                    TrangThai = true
                };

                _database.TaiKhoans.Add(tk);
                _database.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CapNhat(DTO_NhanVien nhanVien)
        {
            NhanVien nv = _database.NhanViens.SingleOrDefault(u => u.MaNV == nhanVien.MaNV);

            nv.MaNV = nhanVien.MaNV;
            nv.CMND = nhanVien.CMND;
            nv.DiaChi = nhanVien.DiaChi;
            nv.Luong = nhanVien.Luong;
            nv.HoTen = nhanVien.HoTen;
            nv.SDT = nhanVien.SDT;

            TaiKhoan tk = _database.TaiKhoans.SingleOrDefault(u => u.TenTK == nhanVien.MaNV);
            tk.Email = nhanVien.TaiKhoan.Email;

            _database.SaveChanges();
            return true;
            
        }

        public bool Khoa(string manv)
        {
            NhanVien nv = _database.NhanViens.SingleOrDefault(u => u.MaNV == manv);
            TaiKhoan tk = _database.TaiKhoans.SingleOrDefault(u => u.TenTK == manv);
            nv.TrangThai = tk.TrangThai = !nv.TrangThai;

            _database.SaveChanges();

            return nv.TrangThai.Value;
        }
    }
}
