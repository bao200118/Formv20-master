using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagerment
{
    public partial class Tab4 : UserControl
    {
        internal string TKDN;
        public Tab4()
        {
            InitializeComponent();
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            tab4_1QuanLiHoaDon1.BringToFront();
        }

        private void Tab4_Enter(object sender, System.EventArgs e)
        {
            Tab4_3QuanLyXuatKho1.Select();
        }

        private void Tab4_Load(object sender, EventArgs e)
        {
            tab4_1QuanLiHoaDon1.TKDN = TKDN;
            Tab4_2QuanLiPhieuNhap1.TKDN = TKDN;
            this.Controls.Add(this.tab4_1QuanLiHoaDon1);
            this.Controls.Add(this.Tab4_2QuanLiPhieuNhap1);
            this.Controls.Add(this.Tab4_3QuanLyXuatKho1);
            tab4_1QuanLiHoaDon1.BringToFront();
        }

        private void btnQuanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            Tab4_2QuanLiPhieuNhap1.BringToFront();
        }

        private void btnQuanLyXuatKho_Click(object sender, EventArgs e)
        {
            Tab4_3QuanLyXuatKho1.BringToFront();
            Tab4_3QuanLyXuatKho1.Select();
        }
    }
}
