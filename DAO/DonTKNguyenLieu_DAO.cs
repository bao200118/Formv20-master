using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonTKNguyenLieu_DAO
    {
        static SQLiteConnection conn;
        public static List<DonTKNguyenLieu_DTO> LoadDon()
        {
            string chuoiTruyVan = "Select * From TongKetNL ";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DonTKNguyenLieu_DTO> lstDon = new List<DonTKNguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonTKNguyenLieu_DTO don = new DonTKNguyenLieu_DTO();
                don.ThoiGian = dt.Rows[i]["ThoiGian"].ToString();
                don.IdNhanVienTK = dt.Rows[i]["IdNhanVienTK"].ToString();
                don.TenNhanVienTK = dt.Rows[i]["TenNhanVienTK"].ToString();
                don.ThongKe =(dt.Rows[i]["ThongKe"].ToString());

                lstDon.Add(don);
            }
            DataProvider.CloseConnection(conn);
            return lstDon;
        }
        public static List<DonTKNguyenLieu_DTO> LoadDon(string ThoiGian)
        {
            string chuoiTruyVan = $"Select * From TongKetNL where substr(ThoiGian,0,11) ='{ThoiGian}' ";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<DonTKNguyenLieu_DTO> lstDon = new List<DonTKNguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonTKNguyenLieu_DTO don = new DonTKNguyenLieu_DTO();
                don.ThoiGian = dt.Rows[i]["ThoiGian"].ToString();
                don.IdNhanVienTK = dt.Rows[i]["IdNhanVienTK"].ToString();
                don.TenNhanVienTK = dt.Rows[i]["TenNhanVienTK"].ToString();
                don.ThongKe = (dt.Rows[i]["ThongKe"].ToString());

                lstDon.Add(don);
            }
            DataProvider.CloseConnection(conn);
            return lstDon;
        }
        public static bool LayTTNguyenLieu(DonTKNguyenLieu_DTO donTK)
        {
            string QueryString = string.Format("insert into TongKetNL(ThoiGian,IDNhanVienTK,TenNhanVienTK,ThongKe) values('{0}','{1}','{2}','{3}')", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), donTK.IdNhanVienTK, donTK.TenNhanVienTK,donTK.ThongKe);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(QueryString, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }
    }
}
