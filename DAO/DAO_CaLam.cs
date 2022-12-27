using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_CaLam
    {
        HaKi_PieceEntities _database = new HaKi_PieceEntities();

        public List<DTO_CaLam> DSCaLam()
        {
            return _database.CaLams.Select(u => new DTO_CaLam
            {
                MaCa = u.MaCa,
                TenTK = u.TenTK,
                ThoiGianBD=u.ThoiGianBD.Value,
                ThoiGianKT=u.ThoiGianKT.Value,
            }
            ).ToList();
        }

        public bool Them(DTO_CaLam caLam)
        {
            try
            {
                CaLam ca = new CaLam
                {
                    TenTK = caLam.TenTK,
                    ThoiGianBD = caLam.ThoiGianBD,
                    ThoiGianKT = caLam.ThoiGianKT
                };

                _database.CaLams.Add(ca);
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
