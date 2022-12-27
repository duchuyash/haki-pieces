using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_YeuCau
    {
        DAO_YeuCau yeuCau = new DAO_YeuCau();
        public List<DTO_YeuCau> DSYeuCau()
        {
            return yeuCau.DSYeuCau();
        }
        public void Xoa(int mayc)
        {
            yeuCau.Xoa(mayc);
        }
        public bool YeuCau(List<string> DSSP)
        {
            return yeuCau.YeuCau(DSSP);
        }
    }
}
