using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace RestaurantManagerment
{
    public partial class FormTKKho : Form
    {
        internal string ID;
        public FormTKKho()
        {
            InitializeComponent();
        }

        private void FormTKKho_Load(object sender, EventArgs e)
        {
            LoadKhoNguyenLieu();
        }
        List<NguyenLieu_DTO> lstNL;
        private void LoadKhoNguyenLieu()
        {
            flplistNL.Controls.Clear();
            lstNL = NguyenLieu_BUS.LoadNguyenLieu();
            if (lstNL == null) return;
            for (int i = 0; i < lstNL.Count; i++)
            {
                string ID = lstNL[i].MaNL.ToString();
                string s = lstNL[i].TenNL;
                Label lb1 = new Label();
                Label lb2 = new Label();
                lb1.Font = new Font("Microsoft Sans Serif", 12);
                lb1.Margin = new Padding(3, 6, 0, 3);
                lb2.Font = new Font("Microsoft Sans Serif", 12);
                lb2.Margin = new Padding(0, 6, 0, 3);
                TextBox txt = new TextBox();
                txt.Font = new Font("Microsoft Sans Serif", 12);
                txt.KeyPress += Txt_KeyPress;
                txt.TextChanged += Txt_TextChanged;
                lb1.Text = s;
                lb1.Name = ID;
                lb2.Text = lstNL[i].Donvi;
                lb2.Name = s;
                txt.Text = "0";
                txt.Name = s;
                flplistNL.Controls.Add(lb1);
                flplistNL.Controls.Add(txt);
                flplistNL.Controls.Add(lb2);
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text=="")
            {
                t.Text = "0";
            }    
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TongKetTK(string Ten, int SL)
        {
            NguyenLieu_BUS.ThongKeSLNguyenLieu(Ten, SL);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int SL;
            DonTKNguyenLieu_DTO donTK = new DonTKNguyenLieu_DTO();
            donTK.IdNhanVienTK = ID;
            donTK.TenNhanVienTK = NhanVien_BUS.TimNV(ID).TenNhanVien;
            string s = "";
            foreach (Control c in flplistNL.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text != "0")
                    {
                        string DV = NguyenLieu_BUS.LayDVNguyenLieu(c.Name);
                        SL = NguyenLieu_BUS.LaySLNguyenLieu(c.Name);
                        SL = SL - int.Parse(c.Text);
                        if (SL>=0) TongKetTK(c.Name,SL);
                        else
                        {
                            MessageBox.Show("Số lượng nguyên liệu sử dụng của " + c.Name + " không được nhiều hơn số lượng trong kho","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return;
                        }    
                        s = s + c.Name + ":" + c.Text + DV  + "\n";
                    }
                }
            }
            donTK.ThongKe = s;
            DonTKNguyenLieu_BUS.LayTTNguyenLieu(donTK);
            this.Close();
        }
    }
}

