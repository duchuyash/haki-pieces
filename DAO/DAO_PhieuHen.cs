using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_PhieuHen
    {

        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_PhieuHen> DSPhieuHen()
        {
            return _database.PhieuHens.Select(u => new DTO_PhieuHen
            {
                MaPH = u.MaPH,
                MaHD = u.MaHD,
                MaTV = u.MaTV.Value,
                DiaChiGiao = u.DiaChiGiao,
                NgayHen=u.NgayHen.Value,
                TrangThai=u.TrangThai.Value,

                ThanhVien = _database.ThanhViens.FirstOrDefault(v => v.MaTV == u.MaTV) == null ?
                "" : _database.ThanhViens.FirstOrDefault(v => v.MaTV == u.MaTV).TenKH.ToString(),

            }
            ).ToList();
        }

        public bool Them(DTO_PhieuHen phieuHen)
        {
            try
            {
                PhieuHen ph = new PhieuHen
                {
                    MaHD = _database.HoaDons.Select(u => u.MaHD).Max(),
                    MaTV = phieuHen.MaTV,
                    DiaChiGiao = phieuHen.DiaChiGiao,
                    NgayHen = phieuHen.NgayHen,
                    TrangThai = false
                };

                _database.PhieuHens.Add(ph);
                _database.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool HoanThanh(int maph)
        {
            PhieuHen ph = _database.PhieuHens.SingleOrDefault(u => u.MaPH == maph);
            if (ph != null)
            {
                ph.TrangThai = true;
                _database.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
