using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhapKho
    {
        DAO_NhapKho nhapKho = new DAO_NhapKho();
        public bool NhapKho(List<DTO_NhapKho> nhapkho)
        {
            return nhapKho.NhapKho(nhapkho);
        }
    }
}
