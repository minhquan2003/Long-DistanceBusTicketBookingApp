namespace QuanLyXeKhach.Form_UC_KhachHang
{
    partial class UC_KH_DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KH_DichVu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DTGV_DanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.pl_XemChiTietDichVu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnTimDichVu = new QuanLyXeKhach.CustomButton();
            this.txtTimKiemDichVu = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CCBTimDichVu = new System.Windows.Forms.ComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.customButton1 = new QuanLyXeKhach.CustomButton();
            this.customButton4 = new QuanLyXeKhach.CustomButton();
            this.customButton2 = new QuanLyXeKhach.CustomButton();
            this.customButton3 = new QuanLyXeKhach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DanhSachDichVu)).BeginInit();
            this.pl_XemChiTietDichVu.SuspendLayout();
            this.pl_TimKiemDichVu.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(369, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỊCH VỤ NỔI BẬT";
            // 
            // DTGV_DanhSachDichVu
            // 
            this.DTGV_DanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_DanhSachDichVu.Location = new System.Drawing.Point(37, 438);
            this.DTGV_DanhSachDichVu.Name = "DTGV_DanhSachDichVu";
            this.DTGV_DanhSachDichVu.RowHeadersWidth = 51;
            this.DTGV_DanhSachDichVu.RowTemplate.Height = 24;
            this.DTGV_DanhSachDichVu.Size = new System.Drawing.Size(550, 292);
            this.DTGV_DanhSachDichVu.TabIndex = 11;
            // 
            // pl_XemChiTietDichVu
            // 
            this.pl_XemChiTietDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pl_XemChiTietDichVu.Controls.Add(this.label2);
            this.pl_XemChiTietDichVu.Location = new System.Drawing.Point(594, 295);
            this.pl_XemChiTietDichVu.Name = "pl_XemChiTietDichVu";
            this.pl_XemChiTietDichVu.Size = new System.Drawing.Size(498, 435);
            this.pl_XemChiTietDichVu.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi tiết dịch vụ";
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Controls.Add(this.btnTimDichVu);
            this.pl_TimKiemDichVu.Controls.Add(this.txtTimKiemDichVu);
            this.pl_TimKiemDichVu.Controls.Add(this.bunifuLabel1);
            this.pl_TimKiemDichVu.Controls.Add(this.CCBTimDichVu);
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(37, 295);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(550, 131);
            this.pl_TimKiemDichVu.TabIndex = 10;
            // 
            // btnTimDichVu
            // 
            this.btnTimDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTimDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTimDichVu.BorderRadius = 45;
            this.btnTimDichVu.BorderSize = 0;
            this.btnTimDichVu.FlatAppearance.BorderSize = 0;
            this.btnTimDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnTimDichVu.Location = new System.Drawing.Point(392, 45);
            this.btnTimDichVu.Name = "btnTimDichVu";
            this.btnTimDichVu.Size = new System.Drawing.Size(130, 49);
            this.btnTimDichVu.TabIndex = 3;
            this.btnTimDichVu.Text = "Tìm kiếm";
            this.btnTimDichVu.TextColor = System.Drawing.Color.Black;
            this.btnTimDichVu.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemDichVu
            // 
            this.txtTimKiemDichVu.Location = new System.Drawing.Point(22, 82);
            this.txtTimKiemDichVu.Name = "txtTimKiemDichVu";
            this.txtTimKiemDichVu.Size = new System.Drawing.Size(348, 30);
            this.txtTimKiemDichVu.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(147, 24);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Tìm kiếm theo :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CCBTimDichVu
            // 
            this.CCBTimDichVu.FormattingEnabled = true;
            this.CCBTimDichVu.Location = new System.Drawing.Point(188, 29);
            this.CCBTimDichVu.Name = "CCBTimDichVu";
            this.CCBTimDichVu.Size = new System.Drawing.Size(182, 32);
            this.CCBTimDichVu.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.customButton1);
            this.bunifuPanel1.Controls.Add(this.customButton4);
            this.bunifuPanel1.Controls.Add(this.customButton2);
            this.bunifuPanel1.Controls.Add(this.customButton3);
            this.bunifuPanel1.Location = new System.Drawing.Point(37, 76);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1048, 204);
            this.bunifuPanel1.TabIndex = 9;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgoroundColor = System.Drawing.Color.White;
            this.customButton1.BackgroundImage = global::QuanLyXeKhach.Properties.Resources.Screenshot_2023_11_11_200509;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton1.BorderRadius = 50;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(14, 13);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(246, 177);
            this.customButton1.TabIndex = 3;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.White;
            this.customButton4.BackgoroundColor = System.Drawing.Color.White;
            this.customButton4.BackgroundImage = global::QuanLyXeKhach.Properties.Resources.Screenshot_2023_11_11_210053;
            this.customButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton4.BorderRadius = 50;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(795, 13);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(239, 177);
            this.customButton4.TabIndex = 7;
            this.customButton4.TextColor = System.Drawing.Color.White;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.BackgoroundColor = System.Drawing.Color.White;
            this.customButton2.BackgroundImage = global::QuanLyXeKhach.Properties.Resources.Screenshot_2023_11_11_201343;
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton2.BorderRadius = 50;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(279, 13);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(239, 177);
            this.customButton2.TabIndex = 5;
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.White;
            this.customButton3.BackgoroundColor = System.Drawing.Color.White;
            this.customButton3.BackgroundImage = global::QuanLyXeKhach.Properties.Resources.Screenshot_2023_11_11_202019;
            this.customButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton3.BorderRadius = 50;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(537, 13);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(239, 177);
            this.customButton3.TabIndex = 6;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // UC_KH_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pl_XemChiTietDichVu);
            this.Controls.Add(this.DTGV_DanhSachDichVu);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_KH_DichVu";
            this.Size = new System.Drawing.Size(1142, 749);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DanhSachDichVu)).EndInit();
            this.pl_XemChiTietDichVu.ResumeLayout(false);
            this.pl_XemChiTietDichVu.PerformLayout();
            this.pl_TimKiemDichVu.ResumeLayout(false);
            this.pl_TimKiemDichVu.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private CustomButton customButton1;
        private CustomButton customButton4;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private CustomButton btnTimDichVu;
        private System.Windows.Forms.TextBox txtTimKiemDichVu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.ComboBox CCBTimDichVu;
        private System.Windows.Forms.DataGridView DTGV_DanhSachDichVu;
        private System.Windows.Forms.Panel pl_XemChiTietDichVu;
        private System.Windows.Forms.Label label2;
    }
}
