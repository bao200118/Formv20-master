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
            TaiKhoangDN = "QL002";
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
            if (TaiKhoangDN.Substring(0, 2) == "NV")
            {
                QLTD.colselected = Color.White;
                button.colbackground = Color.FromArgb(136, 59, 176);
                MessageBox.Show("Chỉ có chức vụ quản lý mới được truy cập vào mục này.");
            }
            else
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Location = new System.Drawing.Point(gunaShadowPanel1.Width, gunaGradient2Panel2.Height);
            panel1.Size = new System.Drawing.Size(this.Width - gunaShadowPanel1.Width, this.Height - gunaGradient2Panel2.Height);
            tab1.Location = new Point(0, 0);
            tab1.Size = new System.Drawing.Size(this.Width - gunaShadowPanel1.Width, this.Height - gunaGradient2Panel2.Height);
            tab2.Location = new Point(0, 0);
            tab2.Size = panel1.Size;
            tab3.Location = new Point(0, 0);
            tab3.Size = panel1.Size;
            tab4.Location = new Point(0, 0);
            tab4.Size = panel1.Size;
            tab5.Location = new Point(0, 0);
            tab5.Size = panel1.Size;
            tab3.TKDN = TaiKhoangDN;
            tab1.Quyen = TaiKhoangDN;
            tab2.ID = TaiKhoangDN;
            LoadInPanel();
            button = QLBAn;
            button.BackColor = Color.FromArgb(136, 59, 176);
        }
        private void LoadInPanel()
        {
            panel1.Controls.Add(tab1);
            panel1.Controls.Add(tab2);
            panel1.Controls.Add(tab3);
            panel1.Controls.Add(tab4);
            panel1.Controls.Add(tab5);
        }

        private void QLHD_Click(object sender, EventArgs e)
        {
            if (c != tab4)
            {
                button.colbackground = Color.White;
                tab4.BringToFront();
                tab4.PerformLayout();
                c = tab4;
                button = QLHD;
            }
        }

        private void TK_Click(object sender, EventArgs e)
        {
            if (c != tab5)
            {
                button.colbackground = Color.White;
                tab5.BringToFront();
                c = tab5;
                button = QLHD;
            }
        }

        #region MOUSE-EVENTS ON PANEL CONTROL
        // Routines to perform moving form by click & drag on TitleBar

        private bool m_MousePressed = false;
        private int m_oldX, m_oldY;
        void gunaGradient2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Point TS = this.PointToScreen(e.Location);
            m_oldX = TS.X;
            m_oldY = TS.Y;
            m_MousePressed = true;
        }
        void gunaGradient2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m_MousePressed = false;
        }
        void gunaGradient2Panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Exit_Click(sender, e);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Validated(object sender, EventArgs e)
        {
            this.Show();
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            this.Show();
        }

        private void FormMain_Layout(object sender, LayoutEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) ;
        }

        private void FormMain_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormMain_Validating(object sender, CancelEventArgs e)
        {
            this.Hide();
        }
    }
}
