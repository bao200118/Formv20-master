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
    public partial class Tab2 : UserControl
    {
        internal string TKDN;
        public Tab2()
        {
            InitializeComponent();
        }

        private void btnThongTinMonAn_Click(object sender, EventArgs e)
        {
            tab2_1ThongTinMonAn1.BringToFront();
            
        }

        private void btnNhomMonAn_Click(object sender, EventArgs e)
        {
            tab2_2NhomMonAn1.BringToFront();

        }

        private void Tab2QLThucDon_Load(object sender, EventArgs e)
        {
            tab2_1ThongTinMonAn1.TKDN = TKDN;
            tab2_2NhomMonAn1.TKDN = TKDN;
            Tab2_3ThongTinNguyenLieu1.TKDN = TKDN;
            this.Controls.Add(tab2_2NhomMonAn1);
            this.Controls.Add(tab2_1ThongTinMonAn1);
            this.Controls.Add(Tab2_3ThongTinNguyenLieu1);
            tab2_1ThongTinMonAn1.BringToFront();
        }

        private void btnThongTinNguyenLieu_Click(object sender, EventArgs e)
        {
            Tab2_3ThongTinNguyenLieu1.BringToFront();
            Tab2_3ThongTinNguyenLieu1.Select();
        }

        private void Tab2_Enter(object sender, System.EventArgs e)
        {
            Tab2_3ThongTinNguyenLieu1.Select();
        }

    }
}
