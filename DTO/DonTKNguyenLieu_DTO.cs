using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonTKNguyenLieu_DTO
    {
        private string thoiGian;
        private string idNhanVienTK;
        private string tenNhanVienTK;
        private string thongKe;

        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string IdNhanVienTK { get => idNhanVienTK; set => idNhanVienTK = value; }
        public string TenNhanVienTK { get => tenNhanVienTK; set => tenNhanVienTK = value; }
        public string ThongKe { get => thongKe; set => thongKe = value; }
    }
}
