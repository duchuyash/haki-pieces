using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_YeuCau
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_YeuCau> DSYeuCau()
        {
            return _database.YeuCaus.Select(u => new DTO_YeuCau
            {
                MaYC = u.MaYC,
                MaSP = u.MaSP,
                SLYeuCau = u.SLYeuCau.Value,
                TenSP = u.SanPham.TenSP,
                DonGia = u.SanPham.DonGiaBan.Value
            }
            ).ToList();
        }

        public void Xoa(int mayc)
        {
            List<YeuCau> yeuCaus = _database.YeuCaus.Where(u => u.MaYC == mayc).ToList();
            _database.YeuCaus.RemoveRange(yeuCaus);
            _database.SaveChanges();
        }

        public bool YeuCau(List<string> DSSP)
        {
            if (DSSP.Count == 0)
                return false;

            int mayc = _database.YeuCaus.Count() + 1;
            List<YeuCau> list = new List<YeuCau>();
            foreach(var yc in DSSP)
            {
                list.Add(new YeuCau
                {
                    MaYC = mayc,
                    MaSP = yc,
                    SLYeuCau= 100,
                });
            }

            _database.YeuCaus.AddRange(list);
            _database.SaveChanges();
            return true;
        }
    }
}
