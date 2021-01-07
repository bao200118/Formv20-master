namespace RestaurantManagerment
{
    partial class Tab3_1QuanLiNhanSu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab3_1QuanLiNhanSu));
            this.pnTab = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnThem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.grboxThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.cbLoaiCV = new System.Windows.Forms.ComboBox();
            this.lbChucVuDayDu = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbLuong = new System.Windows.Forms.Label();
            this.lbLoaiChucVu = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.rtxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.txtBacLuong = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.grboxGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.pnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.grboxThongTinNhanVien.SuspendLayout();
            this.grboxGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTab
            // 
            this.pnTab.BackColor = System.Drawing.Color.Transparent;
            this.pnTab.BaseColor = System.Drawing.Color.Linen;
            this.pnTab.Controls.Add(this.lbTimKiem);
            this.pnTab.Controls.Add(this.txtTimKiem);
            this.pnTab.Controls.Add(this.gunaDataGridView1);
            this.pnTab.Controls.Add(this.btnXoa);
            this.pnTab.Controls.Add(this.btnCapNhat);
            this.pnTab.Controls.Add(this.btnThem);
            this.pnTab.Controls.Add(this.grboxThongTinNhanVien);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTab.Location = new System.Drawing.Point(0, 0);
            this.pnTab.Margin = new System.Windows.Forms.Padding(4);
            this.pnTab.Name = "pnTab";
            this.pnTab.Radius = 6;
            this.pnTab.ShadowColor = System.Drawing.Color.Black;
            this.pnTab.Size = new System.Drawing.Size(1083, 804);
            this.pnTab.TabIndex = 44;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lbTimKiem.Location = new System.Drawing.Point(24, 426);
            this.lbTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(90, 22);
            this.lbTimKiem.TabIndex = 45;
            this.lbTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(119, 423);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(323, 30);
            this.txtTimKiem.TabIndex = 46;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 30;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(8, 487);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1063, 211);
            this.gunaDataGridView1.TabIndex = 44;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.gunaDataGridView1.Click += new System.EventHandler(this.gunaDataGridView1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.Red;
            this.btnXoa.BorderColor = System.Drawing.Color.Blue;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnXoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXoa.CheckedForeColor = System.Drawing.Color.White;
            this.btnXoa.CheckedImage = null;
            this.btnXoa.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXoa.LineColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(845, 407);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 5;
            this.btnXoa.Size = new System.Drawing.Size(160, 59);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.Orange;
            this.btnCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnCapNhat.BorderSize = 2;
            this.btnCapNhat.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCapNhat.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.CheckedForeColor = System.Drawing.Color.White;
            this.btnCapNhat.CheckedImage = null;
            this.btnCapNhat.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCapNhat.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnCapNhat.Location = new System.Drawing.Point(653, 407);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 5;
            this.btnCapNhat.Size = new System.Drawing.Size(160, 59);
            this.btnCapNhat.TabIndex = 42;
            this.btnCapNhat.Text = "      Cập Nhật";
            this.btnCapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnThem.BorderSize = 2;
            this.btnThem.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnThem.CheckedForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.CheckedImage = null;
            this.btnThem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnThem.Location = new System.Drawing.Point(468, 407);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 5;
            this.btnThem.Size = new System.Drawing.Size(160, 59);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "     Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // grboxThongTinNhanVien
            // 
            this.grboxThongTinNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.grboxThongTinNhanVien.Controls.Add(this.cbLoaiCV);
            this.grboxThongTinNhanVien.Controls.Add(this.lbChucVuDayDu);
            this.grboxThongTinNhanVien.Controls.Add(this.lbDiaChi);
            this.grboxThongTinNhanVien.Controls.Add(this.lbLuong);
            this.grboxThongTinNhanVien.Controls.Add(this.lbLoaiChucVu);
            this.grboxThongTinNhanVien.Controls.Add(this.lbSDT);
            this.grboxThongTinNhanVien.Controls.Add(this.lbNgaySinh);
            this.grboxThongTinNhanVien.Controls.Add(this.lbHoTen);
            this.grboxThongTinNhanVien.Controls.Add(this.rtxtDiaChi);
            this.grboxThongTinNhanVien.Controls.Add(this.txtBacLuong);
            this.grboxThongTinNhanVien.Controls.Add(this.txtChucVu);
            this.grboxThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.grboxThongTinNhanVien.Controls.Add(this.txtSoDienThoai);
            this.grboxThongTinNhanVien.Controls.Add(this.grboxGioiTinh);
            this.grboxThongTinNhanVien.Controls.Add(this.dtpNgaySinh);
            this.grboxThongTinNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxThongTinNhanVien.ForeColor = System.Drawing.Color.Purple;
            this.grboxThongTinNhanVien.Location = new System.Drawing.Point(4, 36);
            this.grboxThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grboxThongTinNhanVien.Name = "grboxThongTinNhanVien";
            this.grboxThongTinNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grboxThongTinNhanVien.Size = new System.Drawing.Size(1079, 364);
            this.grboxThongTinNhanVien.TabIndex = 3;
            this.grboxThongTinNhanVien.TabStop = false;
            this.grboxThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // cbLoaiCV
            // 
            this.cbLoaiCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiCV.FormattingEnabled = true;
            this.cbLoaiCV.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbLoaiCV.Location = new System.Drawing.Point(732, 63);
            this.cbLoaiCV.Name = "cbLoaiCV";
            this.cbLoaiCV.Size = new System.Drawing.Size(293, 33);
            this.cbLoaiCV.TabIndex = 16;
            // 
            // lbChucVuDayDu
            // 
            this.lbChucVuDayDu.AutoSize = true;
            this.lbChucVuDayDu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVuDayDu.ForeColor = System.Drawing.Color.Black;
            this.lbChucVuDayDu.Location = new System.Drawing.Point(585, 114);
            this.lbChucVuDayDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChucVuDayDu.Name = "lbChucVuDayDu";
            this.lbChucVuDayDu.Size = new System.Drawing.Size(133, 22);
            this.lbChucVuDayDu.TabIndex = 15;
            this.lbChucVuDayDu.Text = "Chức vụ đầy đủ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(636, 238);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(72, 22);
            this.lbDiaChi.TabIndex = 14;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuong.ForeColor = System.Drawing.Color.Black;
            this.lbLuong.Location = new System.Drawing.Point(644, 167);
            this.lbLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(61, 22);
            this.lbLuong.TabIndex = 13;
            this.lbLuong.Text = "Lương";
            // 
            // lbLoaiChucVu
            // 
            this.lbLoaiChucVu.AutoSize = true;
            this.lbLoaiChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiChucVu.ForeColor = System.Drawing.Color.Black;
            this.lbLoaiChucVu.Location = new System.Drawing.Point(585, 65);
            this.lbLoaiChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiChucVu.Name = "lbLoaiChucVu";
            this.lbLoaiChucVu.Size = new System.Drawing.Size(120, 22);
            this.lbLoaiChucVu.TabIndex = 12;
            this.lbLoaiChucVu.Text = "Loại Chức Vụ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Black;
            this.lbSDT.Location = new System.Drawing.Point(43, 169);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(125, 22);
            this.lbSDT.TabIndex = 11;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lbNgaySinh.Location = new System.Drawing.Point(77, 116);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(91, 22);
            this.lbNgaySinh.TabIndex = 10;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Black;
            this.lbHoTen.Location = new System.Drawing.Point(72, 63);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(96, 22);
            this.lbHoTen.TabIndex = 9;
            this.lbHoTen.Text = "Họ Và Tên";
            // 
            // rtxtDiaChi
            // 
            this.rtxtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDiaChi.Location = new System.Drawing.Point(732, 238);
            this.rtxtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDiaChi.Name = "rtxtDiaChi";
            this.rtxtDiaChi.Size = new System.Drawing.Size(293, 101);
            this.rtxtDiaChi.TabIndex = 6;
            this.rtxtDiaChi.Text = "";
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBacLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacLuong.Location = new System.Drawing.Point(732, 167);
            this.txtBacLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(293, 30);
            this.txtBacLuong.TabIndex = 5;
            this.txtBacLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBacLuong_KeyPress);
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(732, 114);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(293, 30);
            this.txtChucVu.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(195, 63);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(293, 30);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(195, 167);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(293, 30);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // grboxGioiTinh
            // 
            this.grboxGioiTinh.Controls.Add(this.rdNu);
            this.grboxGioiTinh.Controls.Add(this.rdNam);
            this.grboxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxGioiTinh.Location = new System.Drawing.Point(195, 238);
            this.grboxGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.grboxGioiTinh.Name = "grboxGioiTinh";
            this.grboxGioiTinh.Padding = new System.Windows.Forms.Padding(4);
            this.grboxGioiTinh.Size = new System.Drawing.Size(293, 101);
            this.grboxGioiTinh.TabIndex = 2;
            this.grboxGioiTinh.TabStop = false;
            this.grboxGioiTinh.Text = "Giới Tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.Black;
            this.rdNu.Location = new System.Drawing.Point(196, 43);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(56, 26);
            this.rdNu.TabIndex = 11;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.ForeColor = System.Drawing.Color.Black;
            this.rdNam.Location = new System.Drawing.Point(83, 43);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(68, 26);
            this.rdNam.TabIndex = 10;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(195, 114);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(292, 30);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AllowUserToResizeColumns = false;
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(-336, 814);
            this.dgvDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(1759, 100);
            this.dgvDanhSachNhanVien.TabIndex = 2;
            // 
            // Tab3_1QuanLiNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tab3_1QuanLiNhanSu";
            this.Size = new System.Drawing.Size(1087, 804);
            this.Load += new System.EventHandler(this.Tab3QuanLiNhanSu_Load);
            this.pnTab.ResumeLayout(false);
            this.pnTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.grboxThongTinNhanVien.ResumeLayout(false);
            this.grboxThongTinNhanVien.PerformLayout();
            this.grboxGioiTinh.ResumeLayout(false);
            this.grboxGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnTab;
        private System.Windows.Forms.GroupBox grboxThongTinNhanVien;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Label lbLoaiChucVu;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.RichTextBox rtxtDiaChi;
        private System.Windows.Forms.TextBox txtBacLuong;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.GroupBox grboxGioiTinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoa;
        private Guna.UI.WinForms.GunaAdvenceButton btnCapNhat;
        private Guna.UI.WinForms.GunaAdvenceButton btnThem;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbLoaiCV;
        private System.Windows.Forms.Label lbChucVuDayDu;
    }
}
