﻿namespace RestaurantManagerment
{
    partial class Tab2_2NhomMonAn
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
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoaNhomMonAn = new System.Windows.Forms.Button();
            this.btnSuaNhomMonAn = new System.Windows.Forms.Button();
            this.btnThemNhomMon = new System.Windows.Forms.Button();
            this.dtgrvDanhSachNhomMon = new Guna.UI.WinForms.GunaDataGridView();
            this.brboxNhomMonAn = new System.Windows.Forms.GroupBox();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.lbMaNhom = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhomMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDanhSachNhomMon)).BeginInit();
            this.brboxNhomMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lbTimKiem.Location = new System.Drawing.Point(411, 283);
            this.lbTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(90, 22);
            this.lbTimKiem.TabIndex = 90;
            this.lbTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(511, 279);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 30);
            this.txtTimKiem.TabIndex = 91;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnXoaNhomMonAn
            // 
            this.btnXoaNhomMonAn.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaNhomMonAn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhomMonAn.Location = new System.Drawing.Point(288, 277);
            this.btnXoaNhomMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNhomMonAn.Name = "btnXoaNhomMonAn";
            this.btnXoaNhomMonAn.Size = new System.Drawing.Size(107, 34);
            this.btnXoaNhomMonAn.TabIndex = 89;
            this.btnXoaNhomMonAn.Text = "Xóa";
            this.btnXoaNhomMonAn.UseVisualStyleBackColor = false;
            this.btnXoaNhomMonAn.Click += new System.EventHandler(this.btnXoaNhomMonAn_Click);
            // 
            // btnSuaNhomMonAn
            // 
            this.btnSuaNhomMonAn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaNhomMonAn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhomMonAn.Location = new System.Drawing.Point(168, 277);
            this.btnSuaNhomMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNhomMonAn.Name = "btnSuaNhomMonAn";
            this.btnSuaNhomMonAn.Size = new System.Drawing.Size(107, 34);
            this.btnSuaNhomMonAn.TabIndex = 88;
            this.btnSuaNhomMonAn.Text = "Sửa";
            this.btnSuaNhomMonAn.UseVisualStyleBackColor = false;
            this.btnSuaNhomMonAn.Click += new System.EventHandler(this.btnSuaNhomMonAn_Click);
            // 
            // btnThemNhomMon
            // 
            this.btnThemNhomMon.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThemNhomMon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhomMon.Location = new System.Drawing.Point(45, 277);
            this.btnThemNhomMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhomMon.Name = "btnThemNhomMon";
            this.btnThemNhomMon.Size = new System.Drawing.Size(107, 34);
            this.btnThemNhomMon.TabIndex = 87;
            this.btnThemNhomMon.Text = "Thêm";
            this.btnThemNhomMon.UseVisualStyleBackColor = false;
            this.btnThemNhomMon.Click += new System.EventHandler(this.btnThemNhomMon_Click);
            // 
            // dtgrvDanhSachNhomMon
            // 
            this.dtgrvDanhSachNhomMon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvDanhSachNhomMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvDanhSachNhomMon.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvDanhSachNhomMon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvDanhSachNhomMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvDanhSachNhomMon.ColumnHeadersHeight = 30;
            this.dtgrvDanhSachNhomMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvDanhSachNhomMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvDanhSachNhomMon.EnableHeadersVisualStyles = false;
            this.dtgrvDanhSachNhomMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.Location = new System.Drawing.Point(55, 346);
            this.dtgrvDanhSachNhomMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvDanhSachNhomMon.Name = "dtgrvDanhSachNhomMon";
            this.dtgrvDanhSachNhomMon.ReadOnly = true;
            this.dtgrvDanhSachNhomMon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrvDanhSachNhomMon.RowHeadersVisible = false;
            this.dtgrvDanhSachNhomMon.RowHeadersWidth = 51;
            this.dtgrvDanhSachNhomMon.RowTemplate.Height = 24;
            this.dtgrvDanhSachNhomMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvDanhSachNhomMon.Size = new System.Drawing.Size(648, 380);
            this.dtgrvDanhSachNhomMon.TabIndex = 86;
            this.dtgrvDanhSachNhomMon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgrvDanhSachNhomMon.ThemeStyle.ReadOnly = true;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.Height = 24;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgrvDanhSachNhomMon.Click += new System.EventHandler(this.dtgrvDanhSachNhomMon_Click);
            // 
            // brboxNhomMonAn
            // 
            this.brboxNhomMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.brboxNhomMonAn.Controls.Add(this.lbTenNhom);
            this.brboxNhomMonAn.Controls.Add(this.lbMaNhom);
            this.brboxNhomMonAn.Controls.Add(this.txtTenNhom);
            this.brboxNhomMonAn.Controls.Add(this.txtMaNhomMon);
            this.brboxNhomMonAn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brboxNhomMonAn.ForeColor = System.Drawing.Color.DarkViolet;
            this.brboxNhomMonAn.Location = new System.Drawing.Point(51, 36);
            this.brboxNhomMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.brboxNhomMonAn.Name = "brboxNhomMonAn";
            this.brboxNhomMonAn.Padding = new System.Windows.Forms.Padding(4);
            this.brboxNhomMonAn.Size = new System.Drawing.Size(645, 210);
            this.brboxNhomMonAn.TabIndex = 85;
            this.brboxNhomMonAn.TabStop = false;
            this.brboxNhomMonAn.Text = "Nhóm Món Ăn";
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhom.ForeColor = System.Drawing.Color.Black;
            this.lbTenNhom.Location = new System.Drawing.Point(63, 144);
            this.lbTenNhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(114, 27);
            this.lbTenNhom.TabIndex = 6;
            this.lbTenNhom.Text = "Tên Nhóm";
            // 
            // lbMaNhom
            // 
            this.lbMaNhom.AutoSize = true;
            this.lbMaNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhom.ForeColor = System.Drawing.Color.Black;
            this.lbMaNhom.Location = new System.Drawing.Point(67, 74);
            this.lbMaNhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNhom.Name = "lbMaNhom";
            this.lbMaNhom.Size = new System.Drawing.Size(109, 27);
            this.lbMaNhom.TabIndex = 5;
            this.lbMaNhom.Text = "Mã Nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(249, 138);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(295, 35);
            this.txtTenNhom.TabIndex = 3;
            // 
            // txtMaNhomMon
            // 
            this.txtMaNhomMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhomMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhomMon.Location = new System.Drawing.Point(249, 69);
            this.txtMaNhomMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhomMon.Name = "txtMaNhomMon";
            this.txtMaNhomMon.ReadOnly = true;
            this.txtMaNhomMon.Size = new System.Drawing.Size(295, 35);
            this.txtMaNhomMon.TabIndex = 2;
            // 
            // Tab2_2NhomMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoaNhomMonAn);
            this.Controls.Add(this.btnSuaNhomMonAn);
            this.Controls.Add(this.btnThemNhomMon);
            this.Controls.Add(this.dtgrvDanhSachNhomMon);
            this.Controls.Add(this.brboxNhomMonAn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tab2_2NhomMonAn";
            this.Size = new System.Drawing.Size(1087, 756);
            this.Load += new System.EventHandler(this.Tab2_2NhomMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDanhSachNhomMon)).EndInit();
            this.brboxNhomMonAn.ResumeLayout(false);
            this.brboxNhomMonAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoaNhomMonAn;
        private System.Windows.Forms.Button btnSuaNhomMonAn;
        private System.Windows.Forms.Button btnThemNhomMon;
        private Guna.UI.WinForms.GunaDataGridView dtgrvDanhSachNhomMon;
        private System.Windows.Forms.GroupBox brboxNhomMonAn;
        private System.Windows.Forms.Label lbTenNhom;
        private System.Windows.Forms.Label lbMaNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhomMon;
    }
}
