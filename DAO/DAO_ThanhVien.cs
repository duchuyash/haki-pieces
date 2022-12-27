using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_ThanhVien
    {

        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_ThanhVien> DSThanhVien()
        {
            return _database.ThanhViens.Select(u => new DTO_ThanhVien
            {
                MaTV = u.MaTV,
                TenKH = u.TenKH,
                SDT = u.SDT,
                DiaChi = u.DiaChi,
                TrangThai = u.TrangThai.Value
            }).ToList();
        }

        public bool Them(DTO_ThanhVien thanhvien)
        {
            try
            {
                ThanhVien tv = new ThanhVien
                {
                    TenKH = thanhvien.TenKH,
                    SDT = thanhvien.SDT,
                    DiaChi = thanhvien.DiaChi,
                    TrangThai = true
                };
                
                _database.ThanhViens.Add(tv);
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
