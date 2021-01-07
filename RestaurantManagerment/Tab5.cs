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
using DAO;
using System.Globalization;
using System.Data.SQLite;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantManagerment
{
    public partial class Tab5 : UserControl
    {
        bool DaChay = true;
        string KieuTK="";
        public Tab5()
        {
            InitializeComponent();
        }
        private void BatBieuDo()
        {
            lbBieuDo.Visible = true;
            lbTK.Visible = true;
            chartDoanhThu.Visible = true;
            cbNam.Visible = true;
        }

        private string DoanhThu(List<QuanLiHoaDon_DTO> lstHoaDon)
        {
            long doanhThu = 0;
            if (lstHoaDon != null)
            {
                foreach (QuanLiHoaDon_DTO hd in lstHoaDon)
                {
                    doanhThu += long.Parse(hd.SoTien);
                }
            }
            CultureInfo cul = new CultureInfo("vi-VN");
            return doanhThu.ToString("c", cul);
        }
        public void BangThongKeTheoNam()
        {
            int KCNam;
            if (cbNam.Text == "10 năm")
            {
                KCNam = 10;
            }
            else KCNam = 5;
            DataTable dtHoaDon = HoaDonOrder_DAO.LocHoaDonTheoNam(DateTime.Now.ToString("yyyy"), KCNam);
            List<QuanLiHoaDon_DTO> lstHD = new List<QuanLiHoaDon_DTO>();
            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.NgayThanhToan = dtHoaDon.Rows[i]["Nam"].ToString();
                hoaDon.SoTien = dtHoaDon.Rows[i]["DoanhThu"].ToString();
                lstHD.Add(hoaDon);
            }
            if (lstHD == null)
            {
                MessageBox.Show("Không có kết quả nào");
                return;
            }
            CultureInfo cul = new CultureInfo("vi-VN");
            lbDTNum.Text = DoanhThu(lstHD);
            chartDoanhThu.DataSource = dtHoaDon;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";

            chartDoanhThu.Series["Doanh Thu"].XValueMember = "Nam";
            chartDoanhThu.Series["Doanh Thu"].YValueMembers = "DoanhThu";
        }
        private void btnThongKeHangNam_Click(object sender, EventArgs e)
        {
            BatBieuDo();
            cbNam.Items.Clear();
            KieuTK = "Nam";
            lbTK.Text = "Thống kê hàng năm";
            cbNam.Items.Add("10 năm");
            cbNam.Items.Add("5 năm");
            cbNam.Text = "10 năm";
            BangThongKeTheoNam();
        }

        private void cbNam_TextChanged(object sender, EventArgs e)
        {
            if (KieuTK == "Nam")
            {
                BangThongKeTheoNam();

            }
            else if (KieuTK == "Thang"&&!DaChay)
            {
                BangThongKeTheoThang();

            }
            DaChay = false;
        }
        public void BangThongKeTheoThang()
        {
            BatBieuDo();
            DaChay = true;
            DataTable dtHoaDon = HoaDonOrder_BUS.LocHoaDonTheoThang(cbNam.Text);
            List<QuanLiHoaDon_DTO> lstHD = new List<QuanLiHoaDon_DTO>();
            if (dtHoaDon == null)
            {
                MessageBox.Show("Không có kết quả nào");
                return;
            }
            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.NgayThanhToan = dtHoaDon.Rows[i]["Thang"].ToString();
                hoaDon.SoTien = dtHoaDon.Rows[i]["DoanhThu"].ToString();
                lstHD.Add(hoaDon);
            }
            CultureInfo cul = new CultureInfo("vi-VN");
            lbDTNum.Text = DoanhThu(lstHD);
            chartDoanhThu.DataSource = dtHoaDon;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";

            chartDoanhThu.Series["Doanh Thu"].XValueMember = "Thang";
            chartDoanhThu.Series["Doanh Thu"].YValueMembers = "DoanhThu";

        }
        private void btnThongKeTheoThang_Click(object sender, EventArgs e)
        {
            DaChay = true;
            KieuTK = "Thang";
            lbTK.Text = "Thống kê hàng tháng";
            cbNam.Items.Clear();
            for (int i = 10; i >= 0; i--)
            {
                cbNam.Items.Add((int.Parse(DateTime.Now.ToString("yyyy")) - i));
            }
            cbNam.Text = cbNam.Items[10].ToString();
            BangThongKeTheoThang();
        }

        private void btnDoanhThuTrongNgay_Click(object sender, EventArgs e)
        {
            KieuTK = "Ngay";
            lbDTNum.Text = "Chưa có dữ liệu";
            lbBieuDo.Visible = false;
            lbTK.Visible = false;
            chartDoanhThu.Visible = false;
            cbNam.Visible = false;
            List<QuanLiHoaDon_DTO> lstHD = HoaDonOrder_BUS.DoanhThuTrongNgay(dtpNgay.Text);
            CultureInfo cul = new CultureInfo("vi-VN");
            if (lstHD != null) lbDTNum.Text = DoanhThu(lstHD);
        }

        private void Tab5_Load(object sender, EventArgs e)
        {
            lbBieuDo.Visible = false;
            lbTK.Visible = false;
            chartDoanhThu.Visible = false;
            cbNam.Visible = false;
        }

        private void gnBTN_IN_Click(object sender, EventArgs e)
        {
            if(KieuTK!="Ngay" && KieuTK!="")
                    {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                string timesTTF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.TTF");
                BaseFont arial = BaseFont.CreateFont(timesTTF, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                iTextSharp.text.Font f_24_Bold = new iTextSharp.text.Font(arial, 24, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font f_20_normal = new iTextSharp.text.Font(arial, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f_20_Bold = new iTextSharp.text.Font(arial, 20, iTextSharp.text.Font.BOLD);
                saveFileDialog1.Filter= "PDF|*.pdf";
                saveFileDialog1.Title = "Xuất file thống kê";
                saveFileDialog1.FileName = lbTK.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                FileStream os = new FileStream(@saveFileDialog1.FileName, FileMode.Create);

                using (os)
                {
                    PdfWriter wri = PdfWriter.GetInstance(doc, os);
                    doc.Open();

                    PdfPTable table = new PdfPTable(1);
                    PdfPCell par = new PdfPCell(new Phrase($"{lbTK.Text} " + cbNam.Text.ToString(), f_24_Bold));
                    PdfPCell par1 = new PdfPCell(new Phrase("\nNgày In:  " + dtpNgay.Value.ToString("dd/MM/yyyy"), f_20_normal));
                    PdfPCell par2 = new PdfPCell(new Phrase("Doanh thu:  " + lbDTNum.Text.ToString() + "\n", f_20_normal));

                    par.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    par1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    par2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    par.HorizontalAlignment = Element.ALIGN_CENTER;
                    par1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                    table.AddCell(par);
                    table.AddCell(par1);
                    table.AddCell(par2);
                    doc.Add(table);

                    //Biểu đồ
                    var charimage = new MemoryStream();
                    chartDoanhThu.SaveImage(charimage, ChartImageFormat.Png);
                    iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(charimage.GetBuffer());

                    doc.Add(chart_image);

                    doc.Close();
                    System.Diagnostics.Process.Start($"{lbTK.Text}.pdf");
                }
            }
        }
    }
}
