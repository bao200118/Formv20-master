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
    public class NguyenLieu_DAO
    {
        static SQLiteConnection conn;
        public static List<NguyenLieu_DTO> LoadNguyenLieu()
        {
            string chuoiTruyVan = "Select * From NguyenLieu ";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu_DTO> lstNguyenLieu = new List<NguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu_DTO nguyenlieu = new NguyenLieu_DTO();
                nguyenlieu.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                nguyenlieu.TenNL = dt.Rows[i]["TenNL"].ToString();
                nguyenlieu.Donvi = dt.Rows[i]["DonVi"].ToString();
                nguyenlieu.Soluong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

                lstNguyenLieu.Add(nguyenlieu);
            }
            DataProvider.CloseConnection(conn);
            return lstNguyenLieu;
        }
        // ------------------------ thêm nguyên liệu -----------------------
        public static bool ThemNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {

            string QueryString = string.Format("insert into NguyenLieu(TenNL,DonVi,SoLuong) values('{0}','{1}','{2}')", nguyenlieu.TenNL, nguyenlieu.Donvi, nguyenlieu.Soluong);
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
        // sửa nguyên liệu
        public static bool SuaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {

            string QueryString = string.Format("update NguyenLieu set TenNL = '{0}',DonVi='{1}',SoLuong='{2}' where MaNL = '{3}'", nguyenlieu.TenNL, nguyenlieu.Donvi, nguyenlieu.Soluong, nguyenlieu.MaNL);
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

        // xóa nguyên liệu
        public static bool XoaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {

            string QueryString = string.Format("Delete from NguyenLieu Where TenNL = '{0}'", nguyenlieu.TenNL);
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
        // ---------------- tìm kiếm nguyên liệu ---------------------------
        public static List<NguyenLieu_DTO> TimNguyenLieu(string tenNguyenLieu)
        {
            string QueryString = string.Format("select * from NguyenLieu where  TenNL like '%" + tenNguyenLieu + "%'");
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu_DTO> lstNguyenLieu = new List<NguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu_DTO nguyenlieu = new NguyenLieu_DTO();

                nguyenlieu.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                nguyenlieu.TenNL = dt.Rows[i]["TenNL"].ToString();
                nguyenlieu.Donvi = dt.Rows[i]["DonVi"].ToString();
                nguyenlieu.Soluong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

                lstNguyenLieu.Add(nguyenlieu);
            }
            DataProvider.CloseConnection(conn);
            return lstNguyenLieu;
        }
        public static List<String> DSMaNL()
        {
            List<string> str = new List<string>();
            string QueryString = "Select MaNL From NguyenLieu";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str.Add(dt.Rows[i]["MaNL"].ToString());
            }
            DataProvider.CloseConnection(conn);
            return str;
        }
        public static NguyenLieu_DTO LayTTNguyenLieu(int ID)
        {
            NguyenLieu_DTO nl = new NguyenLieu_DTO();
            string QueryString = "Select TenNL,DonVi,SoLuong From NguyenLieu Where MaNL= " + ID;
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            nl.TenNL = dt.Rows[0]["TenNL"].ToString();
            nl.Donvi = dt.Rows[0]["DonVi"].ToString();
            nl.Soluong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
            DataProvider.CloseConnection(conn);
            return nl;
        }
        public static bool ThongKeSLNguyenLieu(string Ten, int SL)
        {
            string QueryString = string.Format("update NguyenLieu set SoLuong='{0}' where TenNL = '{1}'", SL, Ten);
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
        public static int LaySLNguyenLieu(string Ten)
        {
            string QueryString = $"Select SoLuong From NguyenLieu Where TenNL= '{Ten}'";
            conn = DataProvider.OpenConnection();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["SoLuong"].ToString());
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return -1;
            }
        }
        public static string LayDVNguyenLieu(string Ten)
        {
            string QueryString = $"Select DonVi From NguyenLieu Where TenNL= '{Ten}'";
            conn = DataProvider.OpenConnection();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["DonVi"].ToString();
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return "";
            }

        }
    }
}
