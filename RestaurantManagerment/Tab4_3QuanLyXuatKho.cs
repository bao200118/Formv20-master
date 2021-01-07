using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SQLite;
using DAO;
using System.Globalization;

namespace RestaurantManagerment
{
    public partial class Tab4_3QuanLyXuatKho : UserControl
    {
        public Tab4_3QuanLyXuatKho()
        {
            InitializeComponent();
            
        }
        List<DonTKNguyenLieu_DTO> dsDon;
        List<int> ID = new List<int>();
        private void LoadDon()
        {
            dsDon = DonTKNguyenLieu_BUS.LoadDon();
            gDGVDon.DataSource = dsDon;
            if (dsDon == null)
                return;
            gDGVDon.Columns["ThoiGian"].HeaderText = "Thời Gian Xuất";
            gDGVDon.Columns["IDNhanVienTK"].HeaderText = "Mã Nhân Viên Thống Kê";
            gDGVDon.Columns["TenNhanVienTK"].HeaderText = "Tên Nhân Viên Thống Kê";
            gDGVDon.Columns["ThongKe"].HeaderText = "Thống kê";
            gDGVDon.Columns["ThongKe"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gDGVDon.Columns["ThoiGian"].Width = 175;
            gDGVDon.Columns["IDNhanVienTK"].Width = 170;
            gDGVDon.Columns["TenNhanVienTK"].Width = 170;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDon();
        }

        private void Tab4_3QuanLyXuatKho_Enter(object sender, EventArgs e)
        {
            LoadDon();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dsDon = DonTKNguyenLieu_BUS.LoadDon(dtpNgay.Value.ToString("dd/MM/yyyy"));
            gDGVDon.DataSource = dsDon;
            if (dsDon == null)
                return;
            gDGVDon.Columns["ThoiGian"].HeaderText = "Thời Gian Xuất";
            gDGVDon.Columns["IDNhanVienTK"].HeaderText = "Mã Nhân Viên Thống Kê";
            gDGVDon.Columns["TenNhanVienTK"].HeaderText = "Tên Nhân Viên Thống Kê";
            gDGVDon.Columns["ThongKe"].HeaderText = "Thống kê";
            gDGVDon.Columns["ThongKe"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int i = 0; i < 4; i++)
            {
                gDGVDon.AutoResizeColumn(i);
            }
        }

        private void Tab4_3QuanLyXuatKho_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.gDGVDon);
            LoadDon();
        }
    }
}
