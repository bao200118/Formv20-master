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
using System.Text.RegularExpressions;
using System.Globalization;

namespace RestaurantManagerment
{
    public partial class Tab4_1QuanLiHoaDon : UserControl
    {
        public Tab4_1QuanLiHoaDon()
        {
            InitializeComponent();
        }

        private void Tab4_1QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            LayDanhSachHoaDon();
        }
        List<QuanLiHoaDon_DTO> lstHoaDon;
        void LayDanhSachHoaDon()
        {
            lstHoaDon = HoaDonOrder_BUS.DanhSachHoaDon();
            dgvDanhSachHoaDon.DataSource = lstHoaDon;
            if (lstHoaDon == null)
                return;

            dgvDanhSachHoaDon.Columns["IDHoaDon"].HeaderText = "So HD";
            dgvDanhSachHoaDon.Columns["TenBan"].HeaderText = "Tên Bàn";
            dgvDanhSachHoaDon.Columns["TinhTrangThanhToan"].HeaderText = "Tình Trạng Thanh Toán";
            dgvDanhSachHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày Thanh Toán";
            dgvDanhSachHoaDon.Columns["SoTien"].HeaderText = "Số Tiền";

            dgvDanhSachHoaDon.Columns["IDHoaDon"].Width = 70;
            dgvDanhSachHoaDon.Columns["TenBan"].Width = 150;
            dgvDanhSachHoaDon.Columns["TinhTrangThanhToan"].Width = 150;
            dgvDanhSachHoaDon.Columns["NgayThanhToan"].Width = 130;
            dgvDanhSachHoaDon.Columns["SoTien"].Width = 125;
        }

        //------------------Lọc Hóa Đơn---------------
        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<QuanLiHoaDon_DTO> lstHD = new List<QuanLiHoaDon_DTO>();
            DateTime d = new DateTime();
            foreach (QuanLiHoaDon_DTO hd in lstHoaDon)
            {
                d = DateTime.ParseExact(hd.NgayThanhToan, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if(DateTime.Compare(dtpTuNgay.Value,d)<=0 && DateTime.Compare(d,dtpDenNgay.Value)<=0)
                {
                    lstHD.Add(hd);
                }    
            }
            dgvDanhSachHoaDon.DataSource = lstHD;
        }

        //----------------------Hiển Thị Tất Cả--------------------
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LayDanhSachHoaDon();
        }

        //--------------------- lấy 1 dòng đc chọn----------------------
        DataGridViewRow dr;
        private void dgvDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                dr = dgvDanhSachHoaDon.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
        }

        //---------------Xóa Hóa Đơn-----------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dr == null)
            {
                MessageBox.Show("Chọn hóa đơn muốn xóa");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (HoaDonOrder_BUS.XoaHoaDon(int.Parse(dr.Cells["IDHoaDon"].Value.ToString())))
                {
                    dr = null;
                    LayDanhSachHoaDon();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        //------------------Xóa Tất cả Hóa đơn-----------
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lstHoaDon == null)
                return;
            if (MessageBox.Show("Xóa toàn bộ hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HoaDonOrder_BUS.XoaToanBoHoaDon();
                MessageBox.Show("Đã xóa");
                LayDanhSachHoaDon();
                return;
            }
        }
    }
}
