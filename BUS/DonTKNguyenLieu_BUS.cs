using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonTKNguyenLieu_BUS
    {
        public static List<DonTKNguyenLieu_DTO> LoadDon() => DonTKNguyenLieu_DAO.LoadDon();
        public static List<DonTKNguyenLieu_DTO> LoadDon(string ThoiGian) => DonTKNguyenLieu_DAO.LoadDon(ThoiGian);
        public static void LayTTNguyenLieu(DonTKNguyenLieu_DTO donTK) => DonTKNguyenLieu_DAO.LayTTNguyenLieu(donTK);

    }
}
