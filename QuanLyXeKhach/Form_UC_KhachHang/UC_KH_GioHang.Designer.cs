namespace QuanLyXeKhach.Form_UC_KhachHang
{
    partial class UC_KH_GioHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KH_GioHang));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGV_danhsachvedat = new System.Windows.Forms.DataGridView();
            this.btnXemChiTietVe = new QuanLyXeKhach.CustomButton();
            this.btnHuyVe = new QuanLyXeKhach.CustomButton();
            this.btnThanhToan = new QuanLyXeKhach.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.DTGV_dichvudat = new System.Windows.Forms.DataGridView();
            this.btnHuyDichVu = new QuanLyXeKhach.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuayLai = new QuanLyXeKhach.CustomButton();
            this.pl_NhapMaUuDai = new Bunifu.UI.WinForms.BunifuPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapMaUuDai = new System.Windows.Forms.TextBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_danhsachvedat)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_dichvudat)).BeginInit();
            this.pl_NhapMaUuDai.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(23, 99);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1068, 72);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VÉ CÓ TRONG GIỎ ";
            // 
            // DTGV_danhsachvedat
            // 
            this.DTGV_danhsachvedat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_danhsachvedat.Location = new System.Drawing.Point(34, 191);
            this.DTGV_danhsachvedat.Name = "DTGV_danhsachvedat";
            this.DTGV_danhsachvedat.RowHeadersWidth = 51;
            this.DTGV_danhsachvedat.RowTemplate.Height = 24;
            this.DTGV_danhsachvedat.Size = new System.Drawing.Size(828, 461);
            this.DTGV_danhsachvedat.TabIndex = 1;
            // 
            // btnXemChiTietVe
            // 
            this.btnXemChiTietVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXemChiTietVe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXemChiTietVe.BorderRadius = 46;
            this.btnXemChiTietVe.BorderSize = 0;
            this.btnXemChiTietVe.FlatAppearance.BorderSize = 0;
            this.btnXemChiTietVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTietVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietVe.ForeColor = System.Drawing.Color.Black;
            this.btnXemChiTietVe.Location = new System.Drawing.Point(875, 286);
            this.btnXemChiTietVe.Name = "btnXemChiTietVe";
            this.btnXemChiTietVe.Size = new System.Drawing.Size(200, 49);
            this.btnXemChiTietVe.TabIndex = 2;
            this.btnXemChiTietVe.Text = "Xem chi tiết vé";
            this.btnXemChiTietVe.TextColor = System.Drawing.Color.Black;
            this.btnXemChiTietVe.UseVisualStyleBackColor = false;
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyVe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyVe.BorderRadius = 46;
            this.btnHuyVe.BorderSize = 0;
            this.btnHuyVe.FlatAppearance.BorderSize = 0;
            this.btnHuyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVe.ForeColor = System.Drawing.Color.Black;
            this.btnHuyVe.Location = new System.Drawing.Point(875, 504);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(208, 49);
            this.btnHuyVe.TabIndex = 3;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.TextColor = System.Drawing.Color.Black;
            this.btnHuyVe.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.btnThanhToan.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.btnThanhToan.BorderRadius = 46;
            this.btnThanhToan.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(863, 1052);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(228, 82);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextColor = System.Drawing.Color.Black;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH DỊCH VỤ ĐÃ ĐĂNG KÍ";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel2.BorderRadius = 35;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Location = new System.Drawing.Point(36, 671);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1055, 72);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // DTGV_dichvudat
            // 
            this.DTGV_dichvudat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_dichvudat.Location = new System.Drawing.Point(34, 764);
            this.DTGV_dichvudat.Name = "DTGV_dichvudat";
            this.DTGV_dichvudat.RowHeadersWidth = 51;
            this.DTGV_dichvudat.RowTemplate.Height = 24;
            this.DTGV_dichvudat.Size = new System.Drawing.Size(828, 196);
            this.DTGV_dichvudat.TabIndex = 5;
            // 
            // btnHuyDichVu
            // 
            this.btnHuyDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyDichVu.BorderRadius = 46;
            this.btnHuyDichVu.BorderSize = 0;
            this.btnHuyDichVu.FlatAppearance.BorderSize = 0;
            this.btnHuyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDichVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnHuyDichVu.Location = new System.Drawing.Point(875, 909);
            this.btnHuyDichVu.Name = "btnHuyDichVu";
            this.btnHuyDichVu.Size = new System.Drawing.Size(200, 49);
            this.btnHuyDichVu.TabIndex = 6;
            this.btnHuyDichVu.Text = "Hủy dịch vụ";
            this.btnHuyDichVu.TextColor = System.Drawing.Color.Black;
            this.btnHuyDichVu.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(469, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "GIỎ HÀNG ";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQuayLai.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQuayLai.BorderRadius = 46;
            this.btnQuayLai.BorderSize = 0;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.Location = new System.Drawing.Point(875, 395);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(208, 49);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextColor = System.Drawing.Color.Black;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // pl_NhapMaUuDai
            // 
            this.pl_NhapMaUuDai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_NhapMaUuDai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_NhapMaUuDai.BackgroundImage")));
            this.pl_NhapMaUuDai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_NhapMaUuDai.BorderColor = System.Drawing.Color.Black;
            this.pl_NhapMaUuDai.BorderRadius = 35;
            this.pl_NhapMaUuDai.BorderThickness = 1;
            this.pl_NhapMaUuDai.Controls.Add(this.txtNhapMaUuDai);
            this.pl_NhapMaUuDai.Controls.Add(this.label4);
            this.pl_NhapMaUuDai.Location = new System.Drawing.Point(34, 978);
            this.pl_NhapMaUuDai.Name = "pl_NhapMaUuDai";
            this.pl_NhapMaUuDai.ShowBorders = true;
            this.pl_NhapMaUuDai.Size = new System.Drawing.Size(535, 170);
            this.pl_NhapMaUuDai.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập mã code ưu đãi nếu có :";
            // 
            // txtNhapMaUuDai
            // 
            this.txtNhapMaUuDai.Location = new System.Drawing.Point(27, 57);
            this.txtNhapMaUuDai.Name = "txtNhapMaUuDai";
            this.txtNhapMaUuDai.Size = new System.Drawing.Size(273, 22);
            this.txtNhapMaUuDai.TabIndex = 1;
            // 
            // UC_KH_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pl_NhapMaUuDai);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuyDichVu);
            this.Controls.Add(this.DTGV_dichvudat);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.btnXemChiTietVe);
            this.Controls.Add(this.DTGV_danhsachvedat);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KH_GioHang";
            this.Size = new System.Drawing.Size(1131, 1180);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_danhsachvedat)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_dichvudat)).EndInit();
            this.pl_NhapMaUuDai.ResumeLayout(false);
            this.pl_NhapMaUuDai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private CustomButton btnHuyVe;
        private CustomButton btnXemChiTietVe;
        private System.Windows.Forms.DataGridView DTGV_danhsachvedat;
        private System.Windows.Forms.Label label1;
        private CustomButton btnThanhToan;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label label2;
        private CustomButton btnHuyDichVu;
        private System.Windows.Forms.DataGridView DTGV_dichvudat;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuPanel pl_NhapMaUuDai;
        private System.Windows.Forms.TextBox txtNhapMaUuDai;
        private System.Windows.Forms.Label label4;
        private CustomButton btnQuayLai;
    }
}
