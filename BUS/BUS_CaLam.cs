using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CaLam
    {
        DAO_CaLam list = new DAO_CaLam();
        public List<DTO_CaLam> DSCaLam()
        {
            return list.DSCaLam();
        }

        public bool Them(DTO_CaLam caLam)
        {
            return list.Them(caLam);
        }

        public List<DTO_CaLam> CaLam(string manv)
        {
            return list.DSCaLam().Where(u => u.TenTK == manv).ToList();
        }

    }
}
