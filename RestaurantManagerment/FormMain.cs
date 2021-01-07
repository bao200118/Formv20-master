using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RestaurantManagerment
{
    public partial class FormMain : Form
    {
        Control c;
        Bunifu.Framework.UI.BunifuFlatButton button;
        string TaiKhoangDN;
        public FormMain()
        {
            TaiKhoangDN = "QL001";
            InitializeComponent();
            c = tab1;
        }
        public FormMain(string TKDN)
        {
            TaiKhoangDN = TKDN;
            InitializeComponent();
            c = tab1;
        }
        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            if (c != tab3)
            {
                button.colbackground = Color.White;
                tab3.BringToFront();
                c = tab3;
                button = QLNV;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            pnCoordinates.Location = new System.Drawing.Point(pnControl.Width, pnHeaderWhite.Height);
            pnCoordinates.Size = new System.Drawing.Size(this.Width - pnControl.Width, this.Height - pnHeaderWhite.Height);
            tab1.Location = new Point(0, 0);
            tab1.Size = new System.Drawing.Size(this.Width - pnControl.Width, this.Height - pnHeaderWhite.Height);
            tab2.Location = new Point(0, 0);
            tab2.Size = pnCoordinates.Size;
            tab3.Location = new Point(0, 0);
            tab3.Size = pnCoordinates.Size;
            tab4.Location = new Point(0, 0);
            tab4.Size = pnCoordinates.Size;
            tab5.Location = new Point(0, 0);
            tab5.Size = pnCoordinates.Size;
            tab1.TKDN = TaiKhoangDN;
            tab2.TKDN = TaiKhoangDN;
            tab3.TKDN = TaiKhoangDN;
            tab4.TKDN = TaiKhoangDN;
            LoadInPanel();
            button = QLBAn;
            button.BackColor = Color.FromArgb(136, 59, 176);
        }
        private void LoadInPanel()
        {
            pnCoordinates.Controls.Add(tab1);
            pnCoordinates.Controls.Add(tab2);
            pnCoordinates.Controls.Add(tab3);
            pnCoordinates.Controls.Add(tab4);
            pnCoordinates.Controls.Add(tab5);
        }

        private void QLBAn_Click(object sender, EventArgs e)
        {
            if (c != tab1)
            {
                button.colbackground = Color.White;
                tab1.BringToFront();
                tab1.Select();
                c = tab1;
                button = QLBAn;
            }
        }

        private void QLTD_Click(object sender, EventArgs e)
        {
            if (c != tab2)
            {
                button.colbackground = Color.White;
                tab2.BringToFront();
                tab2.Select();
                c = tab2;
                button = QLTD;
            }
        }
        private void QLHD_Click(object sender, EventArgs e)
        {
            if (c != tab4)
            {
                button.colbackground = Color.White;
                tab4.BringToFront();
                tab4.Select();
                c = tab4;
                button = QLHD;
            }
        }

        private void TK_Click(object sender, EventArgs e)
        {
            if (TaiKhoangDN.Substring(0, 2) == "NV")
            {
                TK.colselected = Color.White;
                button.colbackground = Color.FromArgb(136, 59, 176);
                MessageBox.Show("Chỉ có chức vụ quản lý mới được truy cập vào mục này.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (c != tab5)
                {
                    button.colbackground = Color.White;
                    tab5.BringToFront();
                    c = tab5;
                    button = QLHD;
                }
            }
        }

        #region MOUSE-EVENTS ON PANEL CONTROL
        // Routines to perform moving form by click & drag on TitleBar

        private bool m_MousePressed = false;
        private int m_oldX, m_oldY;
        void pnHeaderWhite_MouseDown(object sender, MouseEventArgs e)
        {
            Point TS = this.PointToScreen(e.Location);
            m_oldX = TS.X;
            m_oldY = TS.Y;
            m_MousePressed = true;
        }
        void pnHeaderWhite_MouseUp(object sender, MouseEventArgs e)
        {
            m_MousePressed = false;
        }
        void pnHeaderWhite_MouseMove(object sender, MouseEventArgs e)
        {
            // if not maximized we can move our form
            if (m_MousePressed == true && m_WindowState != FormWindowState.Maximized)
            {
                Point TS = this.PointToScreen(e.Location);

                this.Location = new Point(this.Location.X + (TS.X - m_oldX),
                                          this.Location.Y + (TS.Y - m_oldY));
                m_oldX = TS.X;
                m_oldY = TS.Y;
            }
        }
        private FormWindowState m_WindowState = FormWindowState.Normal;
        #endregion
    }
}
