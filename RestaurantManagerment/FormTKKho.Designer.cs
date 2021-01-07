namespace RestaurantManagerment
{
    partial class FormTKKho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTKKho));
            this.pnTK = new Guna.UI.WinForms.GunaShadowPanel();
            this.pnTKPicture = new System.Windows.Forms.Panel();
            this.btnOK = new Guna.UI.WinForms.GunaAdvenceButton();
            this.flplistNL = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.lbTK = new System.Windows.Forms.Label();
            this.pnTK.SuspendLayout();
            this.pnTKPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTK
            // 
            this.pnTK.BackColor = System.Drawing.Color.DarkGray;
            this.pnTK.BaseColor = System.Drawing.Color.White;
            this.pnTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTK.Controls.Add(this.pnTKPicture);
            this.pnTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTK.Location = new System.Drawing.Point(0, 0);
            this.pnTK.Margin = new System.Windows.Forms.Padding(4);
            this.pnTK.Name = "pnTK";
            this.pnTK.ShadowColor = System.Drawing.Color.Crimson;
            this.pnTK.Size = new System.Drawing.Size(694, 424);
            this.pnTK.TabIndex = 0;
            // 
            // pnTKPicture
            // 
            this.pnTKPicture.BackColor = System.Drawing.Color.DarkGray;
            this.pnTKPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTKPicture.BackgroundImage")));
            this.pnTKPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTKPicture.Controls.Add(this.btnOK);
            this.pnTKPicture.Controls.Add(this.flplistNL);
            this.pnTKPicture.Controls.Add(this.btnClose);
            this.pnTKPicture.Controls.Add(this.lbTK);
            this.pnTKPicture.Location = new System.Drawing.Point(5, 5);
            this.pnTKPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pnTKPicture.Name = "pnTKPicture";
            this.pnTKPicture.Size = new System.Drawing.Size(683, 413);
            this.pnTKPicture.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.AnimationHoverSpeed = 0.07F;
            this.btnOK.AnimationSpeed = 0.03F;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.BorderColor = System.Drawing.Color.Blue;
            this.btnOK.BorderSize = 2;
            this.btnOK.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnOK.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnOK.CheckedForeColor = System.Drawing.Color.White;
            this.btnOK.CheckedImage = null;
            this.btnOK.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = null;
            this.btnOK.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOK.LineColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(293, 355);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.btnOK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOK.OnHoverImage = null;
            this.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.btnOK.Radius = 5;
            this.btnOK.Size = new System.Drawing.Size(104, 40);
            this.btnOK.TabIndex = 66;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // flplistNL
            // 
            this.flplistNL.AutoScroll = true;
            this.flplistNL.BackColor = System.Drawing.Color.Gray;
            this.flplistNL.Location = new System.Drawing.Point(115, 90);
            this.flplistNL.Name = "flplistNL";
            this.flplistNL.Size = new System.Drawing.Size(476, 252);
            this.flplistNL.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(652, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.BackColor = System.Drawing.Color.Transparent;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.ForeColor = System.Drawing.SystemColors.Info;
            this.lbTK.Location = new System.Drawing.Point(109, 33);
            this.lbTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(482, 31);
            this.lbTK.TabIndex = 4;
            this.lbTK.Text = "Thống kê số lượng nguyên liệu dùng";
            // 
            // FormTKKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(694, 424);
            this.Controls.Add(this.pnTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(507, 123);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTKKho";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuyenBan";
            this.Load += new System.EventHandler(this.FormTKKho_Load);
            this.pnTK.ResumeLayout(false);
            this.pnTKPicture.ResumeLayout(false);
            this.pnTKPicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnTK;
        private System.Windows.Forms.Panel pnTKPicture;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.FlowLayoutPanel flplistNL;
        private Guna.UI.WinForms.GunaAdvenceButton btnOK;
    }
}