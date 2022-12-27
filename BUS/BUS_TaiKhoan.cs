using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAO_TaiKhoan list = new DAO_TaiKhoan();

        public List<DTO_TaiKhoan> DSTaiKhoan()
        {
            return list.DSTaiKhoan();
        }

        public bool KT_HopLe(DTO_TaiKhoan tk)
        {
            //DTO_TaiKhoan user = list.DSTaiKhoan().SingleOrDefault(u => u.TenTK == tk.TenTK && u.MatKhau == tk.MatKhau + "iamash");
            DTO_TaiKhoan user = list.DSTaiKhoan().SingleOrDefault(u =>
            u.TenTK == tk.TenTK &&
            DTO_Function.GiaiMaHoa(u.MatKhau) == tk.MatKhau &&
            u.TrangThai == true);

            return user != null;
        }
    }
}
